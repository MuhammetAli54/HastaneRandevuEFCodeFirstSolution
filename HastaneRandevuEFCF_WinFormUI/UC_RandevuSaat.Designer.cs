
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class UC_RandevuSaat
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRandevuButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelRandevuButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSaatler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(3, 23);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(318, 24);
            this.comboBoxSaatler.TabIndex = 1;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAAT SEÇİNİZ:";
            // 
            // tableLayoutPanelRandevuButonlar
            // 
            this.tableLayoutPanelRandevuButonlar.ColumnCount = 2;
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn45, 1, 1);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn15, 1, 0);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn30, 0, 1);
            this.tableLayoutPanelRandevuButonlar.Location = new System.Drawing.Point(21, 94);
            this.tableLayoutPanelRandevuButonlar.Name = "tableLayoutPanelRandevuButonlar";
            this.tableLayoutPanelRandevuButonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Size = new System.Drawing.Size(338, 118);
            this.tableLayoutPanelRandevuButonlar.TabIndex = 1;
            // 
            // btn45
            // 
            this.btn45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn45.Location = new System.Drawing.Point(172, 62);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(163, 53);
            this.btn45.TabIndex = 5;
            this.btn45.Text = "button4";
            this.btn45.UseVisualStyleBackColor = false;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn00.Location = new System.Drawing.Point(3, 3);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(163, 53);
            this.btn00.TabIndex = 2;
            this.btn00.Text = "button1";
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn15.Location = new System.Drawing.Point(172, 3);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(163, 53);
            this.btn15.TabIndex = 3;
            this.btn15.Text = "button2";
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // btn30
            // 
            this.btn30.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn30.Location = new System.Drawing.Point(3, 62);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(163, 53);
            this.btn30.TabIndex = 4;
            this.btn30.Text = "button3";
            this.btn30.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_RandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.tableLayoutPanelRandevuButonlar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_RandevuSaat";
            this.Size = new System.Drawing.Size(380, 236);
            this.Load += new System.EventHandler(this.UC_RandevuSaat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelRandevuButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRandevuButonlar;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Timer timer1;
    }
}
