using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Security.Policy;
using System.Windows.Forms;

namespace RandevuOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboxPoliklinik.Items.Add("Göz");
            cboxPoliklinik.Items.Add("Dahiliye");
            cboxPoliklinik.Items.Add("ortopedi");
        }
        List<HastaBilgileri> bilgiler = new List<HastaBilgileri>();
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                HastaBilgileri hastaBilgileri = new HastaBilgileri();
                hastaBilgileri.HastaTC = txtTc.Text;
                hastaBilgileri.AdSoyad = txtAdSoyad.Text;
                hastaBilgileri.Telefon = mtbTelefon.Text;
                hastaBilgileri.Cinsiyet = rbKadýn.Checked ? "kadýn" : "erkek";
                hastaBilgileri.Poliklinik = cboxPoliklinik.SelectedItem.ToString();
                hastaBilgileri.Tarih = dtTarih.Value;
                if (rb12.Checked) { hastaBilgileri.RandevuSaat = "12:00"; }
                else if (rb13.Checked) { hastaBilgileri.RandevuSaat = "13:00"; }
                else if (rb14.Checked) { hastaBilgileri.RandevuSaat = "14:00"; }
                else { hastaBilgileri.RandevuSaat = "15:00"; }
                
                bilgiler.Add(hastaBilgileri);
                ListBoxaEkle();
                ListeyiTemizle();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListBoxaEkle()
        {
            HastaBilgileri hastabilgileri = new HastaBilgileri();
            DialogResult dialogResult = MessageBox.Show("Gerçekten kaydetmek istiyor musunuz?", "Mesaj", MessageBoxButtons.OKCancel);
            lstRandevuKaydi.Items.Clear();
            foreach (HastaBilgileri hasta in bilgiler)
            {
                if (dialogResult == DialogResult.OK)
                {
                    lstRandevuKaydi.Items.Add($"{hasta.AdSoyad} - {hasta.Poliklinik} - {hasta.Tarih} - {hasta.RandevuSaat}");
                    MessageBox.Show("Kaydedildi", "", MessageBoxButtons.OK);
                }

            }
        }

        private void lstRandevuKaydi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstRandevuKaydi.SelectedIndex != -1)
            {
                int index = lstRandevuKaydi.SelectedIndex;
                HastaBilgileri hastaBilgileri = bilgiler[index];
                MessageBox.Show($"Ad Soyad : {hastaBilgileri.AdSoyad}\n" + $"TC : {hastaBilgileri.HastaTC}\n"+ $"Cinsiyet : {hastaBilgileri.Cinsiyet}\n");
            }
        }
        public void ListeyiTemizle()
        {
            txtTc.Clear();
            txtAdSoyad.Clear();
            mtbTelefon.Clear();
            rbErkek.Checked = false;
            rbKadýn.Checked = false;
            cboxPoliklinik.Text = " ";
            dtTarih.Value= DateTime.Now;
            rb12.Checked = false;
            rb13.Checked = false;
            rb14.Checked = false;
            rb15.Checked = false;




        }

    }
}