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

        public FormJadwalPelajaran()
        {
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            _jadwalPelajaranDal = new JadwalPelajaranDal();
            InitializeComponent();
            InitialCombo();
            LoadData();
            ControlEvent();
        }

        private void InitialCombo()
        {
            List<string> Hari = new List<string> { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            ComboHari.DataSource = Hari;

            var dataMapel = _mataPelajaranDal.ListData()
                .Select(x => new
                {
                    Nama = x.MapelName,
                    Id = x.MapelId,
                }).ToList();

            ComboMataPelajaran.DataSource = dataMapel;
            ComboMataPelajaran.DisplayMember = "Nama";
            ComboMataPelajaran.ValueMember = "Id";


            var dataGuru = _guruDal.ListData()
                .Select(x => new
                {
                    Nama = x.GuruName,
                    Id = x.GuruId,
                }).ToList();
            ComboGuru.DataSource = dataGuru;
            ComboGuru.DisplayMember = "Nama";
            ComboGuru.ValueMember = "Id";

        }

        private void LoadData()
        {

        }

        private void ControlEvent()
        {
            ButtonDialogKelas.Click += ButtonDialogKelas_Click;
            ButtonJadwalSave.Click += ButtonJadwalSave_Click;
            ButtonJadwalNew.Click += ButtonJadwalNew_Click;
            ButtonJadwalDelete.Click += ButtonJadwalDelete_Click;
        }

        private void ButtonJadwalDelete_Click(object? sender, EventArgs e)
        {
            
        }

        private void ButtonJadwalNew_Click(object? sender, EventArgs e)
        {
            
        }

        private void ButtonJadwalSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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


        private void SaveData()
        {
            var kelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);

            if (kelasId == 0)
            {
                MessageBox.Show("Masukan kelas terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int jenis = 0;
            if (RadioInputKhusus.Checked) jenis = 1;
            if (RadioInputUmum.Checked) jenis = 2;
            {
                
            }

            var jadwal = new JadwalPelajaranModel()
            {
                JadwalId = kelasId,
                KelasId = kelasId,
                JenisJadwal = jenis,
                Hari = ComboHari.SelectedItem.ToString(),
                JamMulai = PickerJamMulai.Value,
                JamSelesai = PickerJamSelesai.Value,
                MapelId = Convert.ToInt32(ComboMataPelajaran.SelectedValue),
                GuruId = Convert.ToInt32(ComboGuru.SelectedValue)
            };
        }


    }
}
