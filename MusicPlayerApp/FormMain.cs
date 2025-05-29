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


        }

        private void LoadSongs()
        {
            string filePath = "songs.xml";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Fișierul songs.xml nu a fost găsit!");
                return;
            }

            try
            {
                songs.Clear();
                XDocument doc = XDocument.Load(filePath);

                songs = doc.Descendants("Song").Select(s => new Song(s.Element("Title")?.Value.Trim(),s.Element("Artist")?.Value.Trim())).ToList();
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
            FormAddSong addSongForm = new FormAddSong();
            addSongForm.ShowDialog();
            var newSong = new Song(addSongForm.SongTitle, addSongForm.SongArtist);
            songs.Add(newSong);
            RefreshDataGrid();
            SaveSongsToFile();
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
                MessageBox.Show("Selectați o melodie pentru a o șterge.");
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
                MessageBox.Show("Selectați o melodie pentru a o edita.");
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
                MessageBox.Show("Selectează o melodie din listă.");
                return;
            }

            var selectedSong = songs[dataGridViewSongs.SelectedRows[0].Index];
            string wavFilePath = Path.Combine(Application.StartupPath, "Music", $"{selectedSong.Title}.wav");

            if (!File.Exists(wavFilePath))
            {
                MessageBox.Show($"Fișierul audio nu a fost găsit:\n{wavFilePath}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentPlayer = new SoundPlayer(wavFilePath);
            currentPlayer.Play();
            lblNowPlaying.Text = $"Now Playing: {selectedSong.Title} - {selectedSong.Artist}";
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
                MessageBox.Show("Nu este nicio melodie în redare.");
            }
        }

     
    }
}
