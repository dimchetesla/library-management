namespace Project
{
    partial class AddNewUser
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
            this.btnNajava = new System.Windows.Forms.Button();
            this.cbVidlivost = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImeIPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPotvrdiLozinka = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 58);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додади библиотекар";
            // 
            // btnNajava
            // 
            this.btnNajava.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNajava.Location = new System.Drawing.Point(12, 404);
            this.btnNajava.Name = "btnNajava";
            this.btnNajava.Size = new System.Drawing.Size(98, 34);
            this.btnNajava.TabIndex = 6;
            this.btnNajava.Text = "Додади";
            this.btnNajava.UseVisualStyleBackColor = true;
            this.btnNajava.Click += new System.EventHandler(this.btnNajava_Click);
            // 
            // cbVidlivost
            // 
            this.cbVidlivost.AutoSize = true;
            this.cbVidlivost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVidlivost.Location = new System.Drawing.Point(12, 297);
            this.cbVidlivost.Name = "cbVidlivost";
            this.cbVidlivost.Size = new System.Drawing.Size(96, 20);
            this.cbVidlivost.TabIndex = 5;
            this.cbVidlivost.Text = "Видливост";
            this.cbVidlivost.UseVisualStyleBackColor = true;
            this.cbVidlivost.CheckedChanged += new System.EventHandler(this.cbVidlivost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Лозинка";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(12, 207);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(226, 20);
            this.tbLozinka.TabIndex = 3;
            this.tbLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.tbLozinka_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Корисничко име";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(12, 149);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(226, 20);
            this.tbKorisnickoIme.TabIndex = 2;
            this.tbKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbKorisnickoIme_Validating);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(140, 404);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(98, 34);
            this.btnOtkazi.TabIndex = 7;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Име и презиме";
            // 
            // tbImeIPrezime
            // 
            this.tbImeIPrezime.Location = new System.Drawing.Point(12, 95);
            this.tbImeIPrezime.Name = "tbImeIPrezime";
            this.tbImeIPrezime.Size = new System.Drawing.Size(226, 20);
            this.tbImeIPrezime.TabIndex = 1;
            this.tbImeIPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbImeIPrezime_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Потврди лозинка";
            // 
            // tbPotvrdiLozinka
            // 
            this.tbPotvrdiLozinka.Location = new System.Drawing.Point(12, 262);
            this.tbPotvrdiLozinka.Name = "tbPotvrdiLozinka";
            this.tbPotvrdiLozinka.Size = new System.Drawing.Size(226, 20);
            this.tbPotvrdiLozinka.TabIndex = 4;
            this.tbPotvrdiLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.tbPotvrdiLozinka_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPotvrdiLozinka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbImeIPrezime);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNajava);
            this.Controls.Add(this.cbVidlivost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.panel2);
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додади нов корисник";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNajava;
        private System.Windows.Forms.CheckBox cbVidlivost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImeIPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPotvrdiLozinka;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}