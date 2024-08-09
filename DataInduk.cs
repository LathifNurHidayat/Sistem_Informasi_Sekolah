namespace Sistem_Informasi_Sekolah
{
    public partial class DataInduk : Form
    {
        public DataInduk()
        {
            InitializeComponent();
            ComboBox();
            Agama();



        }

        public void Agama()
        {
            List<string> agama = new List<string>() { "Islam", "Katolik", "Kristen", "Hindu", "Budha", "Konghucu" };


            ComboAgama.DataSource = new List<string>(agama);
            ComboAgamaAyh.DataSource = new List<String>(agama);
            ComboAgamaIbu.DataSource = new List<String>(agama);
            ComboAgamaWali.DataSource = new List<String>(agama);
        }

        public void ComboBox()
        {

            ComboYatimPiatu.Items.Add("");
            ComboYatimPiatu.Items.Add("Yatim");
            ComboYatimPiatu.Items.Add("Piatu");
            ComboYatimPiatu.Items.Add("Yatim Piatu");

            ComboTinggal.Items.Add("Orang Tua");
            ComboTinggal.Items.Add("Saudara");
            ComboTinggal.Items.Add("Di Asrama");

            ComboGolDarah.Items.Add("A");
            ComboGolDarah.Items.Add("B");
            ComboGolDarah.Items.Add("AB");
            ComboGolDarah.Items.Add("O");
            ComboGolDarah.Items.Add("Tidak tahu");
        }




        private void TextThnMeningglAyah_TextChanged(object sender, EventArgs e)
        {
            if (RadioHidupAyah.Checked)
            {
                TextThnMeningglAyah.ReadOnly= true;
            }
            else
            {
                TextThnMeningglAyah.ReadOnly = false;
            }
        }


private void TextThnMeningglIbu_TextChanged(object sender, EventArgs e)
        {
            if (RadioHidupIbu.Checked)
{
                TextThnMeningglIbu.ReadOnly = true;
            }
            else
            {
                TextThnMeningglIbu.ReadOnly = false;
            }
        }

private void ButtonSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextNamaLengkap.Text))
            {
                TextNamaLengkap.BackColor = Color.Red;
                MessageBox.Show("Nama lengkap tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
    }
}