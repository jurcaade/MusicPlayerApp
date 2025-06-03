using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MusicPlayerApp
{
    public partial class FormMain : Form
    {
        private List<Song> songs;
        private SoundPlayer currentPlayer;
        public FormMain()
        {
            InitializeComponent();
            songs = new List<Song>();
            LoadSongs();

            // Enable drag & drop pentru form
            this.AllowDrop = true;
            this.DragEnter += FormMain_DragEnter;
            this.DragDrop += FormMain_DragDrop;

            dataGridViewSongs.AllowDrop = true;
            dataGridViewSongs.DragEnter += DataGridView_DragEnter;
            dataGridViewSongs.DragDrop += DataGridView_DragDrop;
        }

        private void LoadSongs()
        {
            string filePath = "songs.xml";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Fișierul songs.xml nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                songs.Clear();
                XDocument doc = XDocument.Load(filePath);

                songs = doc.Descendants("Song").Select(s => new Song(s.Element("Title")?.Value.Trim(), s.Element("Artist")?.Value.Trim())).ToList();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fișierului XML: {ex.Message}");
            }
        }
        private void RefreshDataGrid()
        {
            dataGridViewSongs.DataSource = null;
            dataGridViewSongs.DataSource = songs;
        }

        private void btnAdaugaPiesa_Click(object sender, EventArgs e)
        {
            using (FormAddSong addSongForm = new FormAddSong())
            {
                if (addSongForm.ShowDialog() == DialogResult.OK)
                {
                    var newSong = new Song(addSongForm.SongTitle, addSongForm.SongArtist);
                    songs.Add(newSong);
                    RefreshDataGrid();
                    SaveSongsToFile();
                }
            }
        }

        private void btnStergePiesa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSongs.SelectedRows.Count > 0)
            {
                var selectedIndex = dataGridViewSongs.SelectedRows[0].Index;
                songs.RemoveAt(selectedIndex);
                RefreshDataGrid();
                SaveSongsToFile();
            }
            else
            {
                MessageBox.Show("Selectați o melodie pentru a o șterge.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveSongsToFile()
        {
            string filePath = "songs.xml";

            XDocument doc = new XDocument(
                new XElement("Songs",
                    songs.Select(song =>
                        new XElement("Song",
                            new XElement("Title", song.Title),
                            new XElement("Artist", song.Artist)
                        )
                    )
                )
            );

            doc.Save(filePath);
        }

        private void searchSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchSong searchForm = new FormSearchSong(songs);
            searchForm.ShowDialog();
        }

        private void editSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSongs.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewSongs.SelectedRows[0].Index;
                Song selectedSong = songs[selectedIndex];

                FormEditSong editForm = new FormEditSong(selectedSong);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    selectedSong.Title = editForm.UpdatedTitle;
                    selectedSong.Artist = editForm.UpdatedArtist;
                    RefreshDataGrid();
                    SaveSongsToFile();
                }
            }
            else
            {
                MessageBox.Show("Selectați o melodie pentru a o edita.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void PlaySelectedSong()
        {
            if (currentPlayer != null)
            {
                currentPlayer.Stop();
                currentPlayer.Dispose();
            }

            if (dataGridViewSongs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează o melodie din listă.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedSong = songs[dataGridViewSongs.SelectedRows[0].Index];
            string wavFilePath = Path.Combine(Application.StartupPath, "Music", $"{selectedSong.Title} - {selectedSong.Artist}.wav");

            if (!File.Exists(wavFilePath))
            {
                MessageBox.Show($"Fișierul audio nu a fost găsit:\n{wavFilePath}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentPlayer = new SoundPlayer(wavFilePath);
            currentPlayer.Play();
            lblNowPlaying.Text = $"♪ Now Playing: {selectedSong.Title} - {selectedSong.Artist}";
        }



        private void btnPlaySong_Click(object sender, EventArgs e)
        {
            PlaySelectedSong();
        }

        private void btnStopSong_Click(object sender, EventArgs e)
        {
            if (currentPlayer != null)
            {
                currentPlayer.Stop();
                lblNowPlaying.Text = "Music Player App";
            }
            else
            {
                MessageBox.Show("Nu este nicio melodie în redare.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                bool hasAudioFiles = files.Any(f => Path.GetExtension(f).Equals(".wav", StringComparison.OrdinalIgnoreCase));

                e.Effect = hasAudioFiles ? DragDropEffects.Copy : DragDropEffects.None;
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(".wav", StringComparison.OrdinalIgnoreCase))
                {
                    AddSongFromFile(file);
                }
            }
        }

        private void DataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move; // Permite reordonarea în DataGridView
            }
            else
            {
                FormMain_DragEnter(sender, e); // Permite drop de fișiere .wav
            }
        }

        private void DataGridView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                Point clientPoint = dataGridViewSongs.PointToClient(new Point(e.X, e.Y));
                int targetRowIndex = dataGridViewSongs.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                if (targetRowIndex >= 0 && dataGridViewSongs.SelectedRows.Count > 0)
                {
                    int sourceRowIndex = dataGridViewSongs.SelectedRows[0].Index;
                    ReorderSongs(sourceRowIndex, targetRowIndex);
                }
            }
            else
            {
                FormMain_DragDrop(sender, e);
            }
        }

        private void AddSongFromFile(string filePath)
        {
            try
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string musicFolder = Path.Combine(Application.StartupPath, "Music");

                if (!Directory.Exists(musicFolder))
                    Directory.CreateDirectory(musicFolder);

                string destPath = Path.Combine(musicFolder, Path.GetFileName(filePath));
                if (!File.Exists(destPath))
                    File.Copy(filePath, destPath);

                // Presupunem formatul "Titlu - Artist.wav"
                string[] separators = new[] { " - ", "-", "_" };
                string[] parts = fileName.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string title = parts.Length > 0 ? parts[0].Trim() : fileName;
                string artist = parts.Length > 1 ? parts[1].Trim() : "Unknown Artist";

                bool exists = songs.Any(s =>
                    string.Equals(s.Title, title, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(s.Artist, artist, StringComparison.OrdinalIgnoreCase));

                if (!exists)
                {
                    songs.Add(new Song(title, artist));
                    RefreshDataGrid();
                    SaveSongsToFile();

                    MessageBox.Show($"Melodia '{title}' a fost adăugată cu succes!",
                                    "Drag & Drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Melodia '{title}' există deja în listă!",
                                    "Drag & Drop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adăugarea fișierului: {ex.Message}",
                                "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReorderSongs(int sourceIndex, int targetIndex)
        {
            if (sourceIndex == targetIndex ||
                sourceIndex < 0 || targetIndex < 0 ||
                sourceIndex >= songs.Count || targetIndex >= songs.Count)
            {
                return;
            }

            var song = songs[sourceIndex];
            songs.RemoveAt(sourceIndex);
            songs.Insert(targetIndex, song);

            RefreshDataGrid();
            SaveSongsToFile();

            if (targetIndex < dataGridViewSongs.Rows.Count)
            {
                dataGridViewSongs.ClearSelection();
                dataGridViewSongs.Rows[targetIndex].Selected = true;
            }
        }
    }
}
    