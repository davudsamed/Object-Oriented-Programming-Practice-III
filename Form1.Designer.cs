namespace _1D_B171210007_NDP_Odev3
{
    partial class Form1
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
            this.DuyuruLabel = new System.Windows.Forms.Label();
            this.BaslıkLabel = new System.Windows.Forms.Label();
            this.SonucText = new System.Windows.Forms.TextBox();
            this.HesaplaButon = new System.Windows.Forms.Button();
            this.HesapText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DuyuruLabel
            // 
            this.DuyuruLabel.AutoSize = true;
            this.DuyuruLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DuyuruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuyuruLabel.Location = new System.Drawing.Point(287, 163);
            this.DuyuruLabel.Name = "DuyuruLabel";
            this.DuyuruLabel.Size = new System.Drawing.Size(225, 20);
            this.DuyuruLabel.TabIndex = 10;
            this.DuyuruLabel.Text = "Hesabı Yapılacak İşlemi Giriniz";
            // 
            // BaslıkLabel
            // 
            this.BaslıkLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.BaslıkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BaslıkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(162)));
            this.BaslıkLabel.Location = new System.Drawing.Point(97, 50);
            this.BaslıkLabel.Name = "BaslıkLabel";
            this.BaslıkLabel.Size = new System.Drawing.Size(607, 54);
            this.BaslıkLabel.TabIndex = 9;
            this.BaslıkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SonucText
            // 
            this.SonucText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SonucText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucText.Location = new System.Drawing.Point(322, 378);
            this.SonucText.Name = "SonucText";
            this.SonucText.Size = new System.Drawing.Size(164, 23);
            this.SonucText.TabIndex = 8;
            this.SonucText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HesaplaButon
            // 
            this.HesaplaButon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HesaplaButon.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesaplaButon.Location = new System.Drawing.Point(291, 285);
            this.HesaplaButon.Name = "HesaplaButon";
            this.HesaplaButon.Size = new System.Drawing.Size(219, 57);
            this.HesaplaButon.TabIndex = 7;
            this.HesaplaButon.UseVisualStyleBackColor = false;
            this.HesaplaButon.Click += new System.EventHandler(this.HesaplaButon_Click);
            // 
            // HesapText
            // 
            this.HesapText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HesapText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HesapText.Location = new System.Drawing.Point(291, 218);
            this.HesapText.Name = "HesapText";
            this.HesapText.ShortcutsEnabled = false;
            this.HesapText.Size = new System.Drawing.Size(219, 23);
            this.HesapText.TabIndex = 6;
            this.HesapText.Click += new System.EventHandler(this.HesapText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DuyuruLabel);
            this.Controls.Add(this.BaslıkLabel);
            this.Controls.Add(this.SonucText);
            this.Controls.Add(this.HesaplaButon);
            this.Controls.Add(this.HesapText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DuyuruLabel;
        private System.Windows.Forms.Label BaslıkLabel;
        private System.Windows.Forms.TextBox SonucText;
        private System.Windows.Forms.Button HesaplaButon;
        private System.Windows.Forms.TextBox HesapText;
    }
}

