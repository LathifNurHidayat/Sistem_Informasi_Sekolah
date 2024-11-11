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
    public partial class FormAbsensi : Form
    {
        private readonly KelasDal _kelasDal;
        private readonly MataPelajaranDal _mataPelajaranDal;
        private readonly GuruDal _guruDal;
        public FormAbsensi()
        {
            InitializeComponent();
            _kelasDal = new KelasDal();
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();   

            InitCombo();
        }

        private void InitCombo()
        {
            var kelas = _kelasDal.ListData();
            foreach (var item in kelas )
                ComboKelas.Items.Add( item );
            ComboKelas.SelectedIndex = 0;
            ComboKelas.ValueMember = "KelasId";
            ComboKelas.DisplayMember = "KelasName";

            var mapel = _mataPelajaranDal.ListData();
            foreach(var item in mapel)
                ComboMataPelajaran.Items.Add( item );
            ComboMataPelajaran.SelectedIndex = 0;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";

            var guru = _guruDal.ListData();
            foreach (var item in guru)
                ComboGuru.Items.Add( item );
            ComboGuru.SelectedIndex = 0;
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = " GuruId";
        }

    
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
