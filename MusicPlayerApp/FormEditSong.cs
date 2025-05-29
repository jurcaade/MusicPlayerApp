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
    public partial class FormEditSong : Form
    {
        public string UpdatedTitle { get; private set; }
        public string UpdatedArtist { get; private set; }

        public FormEditSong(Song song)
        {
            InitializeComponent();
            textBoxEditedTitle.Text = song.Title;
            textBoxEditedArtist.Text = song.Artist;
        }

        private void buttonSalvare_Click(object sender, EventArgs e)
        {
            UpdatedTitle = textBoxEditedTitle.Text.Trim();
            UpdatedArtist = textBoxEditedArtist.Text.Trim();

            //Valiari campuri goale
            if (string.IsNullOrWhiteSpace(UpdatedTitle))
            {
                MessageBox.Show("Titlul nu poate fi gol!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEditedTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(UpdatedArtist))
            {
                MessageBox.Show("Artistul nu poate fi gol!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEditedArtist.Focus();
                return;
            }

            // Validare lungime
            if (UpdatedTitle.Length > 100)
            {
                MessageBox.Show("Titlul nu poate depăși 100 de caractere!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatedArtist.Length > 100)
            {
                MessageBox.Show("Numele artistului nu poate depăși 50 de caractere!", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
