using _19_HastaneOtomasyonu.Abstract;
using _19_HastaneOtomasyonu.Concrete;
using _19_HastaneOtomasyonu.Enum_s;

namespace _19_HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public static Hastane hastane;
        public Form1()
        {
            InitializeComponent();
            hastane = new Hastane()
            {
                HastaneAdi = "Bilge Adam",
                CalisanSayisi = 500,
                GunlukHastaSayisi = 1000,
                YatakliServisSayisi = 300,
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstvList.View = View.Details;
            lstvList.GridLines = true;
            lstvList.Columns.Add("Ad", 100);
            lstvList.Columns.Add("Soyad", 150);
            lstvList.Columns.Add("TCNo", 100);
            lstvList.Columns.Add("Maaþ", 100);
            lstvList.Columns.Add("Yaþ", 60);
            lstvList.Columns.Add("Cinsiyet", 80);
            lstvList.Columns.Add("Günlük Hasta Sayýsý", 80);
            lstvList.Columns.Add("Ünvan", 100);
            lstvList.Columns.Add("Aylýk Nöbet Sayýsý", 80);
            lstvList.Columns.Add("Uzmanlýk Alaný", 120);
            lstvList.Columns.Add("Döner Sermaye Parasý", 80);
            lstvList.Columns.Add("Birim", 80);



        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele frm = new Listele();
            frm.Show();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkle frm = new DoktorEkle();
            frm.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OrtopediDoktor ortopediDoktor = new OrtopediDoktor()
            {
                Ad = "Faruk",
                Soyad ="Akpýnar",
                Maas = 30000,
                Yas =35,
                GunlukHastaSayisi =30,
                Cinsiyet = Cinsiyet.Erkek,
                Unvan ="Doç",
                AylikNobetSayisi=2,
                UzmanlikAlani="Ortopedi",
                DonerSermayeParasi=26000,
                Tc="23245654",
                Birim = Birim.Ortopedi
            };
            hastane.Doktorlar.Add(ortopediDoktor);
            OrtopediDoktor ortopediDoktor2 = new OrtopediDoktor()
            {
                Ad = "Semih",
                Soyad = "Önol",
                Maas = 19000,
                Yas = 25,
                GunlukHastaSayisi = 40,
                Cinsiyet = Cinsiyet.Erkek,
                Unvan = "Uzman",
                AylikNobetSayisi = 7,
                UzmanlikAlani = "Ortopedi",
                DonerSermayeParasi = 10000,
                Tc = "56464642",
                Birim = Birim.Ortopedi

            };
            hastane.Doktorlar.Add(ortopediDoktor2);
            DoktorListele();
        }

        private void DoktorListele()
        {
            foreach (IDoktor item in hastane.Doktorlar)
            {
                ListViewItem lstitem = new ListViewItem();
                lstitem.Text =item.Ad;
                lstitem.SubItems.Add(item.Soyad);
                lstitem.SubItems.Add(item.Tc);
                lstitem.SubItems.Add(item.Maas.ToString());
                lstitem.SubItems.Add(item.Yas.ToString());
                lstitem.SubItems.Add(item.Cinsiyet.ToString());
                lstitem.SubItems.Add(item.GunlukHastaSayisi.ToString());
                lstitem.SubItems.Add(item.Unvan);
                lstitem.SubItems.Add(item.AylikNobetSayisi.ToString());
                lstitem.SubItems.Add(item.UzmanlikAlani);
                lstitem.SubItems.Add(item.DonerSermayeParasi.ToString());
                lstitem.SubItems.Add(item.Birim.ToString());



                lstvList.Items.Add(lstitem);
            }
            btnTest.Enabled = false;
            //Todo: Dosyaya Ekleme
            MessageBox.Show($"Hastane Adý : {hastane.HastaneAdi}, Günlük Baktýðý Hasta Sayýsý: {hastane.GunlukHastaSayisi}");
        }
    }
}
