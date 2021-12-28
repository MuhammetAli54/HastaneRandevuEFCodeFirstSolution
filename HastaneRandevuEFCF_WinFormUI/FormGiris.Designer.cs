
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormGiris
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
            this.btnDoktorIslemleri = new System.Windows.Forms.Button();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.btnRandevuIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoktorIslemleri
            // 
            this.btnDoktorIslemleri.BackColor = System.Drawing.Color.LightGray;
            this.btnDoktorIslemleri.Location = new System.Drawing.Point(110, 75);
            this.btnDoktorIslemleri.Name = "btnDoktorIslemleri";
            this.btnDoktorIslemleri.Size = new System.Drawing.Size(187, 76);
            this.btnDoktorIslemleri.TabIndex = 0;
            this.btnDoktorIslemleri.Text = "DOKTOR İŞLEMLERİ FORMU";
            this.btnDoktorIslemleri.UseVisualStyleBackColor = false;
            this.btnDoktorIslemleri.Click += new System.EventHandler(this.btnDoktorIslemleri_Click);
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.BackColor = System.Drawing.Color.LightGray;
            this.btnHastaIslemleri.Location = new System.Drawing.Point(110, 186);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(187, 76);
            this.btnHastaIslemleri.TabIndex = 1;
            this.btnHastaIslemleri.Text = "HASTA İŞLEMLERİ FORMU";
            this.btnHastaIslemleri.UseVisualStyleBackColor = false;
            // 
            // btnRandevuIslemleri
            // 
            this.btnRandevuIslemleri.BackColor = System.Drawing.Color.LightGray;
            this.btnRandevuIslemleri.Location = new System.Drawing.Point(110, 296);
            this.btnRandevuIslemleri.Name = "btnRandevuIslemleri";
            this.btnRandevuIslemleri.Size = new System.Drawing.Size(187, 76);
            this.btnRandevuIslemleri.TabIndex = 2;
            this.btnRandevuIslemleri.Text = "RANDEVU İŞLEMLERİ FORMU";
            this.btnRandevuIslemleri.UseVisualStyleBackColor = false;
            this.btnRandevuIslemleri.Click += new System.EventHandler(this.btnRandevuIslemleri_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(404, 502);
            this.Controls.Add(this.btnRandevuIslemleri);
            this.Controls.Add(this.btnHastaIslemleri);
            this.Controls.Add(this.btnDoktorIslemleri);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorIslemleri;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Button btnRandevuIslemleri;
    }
}