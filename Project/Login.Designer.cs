namespace Project
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNajava = new System.Windows.Forms.Button();
            this.llDodadiNovBibl = new System.Windows.Forms.LinkLabel();
            this.cbVidlivost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 58);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.biblioteka_veles_logo;
            this.pictureBox1.Location = new System.Drawing.Point(560, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Најава";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(560, 430);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(280, 20);
            this.tbKorisnickoIme.TabIndex = 5;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(560, 491);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(280, 20);
            this.tbLozinka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Корисничко име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Лозинка";
            // 
            // btnNajava
            // 
            this.btnNajava.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNajava.Location = new System.Drawing.Point(651, 580);
            this.btnNajava.Name = "btnNajava";
            this.btnNajava.Size = new System.Drawing.Size(96, 34);
            this.btnNajava.TabIndex = 9;
            this.btnNajava.Text = "Најави се";
            this.btnNajava.UseVisualStyleBackColor = true;
            // 
            // llDodadiNovBibl
            // 
            this.llDodadiNovBibl.AutoSize = true;
            this.llDodadiNovBibl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDodadiNovBibl.Location = new System.Drawing.Point(624, 631);
            this.llDodadiNovBibl.Name = "llDodadiNovBibl";
            this.llDodadiNovBibl.Size = new System.Drawing.Size(173, 16);
            this.llDodadiNovBibl.TabIndex = 10;
            this.llDodadiNovBibl.TabStop = true;
            this.llDodadiNovBibl.Text = "Додади нов библиотекар";
            // 
            // cbVidlivost
            // 
            this.cbVidlivost.AutoSize = true;
            this.cbVidlivost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVidlivost.Location = new System.Drawing.Point(560, 523);
            this.cbVidlivost.Name = "cbVidlivost";
            this.cbVidlivost.Size = new System.Drawing.Size(96, 20);
            this.cbVidlivost.TabIndex = 11;
            this.cbVidlivost.Text = "Видливост";
            this.cbVidlivost.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbVidlivost);
            this.Controls.Add(this.llDodadiNovBibl);
            this.Controls.Add(this.btnNajava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1400, 705);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNajava;
        private System.Windows.Forms.LinkLabel llDodadiNovBibl;
        private System.Windows.Forms.CheckBox cbVidlivost;
    }
}
