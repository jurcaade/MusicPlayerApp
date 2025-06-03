using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace MusicPlayerApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            string username = textBoxUtilizator.Text.Trim();
            string password = textBoxParola.Text.Trim();

            // Verifica daca utilizatorul sau parola sunt goale
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Introdu numele de utilizator și parola.","Informare",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            // Daca login-ul este valid, ascunde formul curent si deschide formul principala
            if (CheckLogin(username, password))
            {
                this.Hide();
                FormMain mainForm = new FormMain();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Mesaj de eroare daca login-ul esueaza
                MessageBox.Show($"Nume de utilizator sau parolă greșită!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        
       // Functie care verifica daca username si parola sunt valide
        private bool CheckLogin(string username, string password)
        {
            string filePath = "users.xml"; // Calea catre fisierul XML cu utilizatori

            // Verifica daca fisierul XML exista
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Fișierul users.xml nu a fost găsit!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            try
            {
                // Incarca fisierul XML si verifica daca exista un utilizator cu datele introduse
                XDocument doc = XDocument.Load(filePath);

                bool isValidUser = doc.Descendants("User").Any(u => u.Element("Username").Value == username && u.Element("Password").Value == password);
                return isValidUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fișierului XML: {ex.Message}","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
