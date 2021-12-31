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
    public partial class FormHastaCagir : Form
    {
        public FormHastaCagir()
        {
            InitializeComponent();
        }

        //Global alan

        DoktorManager drManager = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();
        Doktor SecilenDoktor { get; set; }

        public bool FormLoadBittiMi { get; set; } = false;
        private void FormHastaCagir_Load(object sender, EventArgs e)
        {
            FormLoadBittiMi = false;
            //Combo dolacak
            ComboyaDoktorlariGetir();
            //btnDurdur
            btnBasla.Enabled = true;
            btnDurdur.Enabled = false;
            //label
            labelHasta.Text = "*******";
            //doktor
            SecilenDoktor = null;
            FormLoadBittiMi = true;
        }

        private void ComboyaDoktorlariGetir()
        {
            comboBoxDoktor.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxDoktor.ValueMember = "DoktorId";
            comboBoxDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
            comboBoxDoktor.SelectedIndex = -1;
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoktor.SelectedIndex >= 0)
            {
                SecilenDoktor = drManager.DoktoruIdNoyaGoreBul((int)comboBoxDoktor.SelectedValue);

                if (rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now).Count == 0  && FormLoadBittiMi)
                {
                    MessageBox.Show($"{SecilenDoktor.ToString()} adlı doktorun bugün hiç randevusu bulunmuyor!");
                    timer1.Stop();
                    btnBasla.Enabled = true;
                    btnDurdur.Enabled = false;
                }
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;  //1 saniye verdik
            timer1.Enabled = true;
            //timer1.Start(); ---> bu şekilde de yazılabilir
            btnDurdur.Enabled = true;
            btnBasla.Enabled = false;
            comboBoxDoktor.Enabled=false;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBasla.Enabled = true;
            btnDurdur.Enabled = false;
            labelHasta.Font = new Font("Arial", 25);
            comboBoxDoktor.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Font BuyukFont = new Font("Arial", 25);
            Font NormalFont = new Font("Arial", 30);
            if (SecilenDoktor != null)
            {
                //Doktorun bugüne ait randevularını bulalım.
                List<RandevuBilgileri> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now);

                if (drRandevulari.Count > 0)
                {
                    RandevuBilgileri bulunanRandevu = drRandevulari.FirstOrDefault(x => x.RandevuTarihi.ToString("HH") == DateTime.Now.Hour.ToString() && x.RandevuTarihi.Minute < DateTime.Now.Minute + 2 && x.RandevuTarihi.Minute > DateTime.Now.Minute - 2);

                    if (bulunanRandevu != null)
                    {
                        labelHasta.Text = $"{bulunanRandevu.Hasta.HastaAdi} {bulunanRandevu.Hasta.HastaSoyadi}";
                        if (DateTime.Now.Second % 2 == 0)
                        {
                            labelHasta.Font = BuyukFont;
                            labelHasta.ForeColor = Color.Red;
                        }
                        else
                        {
                            labelHasta.Font = NormalFont;
                            labelHasta.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
