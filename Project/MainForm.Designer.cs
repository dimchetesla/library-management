namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBibl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblCas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKnigi = new System.Windows.Forms.Button();
            this.lblBibliotekar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzlez = new System.Windows.Forms.Button();
            this.btnUpatstvo = new System.Windows.Forms.Button();
            this.btnZacleneti = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.задолжиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вратиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додадиКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBibl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.lblCas);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblBibl
            // 
            this.lblBibl.AutoSize = true;
            this.lblBibl.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibl.Location = new System.Drawing.Point(360, 3);
            this.lblBibl.Name = "lblBibl";
            this.lblBibl.Size = new System.Drawing.Size(671, 78);
            this.lblBibl.TabIndex = 3;
            this.lblBibl.Text = "ГРАДСКА БИБЛИОТЕКА";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.buecher_coloured;
            this.pictureBox1.Location = new System.Drawing.Point(268, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(12, 44);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(70, 26);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum";
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCas.Location = new System.Drawing.Point(12, 18);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(41, 26);
            this.lblCas.TabIndex = 0;
            this.lblCas.Text = "Cas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.btnKnigi);
            this.panel2.Controls.Add(this.lblBibliotekar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnIzlez);
            this.panel2.Controls.Add(this.btnUpatstvo);
            this.panel2.Controls.Add(this.btnZacleneti);
            this.panel2.Location = new System.Drawing.Point(1, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnKnigi
            // 
            this.btnKnigi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKnigi.Location = new System.Drawing.Point(373, 9);
            this.btnKnigi.Name = "btnKnigi";
            this.btnKnigi.Size = new System.Drawing.Size(93, 38);
            this.btnKnigi.TabIndex = 1;
            this.btnKnigi.Text = "Книги";
            this.btnKnigi.UseVisualStyleBackColor = true;
            this.btnKnigi.Click += new System.EventHandler(this.btnKnigi_Click);
            // 
            // lblBibliotekar
            // 
            this.lblBibliotekar.AutoSize = true;
            this.lblBibliotekar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotekar.ForeColor = System.Drawing.Color.White;
            this.lblBibliotekar.Location = new System.Drawing.Point(11, 12);
            this.lblBibliotekar.Name = "lblBibliotekar";
            this.lblBibliotekar.Size = new System.Drawing.Size(161, 29);
            this.lblBibliotekar.TabIndex = 4;
            this.lblBibliotekar.Text = "Библиотекар: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Евиденција";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzlez
            // 
            this.btnIzlez.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlez.Location = new System.Drawing.Point(931, 9);
            this.btnIzlez.Name = "btnIzlez";
            this.btnIzlez.Size = new System.Drawing.Size(93, 38);
            this.btnIzlez.TabIndex = 5;
            this.btnIzlez.Text = "Одјава";
            this.btnIzlez.UseVisualStyleBackColor = true;
            this.btnIzlez.Click += new System.EventHandler(this.btnIzlez_Click);
            // 
            // btnUpatstvo
            // 
            this.btnUpatstvo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpatstvo.Location = new System.Drawing.Point(721, 9);
            this.btnUpatstvo.Name = "btnUpatstvo";
            this.btnUpatstvo.Size = new System.Drawing.Size(93, 38);
            this.btnUpatstvo.TabIndex = 4;
            this.btnUpatstvo.Text = "Упатство";
            this.btnUpatstvo.UseVisualStyleBackColor = true;
            // 
            // btnZacleneti
            // 
            this.btnZacleneti.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZacleneti.Location = new System.Drawing.Point(489, 9);
            this.btnZacleneti.Name = "btnZacleneti";
            this.btnZacleneti.Size = new System.Drawing.Size(93, 38);
            this.btnZacleneti.TabIndex = 2;
            this.btnZacleneti.Text = "Зачленети";
            this.btnZacleneti.UseVisualStyleBackColor = true;
            this.btnZacleneti.Click += new System.EventHandler(this.btnZacleneti_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(1, 763);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 58);
            this.panel3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задолжиToolStripMenuItem,
            this.вратиToolStripMenuItem,
            this.додадиКнигаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 75);
            // 
            // задолжиToolStripMenuItem
            // 
            this.задолжиToolStripMenuItem.Name = "задолжиToolStripMenuItem";
            this.задолжиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.задолжиToolStripMenuItem.Text = "Позајми";
            this.задолжиToolStripMenuItem.Click += new System.EventHandler(this.задолжиToolStripMenuItem_Click);
            // 
            // вратиToolStripMenuItem
            // 
            this.вратиToolStripMenuItem.Name = "вратиToolStripMenuItem";
            this.вратиToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.вратиToolStripMenuItem.Text = "Врати";
            this.вратиToolStripMenuItem.Click += new System.EventHandler(this.вратиToolStripMenuItem_Click);
            // 
            // додадиКнигаToolStripMenuItem
            // 
            this.додадиКнигаToolStripMenuItem.Name = "додадиКнигаToolStripMenuItem";
            this.додадиКнигаToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.додадиКнигаToolStripMenuItem.Text = "Листа";
            this.додадиКнигаToolStripMenuItem.Click += new System.EventHandler(this.додадиКнигаToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project.Properties.Resources.biblioteka_veles_logo;
            this.pictureBox2.Location = new System.Drawing.Point(415, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 560);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(162, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 29);
            this.lblUser.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 841);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Локална градска библиотека - Велес";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIzlez;
        private System.Windows.Forms.Button btnUpatstvo;
        private System.Windows.Forms.Button btnZacleneti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBibl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBibliotekar;
        private System.Windows.Forms.Button btnKnigi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задолжиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вратиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додадиКнигаToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
    }
}

