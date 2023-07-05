namespace Project
{
    partial class Najava
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
            this.cbVidlivost = new System.Windows.Forms.CheckBox();
            this.llDodadiNovBibl = new System.Windows.Forms.LinkLabel();
            this.btnNajava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 58);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Најава";
            // 
            // cbVidlivost
            // 
            this.cbVidlivost.AutoSize = true;
            this.cbVidlivost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVidlivost.Location = new System.Drawing.Point(224, 540);
            this.cbVidlivost.Name = "cbVidlivost";
            this.cbVidlivost.Size = new System.Drawing.Size(96, 20);
            this.cbVidlivost.TabIndex = 20;
            this.cbVidlivost.Text = "Видливост";
            this.cbVidlivost.UseVisualStyleBackColor = true;
            this.cbVidlivost.CheckedChanged += new System.EventHandler(this.cbVidlivost_CheckedChanged);
            // 
            // llDodadiNovBibl
            // 
            this.llDodadiNovBibl.AutoSize = true;
            this.llDodadiNovBibl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDodadiNovBibl.Location = new System.Drawing.Point(288, 648);
            this.llDodadiNovBibl.Name = "llDodadiNovBibl";
            this.llDodadiNovBibl.Size = new System.Drawing.Size(173, 16);
            this.llDodadiNovBibl.TabIndex = 19;
            this.llDodadiNovBibl.TabStop = true;
            this.llDodadiNovBibl.Text = "Додади нов библиотекар";
            this.llDodadiNovBibl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDodadiNovBibl_LinkClicked);
            // 
            // btnNajava
            // 
            this.btnNajava.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNajava.Location = new System.Drawing.Point(315, 597);
            this.btnNajava.Name = "btnNajava";
            this.btnNajava.Size = new System.Drawing.Size(96, 34);
            this.btnNajava.TabIndex = 18;
            this.btnNajava.Text = "Најави се";
            this.btnNajava.UseVisualStyleBackColor = true;
            this.btnNajava.Click += new System.EventHandler(this.btnNajava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Лозинка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Корисничко име";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(224, 508);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(280, 20);
            this.tbLozinka.TabIndex = 15;
            this.tbLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.tbLozinka_Validating);
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(224, 447);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(280, 20);
            this.tbKorisnickoIme.TabIndex = 14;
            this.tbKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbKorisnickoIme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Најава";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.biblioteka_veles_logo;
            this.pictureBox1.Location = new System.Drawing.Point(224, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Najava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 679);
            this.Controls.Add(this.cbVidlivost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.llDodadiNovBibl);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.btnNajava);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLozinka);
            this.MaximizeBox = false;
            this.Name = "Najava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Најава";
            this.Load += new System.EventHandler(this.Najava_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbVidlivost;
        private System.Windows.Forms.LinkLabel llDodadiNovBibl;
        private System.Windows.Forms.Button btnNajava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}