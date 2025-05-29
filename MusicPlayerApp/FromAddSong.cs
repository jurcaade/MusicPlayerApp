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
    public partial class FormAddSong : Form
    {
        public string SongTitle { get; private set; }
        public string SongArtist { get; private set; }
        public string SongGenre { get; private set; }

        public FormAddSong()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPiesa.Text) || string.IsNullOrWhiteSpace(textBoxArtist.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!");
                return;
            }

            SongTitle = textBoxPiesa.Text.Trim();
            SongArtist = textBoxArtist.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPiesa.Text) || string.IsNullOrWhiteSpace(textBoxArtist.Text))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!");
                return;
            }

            SongTitle = textBoxPiesa.Text.Trim();
            SongArtist = textBoxArtist.Text.Trim();

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
