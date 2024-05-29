namespace _06_Kapsulleme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel = new Personel();
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                personel.TC = txtTc.Text;
                ListViewItem kayit = new ListViewItem();
                kayit.Text = personel.TC;
                kayit.SubItems.Add(personel.Ad);
                kayit.SubItems.Add(personel.Soyad);

                lstKayit.Items.Add(kayit);
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstKayit.SelectedItems.Count > 0)
            lstKayit.Items.Remove(lstKayit.SelectedItems[0]); 
        }
    }
}
