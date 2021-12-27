using HastaneRandevuEFCF_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_BLL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();

        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            //comboBox
            comboBoxDrBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrBranslar.DisplayMember = "TheValue";
            comboBoxDrBranslar.ValueMember = "TheKey";
            comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;
           
        }
        private void btnDrEkle_Click(object sender, EventArgs e)
        {
            Doktor yeniDoktor = new Doktor()
            {
                DoktorAdi = txtDrAd.Text.Trim(),
                DoktorSoyadi = txtDrSoyad.Text.Trim(),
               // Brans = Enum.GetValue()
                Email = txtDrEmail.Text,
                Telefon = maskedTextBoxDrTel.Text,
                TCNo = txtDrTc.Text
            };
        }

        private void comboBoxDrBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
