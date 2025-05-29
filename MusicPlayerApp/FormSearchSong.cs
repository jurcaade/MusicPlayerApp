using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class FormSearchSong : Form
    {
        private List<Song> songs;

        public FormSearchSong(List<Song> existingSongs)
        {
            InitializeComponent();
            songs = existingSongs;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.ToLower();
           
            //Validare camp gol
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Introduceți un cuvânt cheie pentru căutare!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSearch.Focus();
                return;
            }

            listBoxResults.Items.Clear();
            foreach (var song in songs)
            {
                if (song.Title.ToLower().Contains(keyword) || song.Artist.ToLower().Contains(keyword))
                {
                    listBoxResults.Items.Add($"{song.Title} - {song.Artist}");
                }
            }

            if (listBoxResults.Items.Count == 0)
            {
                MessageBox.Show($"Nu s-au găsit rezultate pentru '{textBoxSearch.Text}'", "Căutare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
