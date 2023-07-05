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
    public partial class AddNewUser : Form
    {
        Najava login;
        public Bibliotekar b;
        public AddNewUser(Najava l)
        {
            InitializeComponent();
            this.login = l;
        }

        private void btnNajava_Click(object sender, EventArgs e)
        {
            if (tbImeIPrezime.Text == "")
            {
                errorProvider1.SetError(tbImeIPrezime, "Полето не смее да биде празно!");
            }
            if (tbKorisnickoIme.Text == "")
            {
                errorProvider1.SetError(tbKorisnickoIme, "Полето не смее да биде празно!");
            }
            if (tbLozinka.Text == "")
            {
                errorProvider1.SetError(tbLozinka, "Полето не смее да биде празно!");
            }
            if (tbPotvrdiLozinka.Text == "")
            {
                errorProvider1.SetError(tbPotvrdiLozinka, "Полето не смее да биде празно!");
            }
            


            if (tbImeIPrezime.Text != "" && tbKorisnickoIme.Text != "" && tbLozinka.Text != "" && tbPotvrdiLozinka.Text != "")
            {
                Bibliotekar b = new Bibliotekar()
                {
                    ime_prezime = tbImeIPrezime.Text,
                    korisnicko_ime = tbKorisnickoIme.Text,
                    lozinka = tbLozinka.Text
                };
                string usernameToCheck = tbKorisnickoIme.Text;
                bool userExists = false;
                if (login.bibl.Count > 0)
                {
                    foreach (Bibliotekar bib in login.bibl)
                    {
                        if (bib.korisnicko_ime.Equals(usernameToCheck))
                        {
                            userExists = true;
                            break;
                        }
                    }
                    if (userExists)
                    {
                        MessageBox.Show("Корисникот веќе постои!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (userExists == false)
                    {
                        if (tbPotvrdiLozinka.Text != tbLozinka.Text)
                        {
                            MessageBox.Show("Лозинките не се совпаѓаат!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            login.bibl.Add(b);
                            this.Close();
                        }
                    }
                }                
                else
                {
                    if (tbPotvrdiLozinka.Text != tbLozinka.Text)
                    {
                        MessageBox.Show("Лозинките не се совпаѓаат!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        login.bibl.Add(b);
                        this.Close();
                    }
                }               

            }
           
        }


        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            tbLozinka.UseSystemPasswordChar = true;
            tbPotvrdiLozinka.UseSystemPasswordChar = true;
        }

        private void cbVidlivost_CheckedChanged(object sender, EventArgs e)
        {
            if(cbVidlivost.Checked)
            {
                tbLozinka.UseSystemPasswordChar = false;
                tbPotvrdiLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbLozinka.UseSystemPasswordChar = true;
                tbPotvrdiLozinka.UseSystemPasswordChar = true;
            }
        }

        private void tbImeIPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbImeIPrezime.Text == "")
            {
                errorProvider1.SetError(tbImeIPrezime, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbImeIPrezime, null);
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

        private void tbPotvrdiLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (tbPotvrdiLozinka.Text == "")
            {
                errorProvider1.SetError(tbPotvrdiLozinka, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbPotvrdiLozinka, null);
            }
        }
    }
}
