using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        private readonly JadwalPelajaranDal _jadwalPelajaranDal;
        private int _jadwalId = 0;

        public FormJadwalPelajaran()
        {
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            _jadwalPelajaranDal = new JadwalPelajaranDal();

            InitializeComponent();
            InitialCombo();
            InitialMaskText();

            ControlEvent();
        }

        #region INITIAL FORM
        private void InitialCombo()
        {   
            List<string> Hari = new () { "--Pilih Hari--","Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            ComboHari.DataSource = Hari;
            ComboHari.SelectedIndex = 0;


            var dataMapel = new List<MataPelajaranModel>
            {
                new MataPelajaranModel {MapelId = -1, MapelName = "--Pilih Mata Pelajaran--"}
            };
            dataMapel.AddRange(_mataPelajaranDal.ListData()?.ToList() ?? new List<MataPelajaranModel>() );
            ComboMataPelajaran.Items.Clear();
            ComboMataPelajaran.DataSource = dataMapel;
            ComboMataPelajaran.SelectedIndex = 0;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";


            var dataGuru = new List<GuruModel>
            {
                new GuruModel {GuruId = -1 , GuruName = "--Pilih Guru--"}
            };
            dataGuru.AddRange(_guruDal.ListData()?.ToList() ?? new List<GuruModel>());
            ComboGuru.Items.Clear();
            ComboGuru.DataSource = dataGuru;
            ComboGuru.SelectedIndex = 0;
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = "GuruId";
        }

        private void InitialMaskText()
        {
            MaskedJamMulai.Mask = "00:00";
            MaskedJamMulai.Font = new Font("Segoe UI", 11);
            MaskedJamMulai.TextAlign = HorizontalAlignment.Center;

            MaskedSelesai.Mask = "00:00";
            MaskedSelesai.Font = new Font("Segoe UI", 11);
            MaskedSelesai.TextAlign = HorizontalAlignment.Center;
        }

        private void LoadDataUmum()
        {
            int KelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);
            if (KelasId == 0)
                return;

            var listData = _jadwalPelajaranDal.ListData(KelasId) ?? new List<JadwalPelajaranModel>();

            var listUmum = listData
                .Where(x => x.JenisJadwal == "Umum")
                .Select(x => new JadwalDto
                {
                    JadwalId = x.JadwalId,
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai} - {x.JamSelesai}",
                    MataPelajaran = $"{x.MapelName} {x.Keterangan}",
                    Guru = x.GuruName
                }).ToList();

            GridListJadwalPelajaran.DataSource = listUmum;
            GridListJadwalPelajaran.Columns["JadwalId"].Visible = false;
            GridListJadwalPelajaran.ReadOnly = true;
        }

        private void LoadDataKhusus()
        {
            int KelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);
            if (KelasId == 0)
                return;

            var listData = _jadwalPelajaranDal.ListData(KelasId) ?? new List<JadwalPelajaranModel>();

            var listKhusus = listData
                .Where(x => x.JenisJadwal == "Khusus")                
                .Select(x => new JadwalDto
                {
                    JadwalId = x.JadwalId,
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai} - {x.JamSelesai}",
                    MataPelajaran = $"{x.MapelName} {x.Keterangan}",
                    Guru = x.GuruName
                }).ToList();

            GridListJadwalPelajaran.DataSource = listKhusus;
            GridListJadwalPelajaran.Columns["JadwalId"].Visible = false;
            GridListJadwalPelajaran.ReadOnly = true;
        }
        #endregion


        #region EVENT
        private void ControlEvent()
        {
            ButtonDialogKelas.Click += ButtonDialogKelas_Click;
            ButtonJadwalSave.Click += ButtonJadwalSave_Click;
            ButtonJadwalNew.Click += ButtonJadwalNew_Click;
            ButtonJadwalDelete.Click += ButtonJadwalDelete_Click;

            GridListJadwalPelajaran.SelectionChanged += GridListJadwalPelajaran_SelectionChanged;
            TextKelasId.TextChanged += TextKelasId_TextChanged;
            RadioListUmum.CheckedChanged += RadioListUmum_CheckedChanged;
            RadioListKhusus.CheckedChanged += RadioListKhusus_CheckedChanged;
        }

        private void GridListJadwalPelajaran_SelectionChanged(object? sender, EventArgs e)
        {
            if (GridListJadwalPelajaran.CurrentRow != null)
            {
                var jadwalId = Convert.ToInt32(GridListJadwalPelajaran.CurrentRow.Cells["JadwalId"].Value);
                _jadwalId = jadwalId;

                GetData(_jadwalId);
            }
        }

        private void RadioListKhusus_CheckedChanged(object? sender, EventArgs e)
        {
            LoadDataKhusus();
            ClearForm();
        }

        private void RadioListUmum_CheckedChanged(object? sender, EventArgs e)
        {
            LoadDataUmum();
            ClearForm();
        }

        private void TextKelasId_TextChanged(object? sender, EventArgs e)
        {
            LoadDataUmum();
            RadioListUmum.Checked = true;
        }

        private void ButtonJadwalDelete_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus data ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                _jadwalPelajaranDal.Delete(_jadwalId);

                if (RadioListKhusus.Checked)
                    LoadDataKhusus();
                else if (RadioListUmum.Checked)
                    LoadDataUmum();
            }
           
        }

        private void ButtonJadwalNew_Click(object? sender, EventArgs e)
        {
            ClearForm();   
        }

        private void ButtonJadwalSave_Click(object? sender, EventArgs e)
        {
            if (RadioUmum.Checked)
            {
                SaveData();
                LoadDataUmum();
                RadioListUmum.Checked = true;
            }
            else
            {
                SaveData();
                LoadDataKhusus();
                RadioListKhusus.Checked = true;
            }

            ClearForm();
        }

        private void ButtonDialogKelas_Click(object? sender, EventArgs e)
        {
            using var formKelas = new FormKelasDialog();

            if (formKelas.ShowDialog() == DialogResult.OK)
            {
                TextKelasId.Text = formKelas.KelasId.ToString() ?? string.Empty;
                TextKelasName.Text = formKelas.KelasName?.ToString() ?? string.Empty;
            }
        }


        #endregion 


        private void SaveData()
        {
            var kelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);
            if (kelasId == 0)
            {
                MessageBox.Show("Masukan kelas terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string JamMulai, JamSelesai;
            int Jenis, Hari, Mapel, Guru;

            Jenis = RadioKhusus.Checked ? 1 : RadioUmum.Checked ? 1 : 0;
            Hari = ComboHari.SelectedIndex;
            JamMulai = MaskedJamMulai.Text;
            JamSelesai = MaskedSelesai.Text;
            Mapel = ComboMataPelajaran.SelectedIndex;
            Guru = ComboGuru.SelectedIndex;

            if (Jenis == 0 || Hari == 0 || JamMulai == string.Empty || JamSelesai == string.Empty||  Mapel == 0 || Guru == 0 )
            {
                MessageBox.Show("Mohon lengkapi data!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var jenisJadwal = string.Empty;
            if (RadioUmum.Checked) jenisJadwal = RadioUmum.Text;
            if (RadioKhusus.Checked) jenisJadwal = RadioKhusus.Text;

            var jadwal = new JadwalPelajaranModel
            {
                JadwalId = _jadwalId,
                KelasId = kelasId,
                JenisJadwal = jenisJadwal,
                Hari = ComboHari.Text,
                JamMulai = MaskedJamMulai.Text,
                JamSelesai = MaskedSelesai.Text,
                MapelId = Convert.ToInt32(ComboMataPelajaran.SelectedValue),
                GuruId = Convert.ToInt32(ComboGuru.SelectedValue),
                Keterangan = TextKeterangan.Text,
            };

            if (_jadwalId == 0)
            {
                _jadwalPelajaranDal.Insert(jadwal);
            }
            else
                _jadwalPelajaranDal.Update(jadwal);
            return;
        }

        private void ClearForm()
        {
            RadioKhusus.Checked = false;
            RadioUmum.Checked = false;

            MaskedJamMulai.Clear();
            MaskedSelesai.Clear();

            ComboHari.SelectedIndex = 0; 
            ComboMataPelajaran.SelectedIndex = 0;
            ComboGuru.SelectedIndex = 0;

            TextKeterangan.Clear();
            _jadwalId = 0;
        }

        private void GetData(int JadwalId)
        {
            if (JadwalId == 0)
                return;

            var jadwal = _jadwalPelajaranDal.GetData(JadwalId);

            if (jadwal != null)
            {
                if (jadwal.JenisJadwal == "Umum")
                    RadioUmum.Checked = true;
                if (jadwal.JenisJadwal == "Khusus")
                    RadioKhusus.Checked = true;


                ComboHari.Text = jadwal.Hari;
                MaskedJamMulai.Text = jadwal.JamMulai;
                MaskedSelesai.Text = jadwal.JamSelesai;
                ComboMataPelajaran.SelectedValue = jadwal.MapelId;
                ComboGuru.SelectedValue = jadwal.GuruId;
                TextKeterangan.Text = jadwal.Keterangan;
            }
            else
            {
                RadioKhusus.Checked = false;
                RadioUmum.Checked = false;
            }
        }


        private class JadwalDto
        {
            public int JadwalId {  get; set; }
            public string Hari { get; set; }
            public string Waktu { get; set; }
            public string MataPelajaran { get; set; }
            public string Guru { get; set; }
        }
    }
}
