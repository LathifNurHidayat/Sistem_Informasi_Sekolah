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
    public partial class FormGuru : Form
    {
        private readonly GuruDal _guruDal;
        private readonly GuruMapelDal _guruMapelDal;
        private readonly MataPelajaranDal _mataPelajaranDal;

        public FormGuru()
        {
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mataPelajaranDal = new MataPelajaranDal();

            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            ComboTingkatPendidikan.Items.Clear();
            ComboTingkatPendidikan.Items.Add("-");
            ComboTingkatPendidikan.Items.Add("D3");
            ComboTingkatPendidikan.Items.Add("S1");
            ComboTingkatPendidikan.Items.Add("S2");
            ComboTingkatPendidikan.Items.Add("S3");

            ComboTingkatPendidikan.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTingkatPendidikan.SelectedIndex = 0;
        }










        public class GuruDto
        {
            public int Id {  get; set; }
            public string Nama { get; set; }
            public string Pendidikan { get; set; }
        }

        public class MapelDto
        {
            public int Id {  get; set; }
            public string MataPelajaran { get; set; }
        }
    }
}
