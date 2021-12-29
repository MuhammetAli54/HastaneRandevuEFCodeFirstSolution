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
        //Global alan
        DoktorManager drManager = new DoktorManager();

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            //comboBox
            //comboBoxDrBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxDrBranslar.DisplayMember = "TheValue";
            //comboBoxDrBranslar.ValueMember = "TheKey";
            //comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            //comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;

            comboBoxDrBranslar.DataSource = Enum.GetValues(typeof(Branslar));
           

            //maskedtextbox maske ayarlaması
            maskedTextBoxDrTel.Mask = @"\0\(500)-000-00-00";  //10 hane
            DrGrideVerileriGetir(); 
        }
        private void btnDrEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //kontrol edilmesi gerekenler var
                //TcNo
                if (txtDrTc.Text.Trim().Length!=11)
                {
                    throw new Exception("TC Kimlik Numarası 11 haneli olmalıdır!");
                }
                if (txtDrTc.Text.Any(x=> !char.IsDigit(x)))
                {
                    throw new Exception("TC Kimlik Numarası rakamlardan oluşacak şekilde 11 haneli olmalıdır.!");
                }
                //ad soyad en az 2 karakterde olmalı
                if (txtDrAd.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz!");
                }
                if (txtDrSoyad.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen doktor soyadını düzgün giriniz!");
                }

                Branslar drBransi;
                Enum.TryParse(comboBoxDrBranslar.SelectedValue.ToString(), out drBransi);
                Doktor yeniDoktor = new Doktor()
                {
                    DoktorAdi = txtDrAd.Text.Trim(),
                    DoktorSoyadi = txtDrSoyad.Text.Trim(),
                    Brans = drBransi,
                    Email = txtDrEmail.Text,
                    Telefon = maskedTextBoxDrTel.Text.Replace("-","").Replace("(","").Replace(")",""),
                    TCNo = txtDrTc.Text
                };
                //sisteme ekleme yapması gerekiyor.
                if (drManager.YeniDoktorEkle(yeniDoktor))
                {
                    MessageBox.Show($"{txtDrAd.Text.Trim()} {txtDrSoyad.Text.Trim()} sisteme yeni doktorumuz olarak eklenmiştir.");
                    DrEkleSayfasiTemizle();
                    DrGrideVerileriGetir();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: "+ex.Message);
            }
        }

        private void DrGrideVerileriGetir()
        {
          dataGridViewDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
        }

        private void DrEkleSayfasiTemizle()
        {
            txtDrAd.Clear();
            txtDrSoyad.Clear();
            txtDrTc.Clear();
            txtDrEmail.Clear();
            comboBoxDrBranslar.SelectedIndex = 0;
            maskedTextBoxDrTel.Clear();
        }

        private void comboBoxDrBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPageDrEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
