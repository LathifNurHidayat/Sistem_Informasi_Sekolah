using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormAbsensi : Form
    {
        private readonly KelasDal _kelasDal;
        private readonly MataPelajaranDal _mataPelajaranDal;
        private readonly GuruDal _guruDal;
        private readonly KelasSiswaDetilDal _kelasSiswaDetilDal;
        private readonly AbsensiDetilDal _absensiDetilDal;
        private readonly AbsensiDal _absensiDal;
        private int _absensiId = 0;
        private readonly BindingList<SiswaDto> _siswaList = new();
        private readonly BindingSource bindingSource = new BindingSource();

        public FormAbsensi()
        {
            InitializeComponent();
            _kelasDal = new KelasDal();
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            _kelasSiswaDetilDal = new KelasSiswaDetilDal();
            _absensiDetilDal = new AbsensiDetilDal();
            _absensiDal = new AbsensiDal();
            bindingSource.DataSource = _siswaList;

            InitCombo();
            ControlEvent();
        }

        private void AddCheckBoxColumn(string headerText, string name, DataGridViewAutoSizeColumnMode autoSizeMode, int index)
        {
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = headerText,
                Name = name,
                AutoSizeMode = autoSizeMode
            };
            GridListPresensi.Columns.Insert(index, checkBoxColumn);
        }

        private void InitDataGrid()
        {
            GridListPresensi.Columns["SiswaId"].Visible = false;
            GridListPresensi.Columns["SiswaId"].ReadOnly = true;
            GridListPresensi.Columns["SiswaName"].HeaderText = "Nama Siswa";
            GridListPresensi.Columns["SiswaName"].ReadOnly = true;

            AddCheckBoxColumn("Hadir", "CekHadir", DataGridViewAutoSizeColumnMode.ColumnHeader, 3);
            AddCheckBoxColumn("S", "CekSakit", DataGridViewAutoSizeColumnMode.AllCells, 4);
            AddCheckBoxColumn("I", "CekIzin", DataGridViewAutoSizeColumnMode.AllCells, 5);
            AddCheckBoxColumn("A", "CekAlpha", DataGridViewAutoSizeColumnMode.AllCells, 6);
        }

        private void InitCombo()
        {
            ComboKelas.DataSource = _kelasDal.ListData();
            ComboKelas.DisplayMember = "KelasName";
            ComboKelas.ValueMember = "KelasId";
            ComboKelas.SelectedIndex = 0;

            ComboMataPelajaran.DataSource = _mataPelajaranDal.ListData();
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";
            ComboMataPelajaran.SelectedIndex = 0;

            ComboGuru.DataSource = _guruDal.ListData();
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = "GuruId";
            ComboGuru.SelectedIndex = 0;
        }

        private void ClearData()
        {
            PickerTanggal.Value = DateTime.Today;
            TextJamKe.Clear();
            ComboKelas.SelectedIndex = 0;
            ComboMataPelajaran.SelectedIndex = 0;
            ComboGuru.SelectedIndex = 0;
        }

        private void ControlEvent()
        {
            ButtonNew.Click += ButtonNew_Click;
            ButtonListSiswa.Click += ButtonListSiswa_Click;
            ButtonSave.Click += ButtonSave_Click; ;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ButtonListSiswa_Click(object sender, EventArgs e)
        {
            var absen = new AbsensiModel
            {
                KelasId = (int)ComboKelas.SelectedValue,
                Tanggal = PickerTanggal.Value,
                Jam = TextJamKe.Text,
                MapelId = (int)ComboMataPelajaran.SelectedValue,
                GuruId = (int)ComboGuru.SelectedValue
            };
            _absensiId = _absensiDal.GetAbsensiId(absen);

            if (_absensiId != 0)
                LoadData(0, _absensiId);
            else
                LoadData((int)ComboKelas.SelectedValue, 0);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void LoadData(int kelasId, int absensiId)
        {
            _siswaList.Clear();

            if (kelasId != 0)
            {
                var data = _kelasSiswaDetilDal.ListDataPerKelas(kelasId)
                    .Select(x => new SiswaDto(x.SiswaId, x.SiswaName))
                    .ToList();

                data.ForEach(item => _siswaList.Add(item));
                GridListPresensi.Refresh();
            }

            if (absensiId != 0)
            {
                var data = _absensiDetilDal.ListData(absensiId)
                    .Select((x, index) => new SiswaDto(index + 1, x.SiswaId, x.SiswaName, ""))
                    .ToList();

                data.ForEach(item => _siswaList.Add(item));
                GridListPresensi.Refresh();
            }
            GridListPresensi.DataSource = bindingSource;
            InitDataGrid();
        }

        private void SaveData()
        {
            if (_absensiId == 0)
            {
                var data = new AbsensiModel
                {
                    KelasId = (int)ComboKelas.SelectedValue,
                    Tanggal = PickerTanggal.Value,
                    Jam = TextJamKe.Text,
                    MapelId = (int)ComboMataPelajaran.SelectedValue,
                    GuruId = (int)ComboGuru.SelectedValue
                };
                _absensiId = _absensiDal.Insert(data);
            }

            int statusAbsen = 0;


            foreach (var item in _siswaList)
            {
                if (item != null)
                {
                    var data = new AbsensiDetilModel
                    {
                        AbsensiId = _absensiId,
                        NoUrut = item.NoUrut,
                        SiswaId = item.SiswaId,
                        SiswaName = item.SiswaName,
                        StatusAbsen = 1,
                        Keterangan = item.Keterangan,
                    };
                    _absensiDetilDal.Insert(data);
                }
            }
        }

        public class SiswaDto
        {
            public SiswaDto(int id, string nama) => (SiswaId, SiswaName) = (id, nama);
            public SiswaDto(int urut, int id, string nama, string ket) => (NoUrut, SiswaId, SiswaName, Keterangan) = (urut, id, nama, ket);

            public int NoUrut { get; set; }
            public int SiswaId { get; set; }
            public string SiswaName { get; set; }
            public string Keterangan { get; set; }
        }
    }
}
