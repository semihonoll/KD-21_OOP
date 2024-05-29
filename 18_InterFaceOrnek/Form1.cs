namespace _18_InterFaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DikdortgenKutu> dlist = new List<DikdortgenKutu>();
        List<KupKutu> klist = new List<KupKutu>();
        private void btnKup_Click(object sender, EventArgs e)
        {
            //KupKutu kupKutu = new KupKutu()
            //{

            //};
            //klist.Add(kupKutu);
            klist.Clear();
            klist.AddRange(new List<KupKutu>()
            {
                new KupKutu()
                {
                    id=1,
                    UrunAd="Mukavva Karton",
                    Yukseklik=15
                },
                new KupKutu()
                {
                    id = 2,
                    UrunAd="Karton Karton",
                    Yukseklik=10
                },
                new KupKutu()
                {
                    id = 3,
                    UrunAd = "Tahta Karton",
                    Yukseklik = 15
                }
            });
            dataGridView1.DataSource = klist;
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            dlist.Clear();
            DikdortgenKutu dikdortgenKutu = new DikdortgenKutu()
            {
                id = 1,
                UrunAd = "Kutu",
                UzunKenar = 12,
                KýsaKenar = 5,
                Yukseklik = 7
            };
            dlist.Add(dikdortgenKutu);
            DikdortgenKutu dikdortgenKutu2 = new DikdortgenKutu()
            {
                id = 1,
                UrunAd = "Kutu",
                UzunKenar = 12,
                KýsaKenar = 5,
                Yukseklik = 7
            };
            dlist.Add(dikdortgenKutu2);
            dataGridView1.DataSource = dlist;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGridView1.CurrentRow.DataBoundItem is KupKutu)
            {
                KupKutu k = (KupKutu)
                    dataGridView1.CurrentRow.DataBoundItem;
               int hacim = k.Hacim();
                MessageBox.Show($"Küp Kutunun hacmi{hacim}");
            }
            else
            {
                DikdortgenKutu d = dataGridView1.CurrentRow.DataBoundItem as DikdortgenKutu;
                MessageBox.Show(d.Hacim().ToString());
            }
        }
    }
}
