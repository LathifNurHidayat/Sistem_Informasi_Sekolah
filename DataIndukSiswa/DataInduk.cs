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
            ComboAgamaAyah.DataSource = new List<String>(agama);
            ComboAgamaIbu.DataSource = new List<String>(agama);
            ComboAgamaWali.DataSource = new List<String>(agama);
        }

        public void ComboBox()
        {

            List<string> YatimPiatu = new List<string>() {"Masih Hidup","Yatim","Piatu","Yatim Piatu"};
            ComboYatimPiatu.DataSource = new List<string>(YatimPiatu);

            List<string> TinggalDengan = new List<string>() { "Orang Tua", "Saudara", "Di Asrama" };
            ComboTinggal.DataSource = new List<string>(TinggalDengan);


        }




        private void TextThnMeningglAyah_TextChanged(object sender, EventArgs e)
        {
            if (RadioHidupAyah.Checked)
            {
                TextThnMeningglAyah.ReadOnly = true;
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

        private void DataInduk_Load(object sender, EventArgs e)
        {

        }
    }
}