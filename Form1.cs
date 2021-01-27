/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Davud Samed Tombul
**				ÖĞRENCİ NUMARASI.......: B171210007
**              DERSİN ALINDIĞI GRUP...: 1D
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1D_B171210007_NDP_Odev3
{
    public partial class Form1 : Form
    {

        string metin = "Hesaplanacak işlemi giriniz...";
        public Form1()
        {
            InitializeComponent();

            HesapText.Text = metin; //HesaplaText adlı textbox'a 'metin' adlı değişken içerisindeki string değer atanıyor.

            AcceptButton = HesaplaButon; //Enter tuşuna basıldığında HesaplaButon adlı butonun çalışmasını sağlıyor.

            SonucText.Text = "SONUÇ"; //SonucText adlı textbox a Sonuç yazdırılıyor.

            HesaplaButon.Text = "Hesapla"; //HesaplaButon adlı butonun metnine Hesapla yazdırılıyor.

            BaslıkLabel.Text = "Hesap Programı"; //Başlık içi kullandığımız BaslıkLabel adlı labele Hesap Programı yazdırılıyor.

        }

        private void HesapText_Click(object sender, EventArgs e)//HesapText adlı işlemleri girdiğimiz textbox'a tıklayınca bu  fonksiyon çalışıyor.
        {
            HesapText.Text = "";//HesapText adlı textbox'un metni temizleniyor.
        }

        private void HesaplaButon_Click(object sender, EventArgs e)//HesaplaButon adlı butonumuza basıldığında bu fonksiyon çalışıp gerekli işlemler yapılıyor.
        {
            var hesaplama = new DataTable();
            string yazdir = HesapText.Text;
            string sonuc = Convert.ToString(hesaplama.Compute(yazdir.Trim(), null));//Hesaplamalar yapılıp forma yazdırmak için uygun veri tipine yani stringe çeviriliyor.
            SonucText.Text = sonuc; //SonucText adlı işlem sonucunun yazdığı textbox'a sonuc değişkenimizdeki değer atanıyor.
        }
    }
}
