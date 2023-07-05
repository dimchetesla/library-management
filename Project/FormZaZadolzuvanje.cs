using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class FormZaZadolzuvanje : Form
    {
        MainForm mainForm;
        public FormZaZadolzuvanje(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void UpdateDataGirds()
        {
            BindingSource binding = new BindingSource();
            BindingSource binding1 = new BindingSource();
            binding.DataSource = mainForm.books;
            binding1.DataSource = mainForm.members;
            dataGridView1.DataSource = binding;
            dataGridView2.DataSource = binding1;
        }

        private void FormZaZadolzuvanje_Load(object sender, EventArgs e)
        {
            UpdateDataGirds();
        }

        private void llEvidencija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainForm.Evidencija();
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnPozajmi_Click(object sender, EventArgs e)
        {
            int indxOfBook;
            int indxOfMember;
            if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView2.SelectedRows.Count > 0)
            {
                indxOfBook = dataGridView1.CurrentCell.RowIndex;                 
                indxOfMember = dataGridView2.CurrentCell.RowIndex;
                Book b = mainForm.books[indxOfBook];
                Member mem = mainForm.members[indxOfMember];
                BorrowedBooksToUsers borrowedBooksToUsers = new BorrowedBooksToUsers()
                {
                    Title = b.Title,
                    Author = b.Author,
                    NameAndSurname = mem.NameAndSurname,
                    Address = mem.Address,
                    PhoneNum = mem.PhoneNum,
                    Email = mem.Email,
                    Date = DateTime.UtcNow.ToShortDateString(),
                    Time = DateTime.Now.ToShortTimeString()
                };
                mainForm.bBooksToUsers.Add(borrowedBooksToUsers);
                MessageBox.Show($"Книгата '{borrowedBooksToUsers.Title}' е успешно позајмена на {borrowedBooksToUsers.NameAndSurname}.", "Позајми книга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
                string name = borrowedBooksToUsers.NameAndSurname,title=borrowedBooksToUsers.Title;
                string message = $"Успешно е изнајмена книгата {title} на членот {name}.";
                MessageBox.Show(message);
                */
            }
            else
            {
                MessageBox.Show("Селектирајте ги соодветните книга и член!","Грешка!",MessageBoxButtons.OK,MessageBoxIcon.Error);    
            }
        }

        private void tbSearchBook_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbSearchBook.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            switch (cbFilterBook.SelectedIndex)
            {
                case 0:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[1].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[2].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
            }
        }

        private void tbSearchMember_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbSearchMember.Text;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            switch (cbFilterMember.SelectedIndex)
            {
                case 0:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[2].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[3].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[4].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
            }
        }
    }
}
