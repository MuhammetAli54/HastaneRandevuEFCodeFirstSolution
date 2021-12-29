
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormRandevuAlma
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
            this.tabPageRandevuIslem = new System.Windows.Forms.TabPage();
            this.groupBoxRandevu = new System.Windows.Forms.GroupBox();
            this.btnrandevuyuAl = new System.Windows.Forms.Button();
            this.UC_RandevuSaat1 = new HastaneRandevuEFCF_WinFormUI.UC_RandevuSaat();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBoxServis = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDoktorlar = new System.Windows.Forms.ListBox();
            this.comboBoxServis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxHasta = new System.Windows.Forms.GroupBox();
            this.listBoxHastalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaTCArama = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCiktiDoktorSec = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuIslem.SuspendLayout();
            this.groupBoxRandevu.SuspendLayout();
            this.groupBoxServis.SuspendLayout();
            this.groupBoxHasta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuIslem);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRandevuIslem
            // 
            this.tabPageRandevuIslem.BackColor = System.Drawing.Color.Bisque;
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxRandevu);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxServis);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxHasta);
            this.tabPageRandevuIslem.Location = new System.Drawing.Point(4, 25);
            this.tabPageRandevuIslem.Name = "tabPageRandevuIslem";
            this.tabPageRandevuIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevuIslem.Size = new System.Drawing.Size(1250, 646);
            this.tabPageRandevuIslem.TabIndex = 0;
            this.tabPageRandevuIslem.Text = "RANDEVU İŞLEMLERİ SAYFASI";
            // 
            // groupBoxRandevu
            // 
            this.groupBoxRandevu.Controls.Add(this.btnrandevuyuAl);
            this.groupBoxRandevu.Controls.Add(this.UC_RandevuSaat1);
            this.groupBoxRandevu.Controls.Add(this.label4);
            this.groupBoxRandevu.Controls.Add(this.dateTimePickerRandevuTarihi);
            this.groupBoxRandevu.Location = new System.Drawing.Point(807, 22);
            this.groupBoxRandevu.Name = "groupBoxRandevu";
            this.groupBoxRandevu.Size = new System.Drawing.Size(429, 376);
            this.groupBoxRandevu.TabIndex = 1;
            this.groupBoxRandevu.TabStop = false;
            this.groupBoxRandevu.Text = "RANDEVU TARİH VE SAAT İŞLEMLERİ";
            // 
            // btnrandevuyuAl
            // 
            this.btnrandevuyuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevuyuAl.Location = new System.Drawing.Point(65, 320);
            this.btnrandevuyuAl.Name = "btnrandevuyuAl";
            this.btnrandevuyuAl.Size = new System.Drawing.Size(310, 50);
            this.btnrandevuyuAl.TabIndex = 3;
            this.btnrandevuyuAl.Text = "RANDEVU AL";
            this.btnrandevuyuAl.UseVisualStyleBackColor = true;
            this.btnrandevuyuAl.Click += new System.EventHandler(this.btnrandevuyuAl_Click);
            // 
            // UC_RandevuSaat1
            // 
            this.UC_RandevuSaat1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UC_RandevuSaat1.DisaridanGelenTarih = new System.DateTime(2021, 12, 29, 10, 12, 5, 749);
            this.UC_RandevuSaat1.Doktorum = null;
            this.UC_RandevuSaat1.Location = new System.Drawing.Point(23, 100);
            this.UC_RandevuSaat1.Name = "UC_RandevuSaat1";
            this.UC_RandevuSaat1.RandevuAlmaAktifMi = false;
            this.UC_RandevuSaat1.SecilenRandevuTarihi = new System.DateTime(((long)(0)));
            this.UC_RandevuSaat1.Size = new System.Drawing.Size(380, 214);
            this.UC_RandevuSaat1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "RANDEVU SAATİ SEÇ:";
            // 
            // dateTimePickerRandevuTarihi
            // 
            this.dateTimePickerRandevuTarihi.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dateTimePickerRandevuTarihi.Location = new System.Drawing.Point(159, 42);
            this.dateTimePickerRandevuTarihi.Name = "dateTimePickerRandevuTarihi";
            this.dateTimePickerRandevuTarihi.Size = new System.Drawing.Size(264, 22);
            this.dateTimePickerRandevuTarihi.TabIndex = 0;
            this.dateTimePickerRandevuTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerRandevuTarihi_ValueChanged);
            // 
            // groupBoxServis
            // 
            this.groupBoxServis.Controls.Add(this.label3);
            this.groupBoxServis.Controls.Add(this.listBoxDoktorlar);
            this.groupBoxServis.Controls.Add(this.comboBoxServis);
            this.groupBoxServis.Controls.Add(this.label2);
            this.groupBoxServis.Location = new System.Drawing.Point(435, 22);
            this.groupBoxServis.Name = "groupBoxServis";
            this.groupBoxServis.Size = new System.Drawing.Size(366, 378);
            this.groupBoxServis.TabIndex = 0;
            this.groupBoxServis.TabStop = false;
            this.groupBoxServis.Text = "SERVİS VE DOKTOR SEÇİMLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOKTOR SEÇİNİZ:";
            // 
            // listBoxDoktorlar
            // 
            this.listBoxDoktorlar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxDoktorlar.FormattingEnabled = true;
            this.listBoxDoktorlar.ItemHeight = 16;
            this.listBoxDoktorlar.Location = new System.Drawing.Point(9, 132);
            this.listBoxDoktorlar.Name = "listBoxDoktorlar";
            this.listBoxDoktorlar.Size = new System.Drawing.Size(351, 244);
            this.listBoxDoktorlar.TabIndex = 2;
            this.listBoxDoktorlar.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktorlar_SelectedIndexChanged);
            // 
            // comboBoxServis
            // 
            this.comboBoxServis.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBoxServis.FormattingEnabled = true;
            this.comboBoxServis.Location = new System.Drawing.Point(129, 47);
            this.comboBoxServis.Name = "comboBoxServis";
            this.comboBoxServis.Size = new System.Drawing.Size(231, 24);
            this.comboBoxServis.TabIndex = 1;
            this.comboBoxServis.SelectedIndexChanged += new System.EventHandler(this.comboBoxServis_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SERVİS SEÇİNİZ:";
            // 
            // groupBoxHasta
            // 
            this.groupBoxHasta.Controls.Add(this.listBoxHastalar);
            this.groupBoxHasta.Controls.Add(this.label1);
            this.groupBoxHasta.Controls.Add(this.txtHastaTCArama);
            this.groupBoxHasta.Location = new System.Drawing.Point(8, 22);
            this.groupBoxHasta.Name = "groupBoxHasta";
            this.groupBoxHasta.Size = new System.Drawing.Size(421, 378);
            this.groupBoxHasta.TabIndex = 0;
            this.groupBoxHasta.TabStop = false;
            this.groupBoxHasta.Text = "HASTA SEÇİMİ İŞLEMLERİ";
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.ItemHeight = 16;
            this.listBoxHastalar.Location = new System.Drawing.Point(9, 84);
            this.listBoxHastalar.Name = "listBoxHastalar";
            this.listBoxHastalar.Size = new System.Drawing.Size(406, 292);
            this.listBoxHastalar.TabIndex = 0;
            this.listBoxHastalar.SelectedIndexChanged += new System.EventHandler(this.listBoxHastalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA TC NO:";
            // 
            // txtHastaTCArama
            // 
            this.txtHastaTCArama.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtHastaTCArama.Location = new System.Drawing.Point(132, 44);
            this.txtHastaTCArama.Name = "txtHastaTCArama";
            this.txtHastaTCArama.Size = new System.Drawing.Size(270, 22);
            this.txtHastaTCArama.TabIndex = 0;
            this.txtHastaTCArama.TextChanged += new System.EventHandler(this.txtHastaTCArama_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBoxCiktiDoktorSec);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "DOKTOR SEÇİNİZ:";
            // 
            // comboBoxCiktiDoktorSec
            // 
            this.comboBoxCiktiDoktorSec.FormattingEnabled = true;
            this.comboBoxCiktiDoktorSec.Location = new System.Drawing.Point(142, 32);
            this.comboBoxCiktiDoktorSec.Name = "comboBoxCiktiDoktorSec";
            this.comboBoxCiktiDoktorSec.Size = new System.Drawing.Size(351, 24);
            this.comboBoxCiktiDoktorSec.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormRandevuAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1270, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRandevuAlma";
            this.Text = "RANDEVU ALMA İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormRandevuAlma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRandevuIslem.ResumeLayout(false);
            this.groupBoxRandevu.ResumeLayout(false);
            this.groupBoxRandevu.PerformLayout();
            this.groupBoxServis.ResumeLayout(false);
            this.groupBoxServis.PerformLayout();
            this.groupBoxHasta.ResumeLayout(false);
            this.groupBoxHasta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRandevuIslem;
        private System.Windows.Forms.GroupBox groupBoxRandevu;
        private System.Windows.Forms.GroupBox groupBoxServis;
        private System.Windows.Forms.GroupBox groupBoxHasta;
        private System.Windows.Forms.ListBox listBoxHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaTCArama;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDoktorlar;
        private System.Windows.Forms.ComboBox comboBoxServis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihi;
        private UC_RandevuSaat UC_RandevuSaat1;
        private System.Windows.Forms.Button btnrandevuyuAl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCiktiDoktorSec;
        private System.Windows.Forms.Label label5;
    }
}