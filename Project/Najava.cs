using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    
    public partial class Najava : Form
    {
        public List<Bibliotekar> bibl { get; set; }
        public string bibliotekar;
        public Najava()
        {
            InitializeComponent();
            bibl = new List<Bibliotekar>();
        }

        private void llDodadiNovBibl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbKorisnickoIme.Text != "" && tbLozinka.Text != "")
            {
                tbKorisnickoIme.Clear();
                tbLozinka.Clear();
            }
            AddNewUser addNewUser = new AddNewUser(this);
            addNewUser.ShowDialog();

        }

        private void Najava_Load(object sender, EventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = true;
        }

        private void cbVidlivost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVidlivost.Checked)
            {
                tbLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbLozinka.UseSystemPasswordChar = true;
            }
        }

        private void btnNajava_Click(object sender, EventArgs e)
        {
            if (tbLozinka.Text == "")
            {
                errorProvider1.SetError(tbLozinka, "Полето не смее да биде празно!");
            }
            if (tbKorisnickoIme.Text == "")
            {
                errorProvider1.SetError(tbKorisnickoIme, "Полето не смее да биде празно!");
            }
            if (tbKorisnickoIme.Text != "" && tbLozinka.Text != "")
            {
                string username = tbKorisnickoIme.Text;
                string password = tbLozinka.Text;
                if (tbKorisnickoIme.Text == "" || tbLozinka.Text == "")
                {
                    MessageBox.Show("Имате празно поле!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Bibliotekar b = bibl.FirstOrDefault(u => u.korisnicko_ime == username && u.lozinka == password);
                    if (b != null)
                    {
                        bibliotekar = tbKorisnickoIme.Text;
                        this.Hide();
                        MainForm m = new MainForm(this);
                        m.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Невалидно корисничко име или лозинка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbKorisnickoIme.Text == "")
            {
                errorProvider1.SetError(tbKorisnickoIme, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbKorisnickoIme, null);
            }
        }

        private void tbLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (tbLozinka.Text == "")
            {
                errorProvider1.SetError(tbLozinka, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbLozinka, null);
            }
        }
    }
}
