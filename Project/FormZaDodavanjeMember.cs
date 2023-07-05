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
    public partial class FormZaDodavanjeMember : Form
    {
        MainForm mainForm;
        public FormZaDodavanjeMember(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        public void UpdateDataGird()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = mainForm.members;
            dataGridView1.DataSource = binding;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if(tbNameAndSurname.Text =="")
            {
                errorProvider1.SetError(tbNameAndSurname, "Полето не смее да биде празно!");
            }
            if (tbAddress.Text == "")
            {
                errorProvider1.SetError(tbAddress, "Полето не смее да биде празно!");
            }
            if (mtbPhone.Text == "")
            {
                errorProvider1.SetError(mtbPhone, "Полето не смее да биде празно!");
            }
            if (tbEmail.Text == "")
            {
                errorProvider1.SetError(tbEmail, "Полето не смее да биде празно!");
            }
            if (tbNameAndSurname.Text != "" && tbAddress.Text != "" && mtbPhone.Text != "" && tbEmail.Text != "")
            {
                //KODOV RABOTI TUKA ZA KNIGI A ZA USERS NE RABOTI
                //treba da se implementira errorprovider
                Member m = new Member()
                {
                    NameAndSurname = tbNameAndSurname.Text,
                    Address = tbAddress.Text,
                    Age = System.Convert.ToInt32(nudAge.Value),
                    PhoneNum = mtbPhone.Text,
                    Email = tbEmail.Text
                };
                //Treba da se implementira momentalno dodavanje vo datagrid
                mainForm.members.Add(m);
                UpdateDataGird();
                tbNameAndSurname.Clear();
                tbAddress.Clear();
                tbEmail.Clear();
                mtbPhone.Clear();
                nudAge.Value = 1;
            }
        }

        private void btnIzbris_Click(object sender, EventArgs e)
        {
            int indx;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Дали сакате да го избришете членот?", "Избриши член", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indx = dataGridView1.CurrentCell.RowIndex;
                    mainForm.members.RemoveAt(indx);
                }
            }
            if(this.dataGridView1.SelectedRows.Count == 0 && dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Селектирајте член за да го избришете!", "Избриши член", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateDataGird();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                case 3:
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
            }
        }

        private void FormZaDodavanjeMember_Load(object sender, EventArgs e)
        {
            UpdateDataGird();
        }

        private void tbNameAndSurname_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameAndSurname.Text == "")
            {
                errorProvider1.SetError(tbNameAndSurname, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbNameAndSurname, null);
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddress.Text == "")
            {
                errorProvider1.SetError(tbAddress, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbAddress, null);
            }
        }

        private void mtbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (mtbPhone.Text == "")
            {
                errorProvider1.SetError(mtbPhone, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(mtbPhone, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                errorProvider1.SetError(tbEmail, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            }
        }
    }
}
