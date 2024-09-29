using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormJadwalPelajaran : Form
    {
        private readonly MataPelajaranDal _mataPelajaranDal;
        private readonly GuruDal _guruDal;

        public FormJadwalPelajaran()
        {
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            InitializeComponent();
        }

        private void InitialCombo()
        {
            List<string> Hari = new List<string> {"Senin", "Selasa", "Rabu", "Kamis", "Jumat"};

            ComboHari.DataSource = Hari;
        }
   
    }
}
