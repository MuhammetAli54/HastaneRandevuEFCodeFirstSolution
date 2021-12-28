
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormDoktor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListele = new System.Windows.Forms.TabPage();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.tabPageDrEkle = new System.Windows.Forms.TabPage();
            this.maskedTextBoxDrTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDrBranslar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrEkle = new System.Windows.Forms.Button();
            this.txtDrEmail = new System.Windows.Forms.TextBox();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrTc = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.tabPageDrEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListele);
            this.tabControl1.Controls.Add(this.tabPageDrEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListele
            // 
            this.tabPageListele.Controls.Add(this.dataGridViewDoktor);
            this.tabPageListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageListele.Name = "tabPageListele";
            this.tabPageListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListele.Size = new System.Drawing.Size(1035, 610);
            this.tabPageListele.TabIndex = 0;
            this.tabPageListele.Text = "Dr Listesi";
            this.tabPageListele.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AllowUserToAddRows = false;
            this.dataGridViewDoktor.AllowUserToDeleteRows = false;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(14, 27);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.ReadOnly = true;
            this.dataGridViewDoktor.RowHeadersWidth = 51;
            this.dataGridViewDoktor.RowTemplate.Height = 24;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(1015, 577);
            this.dataGridViewDoktor.TabIndex = 0;
            // 
            // tabPageDrEkle
            // 
            this.tabPageDrEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageDrEkle.Controls.Add(this.maskedTextBoxDrTel);
            this.tabPageDrEkle.Controls.Add(this.comboBoxDrBranslar);
            this.tabPageDrEkle.Controls.Add(this.label6);
            this.tabPageDrEkle.Controls.Add(this.btnDrEkle);
            this.tabPageDrEkle.Controls.Add(this.txtDrEmail);
            this.tabPageDrEkle.Controls.Add(this.txtDrSoyad);
            this.tabPageDrEkle.Controls.Add(this.txtDrTc);
            this.tabPageDrEkle.Controls.Add(this.txtDrAd);
            this.tabPageDrEkle.Controls.Add(this.label5);
            this.tabPageDrEkle.Controls.Add(this.label4);
            this.tabPageDrEkle.Controls.Add(this.label3);
            this.tabPageDrEkle.Controls.Add(this.label2);
            this.tabPageDrEkle.Controls.Add(this.label1);
            this.tabPageDrEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrEkle.Name = "tabPageDrEkle";
            this.tabPageDrEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrEkle.Size = new System.Drawing.Size(781, 503);
            this.tabPageDrEkle.TabIndex = 1;
            this.tabPageDrEkle.Text = "Dr Ekle";
            // 
            // maskedTextBoxDrTel
            // 
            this.maskedTextBoxDrTel.Location = new System.Drawing.Point(173, 258);
            this.maskedTextBoxDrTel.Name = "maskedTextBoxDrTel";
            this.maskedTextBoxDrTel.Size = new System.Drawing.Size(535, 22);
            this.maskedTextBoxDrTel.TabIndex = 13;
            // 
            // comboBoxDrBranslar
            // 
            this.comboBoxDrBranslar.FormattingEnabled = true;
            this.comboBoxDrBranslar.Location = new System.Drawing.Point(173, 203);
            this.comboBoxDrBranslar.Name = "comboBoxDrBranslar";
            this.comboBoxDrBranslar.Size = new System.Drawing.Size(535, 24);
            this.comboBoxDrBranslar.TabIndex = 12;
            this.comboBoxDrBranslar.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrBranslar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "BRANŞ:";
            // 
            // btnDrEkle
            // 
            this.btnDrEkle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDrEkle.Location = new System.Drawing.Point(173, 360);
            this.btnDrEkle.Name = "btnDrEkle";
            this.btnDrEkle.Size = new System.Drawing.Size(185, 48);
            this.btnDrEkle.TabIndex = 10;
            this.btnDrEkle.Text = "YENİ DOKTOR EKLE";
            this.btnDrEkle.UseVisualStyleBackColor = false;
            this.btnDrEkle.Click += new System.EventHandler(this.btnDrEkle_Click);
            // 
            // txtDrEmail
            // 
            this.txtDrEmail.Location = new System.Drawing.Point(173, 309);
            this.txtDrEmail.Name = "txtDrEmail";
            this.txtDrEmail.Size = new System.Drawing.Size(535, 22);
            this.txtDrEmail.TabIndex = 9;
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(173, 156);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(535, 22);
            this.txtDrSoyad.TabIndex = 7;
            // 
            // txtDrTc
            // 
            this.txtDrTc.Location = new System.Drawing.Point(173, 60);
            this.txtDrTc.Name = "txtDrTc";
            this.txtDrTc.Size = new System.Drawing.Size(535, 22);
            this.txtDrTc.TabIndex = 6;
            // 
            // txtDrAd
            // 
            this.txtDrAd.Location = new System.Drawing.Point(173, 106);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(535, 22);
            this.txtDrAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAİL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoktor";
            this.Text = "DOKTOR İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormDoktor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.tabPageDrEkle.ResumeLayout(false);
            this.tabPageDrEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListele;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.TabPage tabPageDrEkle;
        private System.Windows.Forms.TextBox txtDrTc;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDrTel;
        private System.Windows.Forms.ComboBox comboBoxDrBranslar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrEkle;
        private System.Windows.Forms.TextBox txtDrEmail;
        private System.Windows.Forms.TextBox txtDrSoyad;
    }
}