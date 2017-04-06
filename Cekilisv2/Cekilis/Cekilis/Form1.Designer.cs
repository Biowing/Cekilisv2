namespace Cekilis
{
    partial class CekilisProgramı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CekilisProgramı));
            this.kisiler = new System.Windows.Forms.ListBox();
            this.isimler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Onayla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kazananlar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kisisayisi = new System.Windows.Forms.TextBox();
            this.sonuc = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kisiler
            // 
            this.kisiler.BackColor = System.Drawing.Color.DarkRed;
            this.kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiler.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.kisiler.FormattingEnabled = true;
            this.kisiler.ItemHeight = 18;
            this.kisiler.Location = new System.Drawing.Point(12, 86);
            this.kisiler.Name = "kisiler";
            this.kisiler.Size = new System.Drawing.Size(202, 184);
            this.kisiler.TabIndex = 0;
            // 
            // isimler
            // 
            this.isimler.Location = new System.Drawing.Point(370, 86);
            this.isimler.Name = "isimler";
            this.isimler.Size = new System.Drawing.Size(100, 20);
            this.isimler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(286, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kişiler:";
            // 
            // Onayla
            // 
            this.Onayla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Onayla.Location = new System.Drawing.Point(380, 137);
            this.Onayla.Name = "Onayla";
            this.Onayla.Size = new System.Drawing.Size(75, 23);
            this.Onayla.TabIndex = 3;
            this.Onayla.Text = "Onayla";
            this.Onayla.UseVisualStyleBackColor = false;
            this.Onayla.Click += new System.EventHandler(this.Onayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kişiler:";
            // 
            // kazananlar
            // 
            this.kazananlar.BackColor = System.Drawing.Color.Maroon;
            this.kazananlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kazananlar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.kazananlar.FormattingEnabled = true;
            this.kazananlar.ItemHeight = 18;
            this.kazananlar.Location = new System.Drawing.Point(583, 86);
            this.kazananlar.Name = "kazananlar";
            this.kazananlar.Size = new System.Drawing.Size(202, 184);
            this.kazananlar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(336, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaç kişi seçilecek ?";
            // 
            // kisisayisi
            // 
            this.kisisayisi.Location = new System.Drawing.Point(404, 223);
            this.kisisayisi.Name = "kisisayisi";
            this.kisisayisi.Size = new System.Drawing.Size(30, 20);
            this.kisisayisi.TabIndex = 8;
            this.kisisayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sonuc.Location = new System.Drawing.Point(380, 261);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(75, 24);
            this.sonuc.TabIndex = 9;
            this.sonuc.Text = "Sonuçlar";
            this.sonuc.UseVisualStyleBackColor = false;
            this.sonuc.Click += new System.EventHandler(this.sonuc_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.White;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.ForeColor = System.Drawing.Color.Black;
            this.sil.Location = new System.Drawing.Point(158, 276);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(56, 22);
            this.sil.TabIndex = 10;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(710, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CekilisProgramı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(797, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.kisisayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kazananlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Onayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimler);
            this.Controls.Add(this.kisiler);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CekilisProgramı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CekilisProgramı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kisiler;
        private System.Windows.Forms.TextBox isimler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Onayla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox kazananlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kisisayisi;
        private System.Windows.Forms.Button sonuc;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button button1;
    }
}

