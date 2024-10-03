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
            ComboGuru.DisplayMember = "Nama";
            ComboGuru.ValueMember = "Id";
        }

        private void InitialMaskText()
        {
            MaskedJamMulai.Mask = "00:00";
            MaskedJamMulai.Font = new Font("Segoe UI", 9);

            MaskedSelesai.Mask = "00:00";
            MaskedSelesai.Font = new Font("Segoe UI", 9);
        }

        private void LoadDataUmum()
        {
            int KelasId = Convert.ToInt32(TextKelasId.Text);
            var listData = _jadwalPelajaranDal.ListData(KelasId) ?? new List<JadwalPelajaranModel>();

            var listUmum = listData
                .Where(x => x.JenisJadwal == "Umum")
                .OrderBy(x => x.Hari)
                .ThenBy(x => x.JamMulai)
                .Select(x => new JadwalDto
                {
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai} - {x.JamSelesai}",
                    MataPelajaran = $"{x.MapelName} {x.Keterangan}",
                    Guru = x.GuruName
                }).ToList();

            GridListJadwalPelajaran.DataSource = listUmum;
        }

        private void LoadDataKhusus()
        {
            int KelasId = Convert.ToInt32(TextKelasId.Text);
            var listData = _jadwalPelajaranDal.ListData(KelasId) ?? new List<JadwalPelajaranModel>();

            var listKhusus = listData
                .Where(x => x.JenisJadwal == "Khusus")
                .OrderBy(x => x.Hari)
                .ThenBy(x => x.JamMulai)
                .Select(x => new JadwalDto
                {
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai} - {x.JamSelesai}",
                    MataPelajaran = $"{x.MapelName} {x.Keterangan}",
                    Guru = x.GuruName
                }).ToList();

            GridListJadwalPelajaran.DataSource = listKhusus;
        }


        #region EVENT
        private void ControlEvent()
        {
            ButtonDialogKelas.Click += ButtonDialogKelas_Click;
            ButtonJadwalSave.Click += ButtonJadwalSave_Click;
            ButtonJadwalNew.Click += ButtonJadwalNew_Click;
            ButtonJadwalDelete.Click += ButtonJadwalDelete_Click;

            GridListJadwalPelajaran.RowEnter += GridListJadwalPelajaran_RowEnter;
        }

        private void GridListJadwalPelajaran_RowEnter(object? sender, DataGridViewCellEventArgs e)
        {
            var getJadwalId = (JadwalPelajaranModel)GridListJadwalPelajaran.CurrentRow.DataBoundItem;
            int jadwalId = Convert.ToInt32(getJadwalId.JadwalId);

            GetData(jadwalId);
        }

        private void ButtonJadwalDelete_Click(object? sender, EventArgs e)
        {
            
        }

        private void ButtonJadwalNew_Click(object? sender, EventArgs e)
        {
            
        }

        private void ButtonJadwalSave_Click(object? sender, EventArgs e)
        {

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

        }

        private void ClearAfterSave()
        {
            MaskedJamMulai.Mask = "00:00";
            MaskedSelesai.Mask = "00:00";

            ComboMataPelajaran.SelectedIndex = 0;
            ComboGuru.SelectedIndex = 0;

            TextKeterangan.Clear();
        }

        private void GetData(int JadwalId)
        {
            if (JadwalId == 0)
                return;

            var jadwal = _jadwalPelajaranDal.GetData(JadwalId);

            if (jadwal.JenisJadwal == "Umum") RadioUmum.Checked = true;
            if (jadwal.JenisJadwal == "Khusus") RadioKhusus.Checked = true;
            ComboHari.Text = jadwal.Hari;
            MaskedJamMulai.Text = jadwal.JamMulai;
            MaskedSelesai.Text = jadwal.JamSelesai;
            ComboMataPelajaran.SelectedValue = jadwal.MapelId;
            ComboGuru.SelectedValue = jadwal.GuruId;
            TextKeterangan.Text = jadwal.Keterangan;
        }


        private class JadwalDto
        {
            public string Hari { get; set; }
            public string Waktu { get; set; }
            public string MataPelajaran { get; set; }
            public string Guru { get; set; }
        }


    }
}
