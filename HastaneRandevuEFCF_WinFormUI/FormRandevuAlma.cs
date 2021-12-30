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
    public partial class FormRandevuAlma : Form
    {
        public FormRandevuAlma()
        {
            InitializeComponent();
        }

        HastaManager hastaManagerim = new HastaManager();
        DoktorManager doktorManagerim = new DoktorManager();
        RandevuManager randevuManagerim = new RandevuManager();
        private void FormRandevuAlma_Load(object sender, EventArgs e)
        {
            //Servis groupBox ve TarihSaat groupBoxları pasif  olmalı
            ServisGroupBoxiniPasiflestir();
            RandevuTarihveSaatGroupBoxiniPasiflestir();
            HastaListBoxiniDoldur();
            //datetimepicker'ı formatla
            DateTimePickeriAyarla(DateTime.Now);

            //comboCiktiAl
            DoktorlariComboBoxCiktiAlDrSeceDoldur();

        }

        private void DoktorlariComboBoxCiktiAlDrSeceDoldur()
        {
            comboBoxCiktiAlDrSec.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxCiktiAlDrSec.ValueMember = "DoktorId";
            comboBoxCiktiAlDrSec.DataSource = doktorManagerim.TumAktifDoktorlariGetir();
        }

        private void DateTimePickeriAyarla(DateTime trh)
        {
            dateTimePickerRandevuTarihi.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihi.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRandevuTarihi.MinDate = trh;
            dateTimePickerRandevuTarihi.MaxDate = dateTimePickerRandevuTarihi.MinDate.AddDays(15);
            dateTimePickerRandevuTarihi.Value = trh;
            ////
            dateTimePickerCikti.Format = DateTimePickerFormat.Custom;
            dateTimePickerCikti.CustomFormat = "dd.MM.yyyy";
            dateTimePickerCikti.MinDate = DateTime.Now;
            dateTimePickerCikti.MaxDate = dateTimePickerCikti.MinDate.AddDays(15);
            dateTimePickerCikti.Value = DateTime.Now;
        }

        private void HastaListBoxiniDoldur()
        {
            listBoxHastalar.DataSource = hastaManagerim.TumHastalariGetir();
            listBoxHastalar.SelectedIndex = -1;
        }

        private void RandevuTarihveSaatGroupBoxiniPasiflestir()
        {
            groupBoxRandevu.Enabled = false;
        }

        private void RandevuTarihveSaatGroupBoxiniAktiflestir()
        {
            groupBoxRandevu.Enabled = true;
        }

        private void ServisGroupBoxiniPasiflestir()
        {
            groupBoxServis.Enabled = false;
        }

        private void txtHastaTCArama_TextChanged(object sender, EventArgs e)
        {
            if (txtHastaTCArama.Text.Trim().Length >= 2)
            {
                listBoxHastalar.DataSource = hastaManagerim.TcNosunaGöreHastayiBul(txtHastaTCArama.Text);
            }
            else
            {
                HastaListBoxiniDoldur();
            }
        }

        private void listBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHastalar.SelectedIndex >= 0)
            {
                ServisGroupBoxiniAktiflestir();
            }
            else
            {
                UC_RandevuSaat1.Doktorum = null;
                ServisGroupBoxiniPasiflestir();
                RandevuTarihveSaatGroupBoxiniPasiflestir();
            }
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }
        private void ServisGroupBoxiniAktiflestir()
        {
            groupBoxServis.Enabled = true;
            //servis combo dolmalı
            ComboBoxServisiDoldur();
        }

        private void ComboBoxServisiDoldur()
        {
            comboBoxServis.DataSource = Enum.GetValues(typeof(Branslar));
            comboBoxServis.SelectedIndex = -1;
        }

        private void comboBoxServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServis.SelectedIndex >= 0)
            {
                DoktorlarListesiniDoldur();
            }
            else
            {
                RandevuTarihveSaatGroupBoxiniPasiflestir();
                listBoxDoktorlar.DataSource = null;
            }
            listBoxDoktorlar.SelectedIndex = -1;
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }

        private void DoktorlarListesiniDoldur()
        {
            Branslar drBransi;
            Enum.TryParse(comboBoxServis.SelectedValue.ToString(), out drBransi);
            listBoxDoktorlar.DataSource = doktorManagerim.BransaGoreDoktorlariGetir(drBransi);
        }

        private void listBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(DateTime.Now);
            if (listBoxDoktorlar.SelectedIndex >= 0)
            {
                RandevuTarihveSaatGroupBoxiniAktiflestir();
                Doktor seciliDr = listBoxDoktorlar.SelectedItem as Doktor;
                UC_RandevuSaat1.Doktorum = seciliDr;
            }
            else
            {
                RandevuTarihveSaatGroupBoxiniPasiflestir();
                UC_RandevuSaat1.Doktorum = null;
            }
        }

        private void dateTimePickerRandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(dateTimePickerRandevuTarihi.Value);
            UC_RandevuSaat1.DisaridanGelenTarih = dateTimePickerRandevuTarihi.Value;
            UC_RandevuSaat1.Temizle();
        }

        private void btnrandevuyuAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxHastalar.SelectedIndex < 0)
                {
                    MessageBox.Show("Hasta seçmeden randevu işlemleri yapılamaz!");
                    return;
                }
                if (listBoxDoktorlar.SelectedIndex < 0)
                {
                    throw new Exception("Doktor seçmeden randevu işlemleri yapılamaz!");
                }
                if (!UC_RandevuSaat1.RandevuAlmaAktifMi)
                {
                    MessageBox.Show("Randevu alabilmeniz için yukarıdaki randevu saati butonlarına tıklayarak saat seçmelisiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Hastanın o tarihe o saate başka randevusu varsa alamaz
                Hasta secilenHasta = listBoxHastalar.SelectedItem as Hasta;

                //Dikkat etmek gerekir (SecilenRandevuTarihi) !!!!!
                if (randevuManagerim.HastaninSecilenTarihveSaatteRandevusuVarMi(secilenHasta, UC_RandevuSaat1.SecilenRandevuTarihi))
                {
                    MessageBox.Show($"DİKKAT:{UC_RandevuSaat1.SecilenRandevuTarihi.ToString("dd.MM.yyyy HH:mm:ss")} tarihinde başka bir randevunuz vardır. Bu nedenle aynı saate randevu alamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // Bu if'e de takılmadıysa hasta randevusunu alabilir.
                Doktor secilenDoktor = listBoxDoktorlar.SelectedItem as Doktor;
                RandevuBilgileri yeniRandevu = new RandevuBilgileri()
                {
                    HastaId = secilenHasta.HastaId,
                    DoktorId = secilenDoktor.DoktorId,
                    RandevuTarihi = UC_RandevuSaat1.SecilenRandevuTarihi
                };
                bool rndAlindiMi = false;
                rndAlindiMi = randevuManagerim.RandevuyuAl(yeniRandevu);
                if (rndAlindiMi)
                {
                    MessageBox.Show("RANDEVUNUZ ALINMIŞTIR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Alınan randevuyu listView'e ekleyelim
                    ListVieweRandevuyuEkle(yeniRandevu);

                    //temizlik
                    UC_RandevuSaat1.Temizle();
                    //dateTimePickerRandevuTarihi.Value = DateTime.Now;
                    RandevuTarihveSaatGroupBoxiniPasiflestir();
                    comboBoxServis.SelectedIndex = -1;
                    listBoxDoktorlar.SelectedIndex = -1;
                    ServisGroupBoxiniPasiflestir();
                    listBoxHastalar.SelectedIndex = -1;
                }
                else
                {
                    throw new Exception("Randevu alma işleminde beklenmedik bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void ListVieweRandevuyuEkle(RandevuBilgileri yeniRandevu)
        {
            RandevuBilgileriViewModel randevu = randevuManagerim.RandevuyuViewMoedeleAktar(yeniRandevu);
            ListViewItem li = new ListViewItem();
            li.Text = randevu.Servis;
            li.SubItems.Add(randevu.DoktorAdSoyad);
            li.SubItems.Add(randevu.HastaAdSoyad);
            li.SubItems.Add(randevu.RandevuTarihi.ToString("dd.MM.yyyy HH:mm"));
            li.Tag = randevu;
            listViewAlinanRandevular.Items.Add(li);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //temizlik randevu al
            UC_RandevuSaat1.Temizle();
            RandevuTarihveSaatGroupBoxiniPasiflestir();
            comboBoxServis.SelectedIndex = -1;
            listBoxDoktorlar.SelectedIndex = -1;
            txtHastaTCArama.Clear();
            ServisGroupBoxiniPasiflestir();
            listBoxHastalar.SelectedIndex = -1;
            dateTimePickerRandevuTarihi.Value = DateTime.Now;
            //temizlik çıktı al
            btnCiktiAl.Enabled = false;
            dateTimePickerCikti.Value = DateTime.Now;
            comboBoxCiktiAlDrSec.SelectedIndex = 0;
        }

        private void comboBoxCiktiAlDrSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCiktiAlDrSec.SelectedIndex < 0)
                {
                    throw new Exception("Lütfen doktor seçiniz!");
                }
                Doktor secilenDr = doktorManagerim.DoktoruIdNoyaGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                CiktiAlButonuAktifPasifliginiAyarla(secilenDr, dateTimePickerCikti.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void CiktiAlButonuAktifPasifliginiAyarla(Doktor dr, DateTime tarih)
        {
            btnCiktiAl.Enabled = false;
            btnCiktiAl.BackColor = SystemColors.Control;
            if (dr != null)
            {
                List<RandevuBilgileri> rndList = randevuManagerim.DoktorunRandevulariniTariheGoreGetir(dr, tarih);
                if (rndList.Count > 0)
                {
                    btnCiktiAl.Enabled = true;
                    btnCiktiAl.BackColor = Color.Aquamarine;
                }
                else
                {
                    MessageBox.Show($"Sayın {dr.ToString()}, {tarih.ToString("dd.MM.yyyy")} tarihinde randevunuz bulunmamaktadır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dateTimePickerCikti_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCiktiAlDrSec.SelectedIndex > 0)
            {
                Doktor secilenDr = doktorManagerim.DoktoruIdNoyaGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                CiktiAlButonuAktifPasifliginiAyarla(secilenDr, dateTimePickerCikti.Value);
            }
            else
            {
                // MessageBox.Show("Lütfen doktor seçiniz!");
            }
        }

        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
                btnCiktiAl.BackColor = SystemColors.Control;
                btnCiktiAl.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Doktor doktorum = doktorManagerim.DoktoruIdNoyaGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                Bitmap bmp1 = Properties.Resources.doktorRandevularResim1;
                Image resim1 = bmp1;

                Bitmap bmp2 = Properties.Resources.doktorRandevularResim2;
                Image resim2 = bmp2;

                e.Graphics.DrawImage(resim1, 25, 25, resim1.Width / 10, resim1.Height / 10);
                e.Graphics.DrawImage(resim2, 725, 25, resim2.Width / 10, resim2.Height / 10);
                e.Graphics.DrawString($"{EnumManager.BransiTurkceStringOlarakVer(doktorum.Brans)} Servisi - {doktorum.ToString()} - {dateTimePickerCikti.Value.ToString("dd.MM.yyyy")} tarihine ait randevular ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
                e.Graphics.DrawString("Tarih ve Saat", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
                e.Graphics.DrawString("Hasta Adı Soyadı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));

                Point konumTarih = new Point(50, 235);
                Point konumHasta = new Point(200, 235);
                string[] saatler = { "09:00", "09:15", "09:30", "09:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00", "15:15", "15:30", "15:45", "16:00", "16:15", "16:30", "16:45" };

                RandevuBilgileri[] siralirandevular = new RandevuBilgileri[saatler.Length];
                List<RandevuBilgileri> drRandevular = randevuManagerim.DoktorunRandevulariniTariheGoreGetir(doktorum, dateTimePickerCikti.Value);

                foreach (RandevuBilgileri item in drRandevular)
                {
                    for (int i = 0; i < saatler.Length; i++)
                    {
                        if (saatler[i]==item.RandevuTarihi.ToString("HHH:mm"))
                        {
                            siralirandevular[i] = item;
                        }
                    }
                }
                foreach (RandevuBilgileri item in siralirandevular)
                {
                    if (item!=null)
                    {
                        konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                        e.Graphics.DrawString($"{item.RandevuTarihi.ToString("dd.MM.yyyy")} - {item.RandevuTarihi.ToString("HH:mm")}",new Font("Arial",10,FontStyle.Regular),Brushes.Black,konumTarih);

                        konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                        e.Graphics.DrawString($"{item.Hasta.HastaAdi} {item.Hasta.HastaSoyadi}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }
    }
}
