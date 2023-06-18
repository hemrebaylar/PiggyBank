using KumbaraProject.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KumbaraProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            toplamHacim = 0;
            lblInserted.Text = "";
            lstSonuc.Items.Clear();
            allTransactions.Clear();
            kumbaram.ElliKurus = 0;
            kumbaram.BirLira = 0;
            kumbaram.BesLira = 0;
            kumbaram.ToplamTutar = 0;
            kumbaram.Mass = 0;
        }
        const double pi = 3.14;
        const int kumbaraHacmi = 125000; //mm3
        bool kirikMi = false;
        bool hacimDegisti = false;
        public static List<Transaction> allTransactions = new List<Transaction>();
        double toplamHacim = 0;
        Kumbaram kumbaram = new Kumbaram();

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        double HacimHesapla(ICoin coin)
        {
            double hacim = pi * (coin.radius * coin.radius) * coin.height;
            return hacim;
        }
        double HacimHesapla(ICash cash)
        {
            int katliKalinlik = Convert.ToInt32(cash.width * 4);
            double katliUzunluk = cash.height / 4;
            Random rnd = new Random();
            double hh = cash.length * katliKalinlik * katliUzunluk;
            double hacim = hh + (hh * (rnd.Next(25, 75) / 100));
            return hacim;
        }

        bool HacimKontrol()
        {
            if (toplamHacim >= kumbaraHacmi)
            {
                return false;
            }
            else return true;
        }
        private void btnZeroFifty_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HacimKontrol())
                {
                    MessageBox.Show(Hatalar.KumbaraDoldu);
                }
                else
                {
                    ZeroFiftyLira zeroFifty = new ZeroFiftyLira();
                    Transaction yeniIslem = new Transaction();
                    yeniIslem.Name = "50 Kuruş";
                    yeniIslem.Value = zeroFifty.value;
                    yeniIslem.Mass = HacimHesapla(zeroFifty);
                    ++kumbaram.ElliKurus;
                    toplamHacim += yeniIslem.Mass;
                    lblInserted.Text = "50 Kuruş Eklendi!";
                    hacimDegisti = true;
                    allTransactions.Add(yeniIslem);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnOneLira_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HacimKontrol())
                {
                    MessageBox.Show(Hatalar.KumbaraDoldu);
                }
                else
                {
                    OneLira oneLira = new OneLira();
                    Transaction yeniIslem = new Transaction();
                    yeniIslem.Name = "1 Lira";
                    yeniIslem.Value = oneLira.value;
                    yeniIslem.Mass = HacimHesapla(oneLira);
                    ++kumbaram.BirLira;
                    toplamHacim += yeniIslem.Mass;
                    hacimDegisti = true;
                    lblInserted.Text = "1 TL Eklendi!";
                    allTransactions.Add(yeniIslem);
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnFiveLira_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HacimKontrol())
                {
                    MessageBox.Show(Hatalar.KumbaraDoldu);
                }
                else
                {
                    FiveLira fiveLira = new FiveLira();
                    Transaction yeniIslem = new Transaction();
                    yeniIslem.Name = "5 Lira";
                    yeniIslem.Value = fiveLira.value;
                    yeniIslem.Mass = HacimHesapla(fiveLira);
                    ++kumbaram.BesLira;
                    toplamHacim += yeniIslem.Mass;
                    hacimDegisti = true;
                    lblInserted.Text = "5 TL Eklendi!";
                    allTransactions.Add(yeniIslem);
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnTenLira_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HacimKontrol())
                {
                    MessageBox.Show(Hatalar.KumbaraDoldu);
                }
                else
                {
                    TenLira tenLira = new TenLira();
                    Transaction yeniIslem = new Transaction();
                    yeniIslem.Name = "10 Lira";
                    yeniIslem.Value = tenLira.value;
                    yeniIslem.Mass = HacimHesapla(tenLira);
                    ++kumbaram.OnLira;
                    hacimDegisti = true;
                    toplamHacim += yeniIslem.Mass;
                    lblInserted.Text = "10 TL Eklendi!";
                    allTransactions.Add(yeniIslem);
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            
            if (kirikMi)
            {
                MessageBox.Show(Hatalar.KumbaraZatenKirik);
            }
            else
            {
                foreach (Transaction item in allTransactions)
                {
                    kumbaram.ToplamTutar += item.Value;
                }
                lstSonuc.Items.Add(kumbaram.ElliKurus + " x 50 Kuruş");
                lstSonuc.Items.Add(kumbaram.BirLira + " x 1 Lira");
                lstSonuc.Items.Add(kumbaram.BesLira + " x 5 Lira");
                lstSonuc.Items.Add(kumbaram.OnLira + " x 10 Lira");
                lstSonuc.Items.Add(kumbaram.ToplamTutar + " TL Biriktirdiniz!");
                ++kumbaram.BreakCount;
                kirikMi = true;
            }
            
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (!kirikMi)
            {
                MessageBox.Show(Hatalar.KirikDegil);
            }
            else
            {
                if (kumbaram.BreakCount < 2)
                {
                    Temizle();
                    kirikMi = false;
                    MessageBox.Show(Hatalar.KumbaraYenilendi);
                }
                else MessageBox.Show(Hatalar.KumbaraYapismaz);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kumbaranın içine seçtiğiniz parayı atabilirsiniz.Para attıkça kumbaranızı sallamayı" +
                " unutmayın!/nKumbarayı kırdığınızda içindeki tüm paraları ve toplam birikimi görebilirsiniz!" +
                " Kumbarayı yapıştırıp bir sefer daha birikim yapabilirsiniz!(2.sefer yok)");
        }
        int sallama = 0;
        private void button1_Click(object sender, EventArgs e)//sallama butonu
        {
            if (hacimDegisti)
            {
                if (!HacimKontrol())
                {
                    sallama++;
                }
                if (sallama < 3)//dolduktan sonra sadece 2 sallantıda hacim düşecek
                {
                    toplamHacim = toplamHacim - (toplamHacim * 0.25);
                }
                
                timer1.Start();
                lblInserted.Text = "Kumbara Sallandı";
                hacimDegisti = false;
            }
            else lblInserted.Text = "Kumbara daha önce sallandı";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                pictureBox1.Top = pictureBox1.Top + 10;
                pictureBox1.Left = pictureBox1.Left + 5;
                pictureBox1.Top = pictureBox1.Top + 10;
                pictureBox1.Left = pictureBox1.Left + 5;
                pictureBox1.Top = pictureBox1.Top - 10;
                pictureBox1.Left = pictureBox1.Left - 5;
                pictureBox1.Top = pictureBox1.Top - 10;
                pictureBox1.Left = pictureBox1.Left - 5;
            }
            
            timer1.Stop();
        }
    }
}
