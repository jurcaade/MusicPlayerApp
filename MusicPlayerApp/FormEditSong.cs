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

            if (string.IsNullOrWhiteSpace(UpdatedTitle) || string.IsNullOrWhiteSpace(UpdatedArtist))
            {
                MessageBox.Show("Completează toate câmpurile.");
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
