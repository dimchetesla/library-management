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
    public partial class MainForm : Form
    {
        public List<Book> books;
        public List<Member> members;
        public List<BorrowedBooksToUsers> bBooksToUsers;
        Najava n;
        public MainForm(Najava n)
        {
            InitializeComponent();
            books = new List<Book>();
            members = new List<Member>();
            bBooksToUsers = new List<BorrowedBooksToUsers>();
            this.n = n;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDatum.Text = DateTime.UtcNow.ToLongDateString();
            lblUser.Text = n.bibliotekar;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCas.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnKnigi_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnKnigi,0, btnKnigi.Height);
        }

        private void btnIzlez_Click(object sender, EventArgs e)
        {
            this.Close();
            Najava n = new Najava();
            n.Show();
        }

        private void задолжиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZaZadolzuvanje f = new FormZaZadolzuvanje(this);
            f.ShowDialog();
        }

        private void вратиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZaVrakjanje f = new FormZaVrakjanje(this);
            f.ShowDialog();
        }

        private void додадиКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZaDodavanje f = new FormZaDodavanje(this);
            f.ShowDialog();
        }
        
        public void Evidencija()
        {
            FormZaEvidencija evidencija = new FormZaEvidencija(this);
            evidencija.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZaEvidencija evidencija = new FormZaEvidencija(this);
            evidencija.ShowDialog();
        }

        private void btnZacleneti_Click(object sender, EventArgs e)
        {
            FormZaDodavanjeMember f = new FormZaDodavanjeMember(this);
            f.ShowDialog();
        }
    }
}
