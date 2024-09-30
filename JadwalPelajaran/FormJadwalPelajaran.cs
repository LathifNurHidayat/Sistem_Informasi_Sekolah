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
            ControlEvent();
        }

        private void InitialCombo()
        {
            List<string> Hari = new List<string> { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            ComboHari.DataSource = Hari;

            var dataMapel = _mataPelajaranDal.ListData()
                .Select(x => new MataPelajaranModel
                {
                    MapelName = x.MapelName
                }).ToList();

            ComboMataPelajaran.DataSource = dataMapel;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";


            var dataGuru = _guruDal.ListData()
                .Select(x => new GuruModel
                {
                    GuruName = x.GuruName
                }).ToList();

            ComboGuru.DataSource = dataGuru;
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = "GuruId";

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
            throw new NotImplementedException();
        }

        private void ButtonJadwalNew_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        }


    }
}
