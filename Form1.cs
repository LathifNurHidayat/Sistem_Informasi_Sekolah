namespace Sistem_Informasi_Sekolah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBox();
            Agama();

        }

        public void Agama()
        {
            List<string> agama = new List<string>() { "Islam", "Katolik", "Kristen", "Hindu", "Budha", "Konghucu" };


            AgamaCombo.DataSource = new List<string>(agama);
            AgamaAyhCombo.DataSource = new List<String>(agama);
            AgamaIbuCombo.DataSource = new List<String>(agama);
            AgamaWaliCombo.DataSource = new List<String>(agama);
        }

        public void ComboBox()
        {

            YatimPiatuCombo.Items.Add("");
            YatimPiatuCombo.Items.Add("Yatim");
            YatimPiatuCombo.Items.Add("Piatu");
            YatimPiatuCombo.Items.Add("Yatim Piatu");

            TinggalCombo.Items.Add("Orang Tua");
            TinggalCombo.Items.Add("Saudara");
            TinggalCombo.Items.Add("Di Asrama");

            GolDarahCombo.Items.Add("A");
            GolDarahCombo.Items.Add("B");
            GolDarahCombo.Items.Add("AB");
            GolDarahCombo.Items.Add("O");
            GolDarahCombo.Items.Add("Tidak tahu");
        }

      


        private void HidupAyahRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (HidupAyahRadio.Checked)
            {
                ThnMeningglAyahText.ReadOnly = true;
            }
            else
            {
                ThnMeningglAyahText.ReadOnly = false;
            }
        }

        private void HidupIbuRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (HidupIbuRadio.Checked)
            {
                ThnMeningglIbuText.ReadOnly = true;
            }
            else
            {
                ThnMeningglIbuText.ReadOnly = false;
            }
        }

      
 

        private void ButtonSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NamaLengkapText.Text))
            {
                NamaLengkapText.BackColor = Color.Red;
                MessageBox.Show("Nama lengkap tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }
        }

        private void NamaLengkapText_Click(object sender, EventArgs e)
        {
            NamaLengkapText.BackColor = SystemColors.Window;
        }
    }
}