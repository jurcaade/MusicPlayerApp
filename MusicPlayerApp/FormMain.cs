using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MusicPlayerApp
{
    public partial class FormMain : Form
    {
        private List<Song> songs; // Lista pentru melodiile incarcate
        private SoundPlayer currentPlayer; // Playerul pentru redarea melodiilor
        public FormMain()
        {
            InitializeComponent();
            songs = new List<Song>();
            LoadSongs();

            // Atasam evenimentele pentru drag & drop pe DataGridView
            dataGridViewSongs.DragEnter += DataGridView_DragEnter;
            dataGridViewSongs.DragDrop += DataGridView_DragDrop;
        }

        // Functie pentru incarcarea melodiilor din fisier
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
                songs.Clear(); // Golim lista curenta
                XDocument doc = XDocument.Load(filePath);   // Incarcam fisierul XML

                songs = doc.Descendants("Song").Select(s => new Song(s.Element("Title")?.Value.Trim(), s.Element("Artist")?.Value.Trim(), s.Element("OriginalFileName")?.Value?.Trim())).ToList();
                RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fișierului XML: {ex.Message}");
            }
        }
        // Functie pentru actualizarea afisarii in DataGridView
        private void RefreshDataGrid()
        {
            dataGridViewSongs.DataSource = null;
            dataGridViewSongs.DataSource = songs;
        }

        private void btnAdaugaPiesa_Click(object sender, EventArgs e)
        {
            // Creaza o instanta a formularului pentru adaugarea unei piese
            using (FormAddSong addSongForm = new FormAddSong())
            {
                // Afiseaza formularul ca dialog modal si asteapta raspunsul utilizatorului
                if (addSongForm.ShowDialog() == DialogResult.OK)
                {
                    var newSong = new Song(addSongForm.SongTitle, addSongForm.SongArtist, $"{addSongForm.SongTitle} - {addSongForm.SongArtist}");
                    songs.Add(newSong);
                    RefreshDataGrid();
                    SaveSongsToFile();
                }
            }
        }

        private void btnStergePiesa_Click(object sender, EventArgs e)
        {
            // Verifica daca exista un rand selectat in DataGridView
            if (dataGridViewSongs.CurrentRow != null)
            {

                var selectedIndex = dataGridViewSongs.CurrentRow.Index; // Obtine indexul randului selectat
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
            string filePath = "songs.xml";  // Specifica calea fisierului XML

            // Creeaza un document XML cu elementul radacina "Songs"
            XDocument doc = new XDocument(
                new XElement("Songs",
                    // Pentru fiecare melodie din lista, creeaza un element "Song"
                    songs.Select(song =>
                        new XElement("Song",
                            new XElement("Title", song.Title),
                            new XElement("Artist", song.Artist),
                            new XElement("OriginalFileName", song.OriginalFileName)
                        )
                    )
                )
            );

            doc.Save(filePath);  // Salveaza documentul XML in fisier
        }

        private void searchSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creeaza o instanta a formularului de cautare, trimitand lista de melodii ca parametru
            FormSearchSong searchForm = new FormSearchSong(songs);
            searchForm.ShowDialog();
        }

        private void editSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSongs.CurrentRow != null)
            {
                int selectedIndex = dataGridViewSongs.CurrentRow.Index;  // Obtine indexul randului curent
                Song selectedSong = songs[selectedIndex];  // Obtine obiectul Song asociat randului curent

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
            // Opreste si elibereaza orice melodie care este deja in redare
            if (currentPlayer != null)
            {
                currentPlayer.Stop();
                currentPlayer.Dispose();
            }

            // Verifica daca este selectata o melodie
            if (dataGridViewSongs.CurrentRow == null)
            {
                MessageBox.Show("Selectează o melodie din listă.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedSong = songs[dataGridViewSongs.CurrentRow.Index];
            // Creeaza calea catre fisierul .wav corespunzator
            string wavFilePath = Path.Combine(Application.StartupPath, "Music", $"{selectedSong.OriginalFileName}.wav");

            // Verifica daca fisierul audio exista
            if (!File.Exists(wavFilePath))
            {
                MessageBox.Show($"Fișierul audio nu a fost găsit:\n{wavFilePath}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reda fisierul audio folosind SoundPlayer
            currentPlayer = new SoundPlayer(wavFilePath);
            currentPlayer.Play();

            // Afiseaza informatii despre melodia care se reda
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

        private void DataGridView_DragEnter(object sender, DragEventArgs e)
        {
            // Daca se trag fisiere peste DataGridView, permite efectul de copiere
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void DataGridView_DragDrop(object sender, DragEventArgs e)
        {
            // Daca exista fisiere drop-uite
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);  // Preia lista de fisiere drop-uite
                foreach (var file in files.Where(f => f.EndsWith(".wav")))   // Pentru fiecare fisier care are extensia .wav il adauga in aplicatie
                    AddSongFromFile(file);
            }
        }

        private void AddSongFromFile(string filePath)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);  // Obtine numele fisierului fara extensie
            var destPath = Path.Combine(Application.StartupPath, "Music", Path.GetFileName(filePath));  // Creeaza calea destinatiei in folderul "Music"

            // Copiaza fisierul daca nu exista deja in folderul "Music"
            if (!File.Exists(destPath))
                File.Copy(filePath, destPath);

            // Imparte numele fisierului dupa caracterul '-' pentru a obtine titlul si artistul
            var parts = fileName.Split('-');
            var title = parts[0].Trim();
            var artist = parts.Length > 1 ? parts[1].Trim() : "Unknown Artist";

            // Verifica daca melodia exista deja in lista
            if (!songs.Any(s => s.OriginalFileName.Equals(fileName, StringComparison.OrdinalIgnoreCase)))
            {
                // Adauga melodia in lista si actualizeaza afisarea si fisierul
                songs.Add(new Song(title, artist, fileName));
                RefreshDataGrid();
                SaveSongsToFile();
                MessageBox.Show($"Piesa '{title} - {artist}' a fost adăugată cu succes!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Piesa '{title} - {artist}' există deja în listă!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
    