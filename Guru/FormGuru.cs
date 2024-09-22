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

        private readonly BindingSource _listMapelBinding;
        private readonly BindingList<MataPelajaranDto> _mataPelajaranDto;

        public FormGuru()
        {
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mataPelajaranDal = new MataPelajaranDal();
            

            _mataPelajaranDto = new BindingList<MataPelajaranDto>();
            _listMapelBinding = new BindingSource()
            {
                DataSource = _mataPelajaranDto
            };


            InitializeComponent();
            InitialGrid();
            InitialCombo();
            RefreshData();
        }

        private void InitialGrid()
        {
            GridListGuruMapel.DataSource = _listMapelBinding;

            GridListGuruMapel.Columns["Id"].Width = 40;
            GridListGuruMapel.Columns["MataPelajaran"].Width = 200;
        }

        private void InitialCombo()
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

        private void RefreshData()
        {
            var listGuru = _guruDal.ListData() ?? new List<GuruModel>();

            var dataSource = listGuru
                .Select(x => new GuruDto
                {
                    Id = x.GuruId,
                    Nama = x.GuruName,
                    Pendidikan = $"{x.TingkatPendidikan} - {x.JurusanPendidikan}"
                })
                .ToList();

            GridListGuru.DataSource = dataSource;
            GridListGuru.Refresh();
        }

        private void  ClearInput()
        {
            TextGuruId.Clear();
            TextGuruNama.Clear();
            PickerTglLahirGuru.Value = new DateTime(2000-01-01);
            ComboTingkatPendidikan.SelectedIndex = 0;
            TextInstansiPendidikan.Clear();
            TextJurusanPendidikan.Clear();
            TextTahunLulus.Clear();
            TextKota.Clear();
            TextInstansiPendidikan.Clear();

            _listMapelBinding.Clear();
        }






        public class GuruDto
        {
            public int Id {  get; set; }
            public string Nama { get; set; }
            public string Pendidikan { get; set; }
        }

        public class MataPelajaranDto
        {
            public int Id {  get; set; }
            public string MataPelajaran { get; set; }
        }
    }
}
