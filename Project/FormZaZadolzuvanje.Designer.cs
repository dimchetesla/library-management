namespace Project
{
    partial class FormZaZadolzuvanje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameAndSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchBook = new System.Windows.Forms.TextBox();
            this.tbSearchMember = new System.Windows.Forms.TextBox();
            this.btnPozajmi = new System.Windows.Forms.Button();
            this.llEvidencija = new System.Windows.Forms.LinkLabel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.cbFilterBook = new System.Windows.Forms.ComboBox();
            this.cbFilterMember = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 58);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(395, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Позајми книга";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 329);
            this.dataGridView1.TabIndex = 13;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Наслов";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количина";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Project.Book);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameAndSurnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.memberBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(497, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(542, 329);
            this.dataGridView2.TabIndex = 14;
            // 
            // nameAndSurnameDataGridViewTextBoxColumn
            // 
            this.nameAndSurnameDataGridViewTextBoxColumn.DataPropertyName = "NameAndSurname";
            this.nameAndSurnameDataGridViewTextBoxColumn.HeaderText = "Име и презиме";
            this.nameAndSurnameDataGridViewTextBoxColumn.Name = "nameAndSurnameDataGridViewTextBoxColumn";
            this.nameAndSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Години";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "Тел. број";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Е-маил";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Project.Member);
            // 
            // tbSearchBook
            // 
            this.tbSearchBook.Location = new System.Drawing.Point(53, 93);
            this.tbSearchBook.Name = "tbSearchBook";
            this.tbSearchBook.Size = new System.Drawing.Size(203, 20);
            this.tbSearchBook.TabIndex = 1;
            this.tbSearchBook.TextChanged += new System.EventHandler(this.tbSearchBook_TextChanged);
            // 
            // tbSearchMember
            // 
            this.tbSearchMember.Location = new System.Drawing.Point(614, 93);
            this.tbSearchMember.Name = "tbSearchMember";
            this.tbSearchMember.Size = new System.Drawing.Size(230, 20);
            this.tbSearchMember.TabIndex = 16;
            this.tbSearchMember.TextChanged += new System.EventHandler(this.tbSearchMember_TextChanged);
            // 
            // btnPozajmi
            // 
            this.btnPozajmi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPozajmi.Location = new System.Drawing.Point(399, 492);
            this.btnPozajmi.Name = "btnPozajmi";
            this.btnPozajmi.Size = new System.Drawing.Size(75, 38);
            this.btnPozajmi.TabIndex = 19;
            this.btnPozajmi.Text = "Позајми";
            this.btnPozajmi.UseVisualStyleBackColor = true;
            this.btnPozajmi.Click += new System.EventHandler(this.btnPozajmi_Click);
            // 
            // llEvidencija
            // 
            this.llEvidencija.AutoSize = true;
            this.llEvidencija.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llEvidencija.Location = new System.Drawing.Point(883, 502);
            this.llEvidencija.Name = "llEvidencija";
            this.llEvidencija.Size = new System.Drawing.Size(156, 19);
            this.llEvidencija.TabIndex = 20;
            this.llEvidencija.TabStop = true;
            this.llEvidencija.Text = "Кон евиденција >>";
            this.llEvidencija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEvidencija_LinkClicked);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(497, 492);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 38);
            this.btnOtkazi.TabIndex = 21;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // cbFilterBook
            // 
            this.cbFilterBook.FormattingEnabled = true;
            this.cbFilterBook.Items.AddRange(new object[] {
            "Наслов",
            "Автор",
            "Жанр"});
            this.cbFilterBook.Location = new System.Drawing.Point(276, 93);
            this.cbFilterBook.Name = "cbFilterBook";
            this.cbFilterBook.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBook.TabIndex = 22;
            // 
            // cbFilterMember
            // 
            this.cbFilterMember.FormattingEnabled = true;
            this.cbFilterMember.Items.AddRange(new object[] {
            "Име и презиме",
            "Адреса",
            "Тел. број",
            "Е-маил"});
            this.cbFilterMember.Location = new System.Drawing.Point(878, 92);
            this.cbFilterMember.Name = "cbFilterMember";
            this.cbFilterMember.Size = new System.Drawing.Size(121, 21);
            this.cbFilterMember.TabIndex = 23;
            // 
            // FormZaZadolzuvanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 542);
            this.Controls.Add(this.cbFilterMember);
            this.Controls.Add(this.cbFilterBook);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.llEvidencija);
            this.Controls.Add(this.btnPozajmi);
            this.Controls.Add(this.tbSearchMember);
            this.Controls.Add(this.tbSearchBook);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FormZaZadolzuvanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Позајми книга";
            this.Load += new System.EventHandler(this.FormZaZadolzuvanje_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAndSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.TextBox tbSearchBook;
        private System.Windows.Forms.TextBox tbSearchMember;
        private System.Windows.Forms.Button btnPozajmi;
        private System.Windows.Forms.LinkLabel llEvidencija;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ComboBox cbFilterBook;
        private System.Windows.Forms.ComboBox cbFilterMember;
    }
}