using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Değişkenler
        Random r = new Random();
        string[,] kelimelerDizisi = new string[14, 2];
        string[] sorularDizisi = new string[28];
        int yeniKelimeLevel = 2;
        int eskiKelimeLevel = 0;
        byte olusanKelimeDizisi = 0;
        string olusanKelime = "";
        int kazanilacakPuan = 0;
        int toplamPuan = 0;
        int k = 0;
        char[] harfler;
        int[] rasgeleSayilar;
        byte kalanSure = 28;
        Random rastgele = new Random();
        public string oyuncuAdi;
        

        public void kelimeleriYukle()
        {
            int rastsayi = rastgele.Next(1, 5);
            string file = "C:\\Users\\Eray\\Desktop\\Kelime Oyunu\\Kelime Oyunu\\sorular" + rastsayi + ".txt";
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                for (int i = 0; i <= 27; i++)
                {
                    string c = sr.ReadLine();
                    sorularDizisi[i] = c;
                }
            }
            kelimelerDizisi[0, 0] = sorularDizisi[0];
            kelimelerDizisi[0, 1] = sorularDizisi[1];
            kelimelerDizisi[1, 0] = sorularDizisi[2];
            kelimelerDizisi[1, 1] = sorularDizisi[3];

            kelimelerDizisi[2, 0] = sorularDizisi[4];
            kelimelerDizisi[2, 1] = sorularDizisi[5];
            kelimelerDizisi[3, 0] = sorularDizisi[6];
            kelimelerDizisi[3, 1] = sorularDizisi[7];

            kelimelerDizisi[4, 0] = sorularDizisi[8];
            kelimelerDizisi[4, 1] = sorularDizisi[9];
            kelimelerDizisi[5, 0] = sorularDizisi[10];
            kelimelerDizisi[5, 1] = sorularDizisi[11];

            kelimelerDizisi[6, 0] = sorularDizisi[12];
            kelimelerDizisi[6, 1] = sorularDizisi[13];
            kelimelerDizisi[7, 0] = sorularDizisi[14];
            kelimelerDizisi[7, 1] = sorularDizisi[15];

            kelimelerDizisi[8, 0] = sorularDizisi[16];
            kelimelerDizisi[8, 1] = sorularDizisi[17];
            kelimelerDizisi[9, 0] = sorularDizisi[18];
            kelimelerDizisi[9, 1] = sorularDizisi[19];

            kelimelerDizisi[10, 0] = sorularDizisi[20];
            kelimelerDizisi[10, 1] = sorularDizisi[21];
            kelimelerDizisi[11, 0] = sorularDizisi[22];
            kelimelerDizisi[11, 1] = sorularDizisi[23];

            kelimelerDizisi[12, 0] = sorularDizisi[24];
            kelimelerDizisi[12, 1] = sorularDizisi[25];
            kelimelerDizisi[13, 0] = sorularDizisi[26];
            kelimelerDizisi[13, 1] = sorularDizisi[27];
        }

        

        public void yeniSoru()
        {
            eskiKelimeLevel += 1; ;
            yeniKelimeLevel += 1;

            //  if (yeniKelimeLevel >= 14) return; // dizi sınırı aşmasın

            olusanKelimeDizisi = Convert.ToByte(r.Next(eskiKelimeLevel, yeniKelimeLevel));

            lblSoru.Text = "Soru : " + kelimelerDizisi[olusanKelimeDizisi, 1]; // 1 soru 0 kelimedir.
            olusanKelime = kelimelerDizisi[olusanKelimeDizisi, 0];

            lblHarfLength.Text = "Kelime Harf Uzunluğu : " + olusanKelime.Length;

            kazanilacakPuan = olusanKelime.Length * 100;
            lblKazanPuan.Text = "Kazanılacak Puan : " + kazanilacakPuan;

            lblKelime.Text = "";
            for (int i = 0; i < olusanKelime.Length; i++)
            {
                lblKelime.Text += "?";
            }

            k = 0; // rasgele harflerin döngüsü için değişen değişken
            harfler = new char[olusanKelime.Length];
            rasgeleSayilar = new int[harfler.Length];
            for (int i = 0; i < rasgeleSayilar.Length; i++) // içine -1 atıyorum 0 olunca döngü sonsuz döngüye giriyor.
            {
                rasgeleSayilar[i] = -1;
            }

            kalanSure = 28;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeleriYukle();
        }
        public void puanlar()
        {
            
            string path = "C:\\Users\\Eray\\Desktop\\Kelime Oyunu\\Kelime Oyunu\\Puanlar.txt";
            string str;
           
            using (StreamReader sreader = new StreamReader(path))
            {
                str = sreader.ReadToEnd();
            }

            File.Delete(path);

            using (StreamWriter swriter = new StreamWriter(path, false))
            {
                str = oyuncuAdi+" "+ toplamPuan + Environment.NewLine + str;
                swriter.Write(str);

            }
           

        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            // oynanabirliği aç
            btnHarfAl.Enabled = true;
            btnTahmin.Enabled = true;
            txtTahmin.Enabled = true;

            tmrKalanSure.Enabled = true; // süreyi aç

            eskiKelimeLevel = -1; // 1 artınca 0
            yeniKelimeLevel = 0; // 1 artınca 1 olsun.

            yeniSoru();

            toplamPuan = 0;
            lblTopPuan.Text = "Toplam Puan : 0 ";
        }

        private void btnHarfAl_Click(object sender, EventArgs e)
        {

            harfler = olusanKelime.ToCharArray();
            byte rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            while (Array.IndexOf(rasgeleSayilar, rasgeleHarf) != -1) // rasgele sayılardan aynısı oluşmasın
            {
                rasgeleHarf = Convert.ToByte(r.Next(0, harfler.Length));
            }
            rasgeleSayilar[k] = rasgeleHarf;
            char verilecekHarf = harfler[rasgeleHarf];

            lblKelime.Text = lblKelime.Text.Remove(rasgeleHarf, 1);
            lblKelime.Text = lblKelime.Text.Insert(Convert.ToInt32(rasgeleHarf), verilecekHarf.ToString());

            kazanilacakPuan = kazanilacakPuan - 100;
            lblKazanPuan.Text = "Kazanılacak Puan : " + kazanilacakPuan.ToString();
            

            if (k < harfler.Length - 1) k++;
            else if(yeniKelimeLevel < 14)
            {
                //Bütün harfler alındı yeni soruya geçir
                MessageBox.Show("Bütün harfler alındı. Diğer soruya geçiliyor. Kazanılan Puan : 0");
                yeniSoru();
                return;
            }
            else
            {
                tmrKalanSure.Enabled = false;
                MessageBox.Show("Oyun bitmiştir. Toplam Puanınız : " + toplamPuan.ToString());

                txtTahmin.Text = "";
                btnHarfAl.Enabled = false;
                btnTahmin.Enabled = false;
                txtTahmin.Enabled = false;

                eskiKelimeLevel = -1;
                yeniKelimeLevel = 0;
                puanlar();
                return;

            }
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text;

            if (tahmin.ToLower() == olusanKelime.ToLower())
            {
                toplamPuan += kazanilacakPuan;
                MessageBox.Show("BİLDİNİZ. Toplam Puanınız : " + toplamPuan.ToString());
                if (yeniKelimeLevel >= 14)
                {
                    tmrKalanSure.Enabled = false;
                    //toplamPuan += kazanilacakPuan;
                    lblTopPuan.Text = "Toplam Puan : " + toplamPuan.ToString();
                    MessageBox.Show("Oyun bitmiştir. Toplam Puanınız : " + toplamPuan.ToString());

                    txtTahmin.Text = "";
                    btnHarfAl.Enabled = false;
                    btnTahmin.Enabled = false;
                    txtTahmin.Enabled = false;

                    eskiKelimeLevel = -1;
                    yeniKelimeLevel = 0;
                    return;
                }

                

                //toplamPuan += kazanilacakPuan;
                lblTopPuan.Text = "Toplam Puan : " + toplamPuan.ToString();
                yeniSoru();
                txtTahmin.Text = "";
                txtTahmin.Focus();

            }
            else
            {
                //kelime yanlış bilindi.
                MessageBox.Show("Kelimeyi yanlış bildiniz. Doğrusu : " + olusanKelime + " olucaktı. Kazanılan Puan : 0");
                txtTahmin.Text = "";
                if (yeniKelimeLevel >= 14) // yanlış bilerek biter ise
                {
                    tmrKalanSure.Enabled = false;
                    MessageBox.Show("Oyun bitmiştir. Toplam Puanınız : " + toplamPuan.ToString());
                    puanlar();
                    txtTahmin.Text = "";
                    btnHarfAl.Enabled = false;
                    btnTahmin.Enabled = false;
                    txtTahmin.Enabled = false;

                    eskiKelimeLevel = -1;
                    yeniKelimeLevel = 0;
                    return;
                }
                yeniSoru();
            }
        }

        private void tmrKalanSure_Tick(object sender, EventArgs e)
        {
            if (kalanSure == 0)
            {
                tmrKalanSure.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur. Diğer soruya yönlendiriliyorsunuz. Kazanılan puan : 0");
                yeniSoru();
                tmrKalanSure.Enabled = true;
            }
            else
            {
                kalanSure -= 1;
                lblKalanSure.Text = "Kalan Süre : " + kalanSure.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puanlar();
        }
    }
}
