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
    public partial class FormZaVrakjanje : Form
    {
        MainForm mainForm;
        public FormZaVrakjanje(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        public void UpdateDataGird()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = mainForm.bBooksToUsers;
            dataGridView1.DataSource = binding;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnIzbris_Click(object sender, EventArgs e)
        {
            int indx,indxOfBorrowedBook;
            string name, title;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                indxOfBorrowedBook = dataGridView1.CurrentCell.RowIndex;
                BorrowedBooksToUsers b = mainForm.bBooksToUsers[indxOfBorrowedBook];
                name = b.NameAndSurname; 
                title = b.Title;
                if (MessageBox.Show($"Дали сакате да ја вратите книгата '{title}' позајмена од {name}?", "Врати книга", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indx = dataGridView1.CurrentCell.RowIndex;
                    mainForm.bBooksToUsers.RemoveAt(indx);
                    MessageBox.Show("Книгата е успешно вратена.","Врати книга",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UpdateDataGird();
        }

        private void FormZaVrakjanje_Load(object sender, EventArgs e)
        {
            UpdateDataGird();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            switch (cbFilter.SelectedIndex)
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
                case 3:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
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
                case 4:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
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
                case 5:
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Selected = false;
                            if (row.Cells[5].Value.ToString().Equals(searchValue))
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
