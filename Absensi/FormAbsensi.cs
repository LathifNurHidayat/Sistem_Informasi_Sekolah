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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private readonly BindingList<SiswaDto> _siswaList = new();

        private int _absensiId = 0;
        private int[] _valueAbsen = {};

        public FormAbsensi()
        {
            InitializeComponent();
            _kelasDal = new KelasDal();
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            _kelasSiswaDetilDal = new KelasSiswaDetilDal();
            _absensiDetilDal = new AbsensiDetilDal();
            _absensiDal = new AbsensiDal();


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
            GridListPresensi.Columns["NoUrut"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            GridListPresensi.Columns["Keterangan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridListPresensi.Columns["SiswaName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            GridListPresensi.CellContentClick += GridListPresensi_CellContentClick;
        }

        private void GridListPresensi_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (GridListPresensi.Columns[e.ColumnIndex].Name == "Hadir" ||
                                   GridListPresensi.Columns[e.ColumnIndex].Name == "S" ||
                                   GridListPresensi.Columns[e.ColumnIndex].Name == "I" || 
                                   GridListPresensi.Columns[e.ColumnIndex].Name == "A"))
            {
                MessageBox.Show("hgsnvdc");
                string[] columnName = {"Hadir", "S", "I", "A"};
                foreach (var namaColumn in  columnName)
                {
                    if (GridListPresensi.Columns[e.ColumnIndex].Name != namaColumn)
                    {
                        GridListPresensi.Rows[e.RowIndex].Cells[namaColumn].Value = false;
                    }
                }
            }
            TotalStatusAbsen();
        }

        private void TotalStatusAbsen()
        {
            int Hadir = 0;
            int Sakit = 0;
            int Izin = 0;
            int Alpha = 0;

            foreach (var item in _siswaList)
            {
                if (item.Hadir ) Hadir++;
                if (item.S ) Sakit++;
                if (item.I ) Izin ++;
                if (item.A ) Alpha++;
            }

            TextTotalHadir.Text = Hadir.ToString();
            TextTotalSakit.Text = Sakit.ToString();
            TextTotalIzin.Text = Izin.ToString();
            TextTotalAlpha.Text = Alpha.ToString();
        }

        private void InitCombo()
        {
            var kelas = new List<KelasModel>
            {
                new KelasModel{KelasId = -1, KelasName = "--Pilih Kelas--"}
            };
            kelas.AddRange(_kelasDal.ListData()?.ToList() ?? new());
            ComboKelas.DataSource = kelas;
            ComboKelas.DisplayMember = "KelasName";
            ComboKelas.ValueMember = "KelasId";
            ComboKelas.SelectedIndex = 0;

            var Mapel = new List<MataPelajaranModel>
            {
                new MataPelajaranModel {MapelId = -1, MapelName = "--Pilih Mapel"}
            };
            Mapel.AddRange(_mataPelajaranDal.ListData()?.ToList() ?? new());
            ComboMataPelajaran.DataSource = Mapel;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";
            ComboMataPelajaran.SelectedIndex = 0;

            var guru = new List<GuruModel>
            {
                new GuruModel{GuruId = -1, GuruName = "--Pilih Guru--"}
            };
            guru.AddRange(_guruDal.ListData()?.ToList() ?? new());
            ComboGuru.DataSource = guru;
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
            ComboKelas.SelectedValueChanged += (s, e) => _siswaList.Clear();
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
                    .Select((x, index) => new SiswaDto
                    {
                        NoUrut = index + 1,
                        SiswaId = x.SiswaId,
                        SiswaName = x.SiswaName,
                        Hadir = false,
                        S = false,
                        I = false,
                        A = false,
                        Keterangan = ""
                    }).ToList();

                data.ForEach(item => _siswaList.Add(item));
                GridListPresensi.Refresh();
            }

            if (absensiId != 0)
            {
                var data = _absensiDetilDal.ListData(absensiId)
                    .Select(x => new SiswaDto
                    {
                        NoUrut = x.NoUrut,
                        SiswaId = x.SiswaId,
                        SiswaName = x.SiswaName,
                        Hadir = x.StatusAbsen == 1,
                        S = x.StatusAbsen == 2,
                        I = x.StatusAbsen == 3,
                        A = x.StatusAbsen == 4,
                        Keterangan = x.Keterangan
                    }).ToList();

                data.ForEach(item => _siswaList.Add(item));
                GridListPresensi.Refresh(); 
            }
            GridListPresensi.AllowUserToAddRows = false;
            GridListPresensi.DataSource = _siswaList;
            InitDataGrid();
            TotalStatusAbsen();
        }

        private void SaveData()
        {
            if (string.IsNullOrEmpty(TextJamKe.Text) || ComboKelas.SelectedIndex == 0 || ComboMataPelajaran.SelectedIndex == 0 || ComboGuru.SelectedIndex == 0 )
            {
                MessageBox.Show("!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

            _absensiDetilDal.Delete(_absensiId);

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
                        StatusAbsen = item.Hadir == true ? 1 
                                    : item.S == true ? 2 
                                    : item.I == true ? 3 
                                    : item.A == true ? 4 
                                    : 0,
                        Keterangan = item.Keterangan ?? "",
                    };
                    _absensiDetilDal.Insert(data);
                }
            }
            LoadData(0, _absensiId);
        }

        public class SiswaDto
        {
            public int NoUrut { get; set; }
            public int SiswaId { get; set; }
            public string SiswaName { get; set; }
            public bool Hadir { get; set; } = false;
            public bool S { get; set; } = false;
            public bool I { get; set; } = false;
            public bool A { get; set; } = false;
            public string Keterangan { get; set; }
        }
    }
}
