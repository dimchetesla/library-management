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
    public partial class FormZaEvidencija : Form
    {
        MainForm mainForm;
        public FormZaEvidencija(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        public FormZaEvidencija()
        {
            InitializeComponent();
        }
        public void UpdateDataGird()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = mainForm.bBooksToUsers;
            dataGridView1.DataSource = binding;
        }

        private void FormZaEvidencija_Load(object sender, EventArgs e)
        {
            UpdateDataGird();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                switch(cbFilter.SelectedIndex)
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
