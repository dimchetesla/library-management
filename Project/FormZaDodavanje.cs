using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class FormZaDodavanje : Form
    {
        MainForm mainForm;
        public FormZaDodavanje(MainForm f)
        {
            InitializeComponent();
            this.mainForm = f;
        }

        public void UpdateDataGird()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = mainForm.books;
            dataGridView1.DataSource = binding;
        }
       
        private void FormZaDodavanje_Load(object sender, EventArgs e)
        {
            UpdateDataGird();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                errorProvider1.SetError(tbTitle, "Полето не смее да биде празно!");
            }
            if (tbAuthor.Text == "")
            {
                errorProvider1.SetError(tbAuthor, "Полето не смее да биде празно!");
            }
            if (tbGenre.Text == "")
            {
                errorProvider1.SetError(tbGenre, "Полето не смее да биде празно!");
            }
            if (tbTitle.Text != "" && tbAuthor.Text != "" && tbGenre.Text != "")
            {
                //KODOV RABOTI TUKA ZA KNIGI A ZA USERS NE RABOTI
                //treba da se implementira errorprovider
                Book b = new Book()
                {
                    Title = tbTitle.Text,
                    Author = tbAuthor.Text,
                    Genre = tbGenre.Text,
                    Quantity = System.Convert.ToInt32(nudQuantity.Value)
                };
                //Treba da se implementira momentalno dodavanje vo datagrid
                string titleToCheck = tbTitle.Text;
                bool bookExists = false;
                if (mainForm.books.Count > 0)
                {
                    foreach (Book kniga in mainForm.books)
                    {
                        if (kniga.Title.Equals(titleToCheck))
                        {
                            bookExists = true;
                            break;
                        }
                    }
                    if (bookExists)
                    {
                        MessageBox.Show("Книгата веќе постои!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (bookExists == false)
                    {
                        mainForm.books.Add(b);
                    }
                }
                else
                {
                    mainForm.books.Add(b);
                }
                UpdateDataGird();
                tbTitle.Clear();
                tbAuthor.Clear();
                tbGenre.Clear();
                nudQuantity.Value = 1;
            }
            
        }

        private void btnIzbris_Click(object sender, EventArgs e)
        {
            
            int indx;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Дали сакате да ја избришете книгата?","Избриши книга",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indx = dataGridView1.CurrentCell.RowIndex;
                    mainForm.books.RemoveAt(indx);
                }
            }
            else
            {
                MessageBox.Show("Немате избрано книга!", "Избриши книга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if(tbTitle.Text == "")
            {
                errorProvider1.SetError(tbTitle, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbTitle, null);
            }
        }

        private void tbAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (tbAuthor.Text == "")
            {
                errorProvider1.SetError(tbAuthor, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbAuthor, null);
            }
        }

        private void tbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (tbGenre.Text == "")
            {
                errorProvider1.SetError(tbGenre, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbGenre, null);
            }
        }
    }
}
