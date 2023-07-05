using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : UserControl
    {
        public List<Bibliotekar> bibl { get; set; }

        public Login()
        {
            InitializeComponent();
            bibl = new List<Bibliotekar>();

        }

        private void llDodadiNovKorisnik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbKorisnickoIme.Text != "" && tbLozinka.Text != "")
            {
                tbKorisnickoIme.Clear();
                tbLozinka.Clear();
            }
            

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
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Невалидно корисничко име или лозинка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
