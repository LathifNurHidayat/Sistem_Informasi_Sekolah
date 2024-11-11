﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private readonly KelasSiswaDetilDal _kelasSiswaDetilDal;
        private readonly AbsensiDetilDal _absensiDetilDal;
        private readonly AbsensiDal _absensiDal;

        private readonly BindingList<SiswaDto> _siswaList = new BindingList<SiswaDto>();
        public FormAbsensi()
        {
            InitializeComponent();
            _kelasDal = new KelasDal();
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();   
            _kelasSiswaDetilDal = new KelasSiswaDetilDal();
            _absensiDetilDal = new AbsensiDetilDal();
            _absensiDal = new AbsensiDal();

            GridListPresensi.DataSource = _siswaList;

            InitCombo();
            ControlEvent();
        }

        private void LoadData(int kelasId, int AbsensiId)
        {
            if (kelasId != 0)
            {
                var data = _kelasSiswaDetilDal.ListDataPerKelas(kelasId).Select(x => new SiswaDto( x.SiswaId, x.SiswaName))?.ToList() ?? new();

                _siswaList.Clear();
                foreach (var item in data)
                    _siswaList.Add(item);

                GridListPresensi.Refresh();
            }
            if (AbsensiId != 0)
            {
                var data = _absensiDetilDal.ListData(AbsensiId).Select(x => new SiswaDto(x.NoUrut, x.SiswaId, x.SiswaName, x.Keterangan))? .ToList() ?? new List<SiswaDto>();
            }
         
            InitDataGrid();  
        }

        private void InitDataGrid()
        {
            GridListPresensi.Columns["SiswaId"].Visible = false;
            GridListPresensi.Columns["SiswaId"].ReadOnly = true;
            GridListPresensi.Columns["SiswaName"].HeaderText = "Nama Siswa";
            GridListPresensi.Columns["SiswaName"].ReadOnly = true;

            DataGridViewCheckBoxColumn CheckHadir = new DataGridViewCheckBoxColumn();
            CheckHadir.HeaderText = "Hadir";
            CheckHadir.Name = "CekHadir";
            CheckHadir.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            GridListPresensi.Columns.Insert(3, CheckHadir);

            DataGridViewCheckBoxColumn CheckSakit = new DataGridViewCheckBoxColumn();
            CheckSakit.HeaderText = "S";
            CheckSakit.Name = "CekSakit";
            CheckSakit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridListPresensi.Columns.Insert(4, CheckSakit);

            DataGridViewCheckBoxColumn CheckIzin = new DataGridViewCheckBoxColumn();
            CheckIzin.HeaderText = "I";
            CheckIzin.Name = "CekIzin";
            CheckIzin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridListPresensi.Columns.Insert(5, CheckIzin);

            DataGridViewCheckBoxColumn CheckAlpha = new DataGridViewCheckBoxColumn();
            CheckAlpha.HeaderText = "A";
            CheckAlpha.Name = "CekAlpha";
            CheckAlpha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GridListPresensi.Columns.Insert(6, CheckAlpha);

        }

        private void InitCombo()
        {
            var kelas = _kelasDal.ListData();
            ComboKelas.DataSource = kelas;
            ComboKelas.SelectedIndex = 0;
            ComboKelas.DisplayMember = "KelasName";
            ComboKelas.ValueMember = "KelasId";

            var mapel = _mataPelajaranDal.ListData();
            ComboMataPelajaran.DataSource = mapel;
            ComboMataPelajaran.SelectedIndex = 0;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";

            var guru = _guruDal.ListData();
            ComboGuru.DataSource = guru;
            ComboGuru.SelectedIndex = 0;
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = "GuruId";
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
            ButtonSave.Click += ButtonSave_Click;
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonListSiswa_Click(object? sender, EventArgs e)
        {
            var absen = new AbsensiModel
            {
                KelasId = (int)ComboKelas.SelectedValue,
                Tanggal = PickerTanggal.Value,
                Jam = TextJamKe.Text,
                MapelId = (int)ComboMataPelajaran.SelectedValue,
                GuruId = (int)ComboGuru.SelectedValue
            };
            var absensiId = _absensiDal.GetAbsensiId(absen);
            MessageBox.Show(PickerTanggal.Value.ToString());
            if (absensiId != null)
            {
                LoadData(0, Convert.ToInt32(absensiId));
            }
            var kelasId = (int)ComboKelas.SelectedValue;
            LoadData(kelasId, 0);
        }

        private void ButtonNew_Click(object? sender, EventArgs e)
        {
            ClearData();
        }

        public class SiswaDto
        {
            public SiswaDto(int id, string nama) => (SiswaId, SiswaName ) = (id, nama);
            public SiswaDto(int Urut, int id, string nama, string Ket ) => (NoUrut, SiswaId, SiswaName, Keterangan) = (Urut, id, nama, Ket);
            public int NoUrut { get; set; }
            public int SiswaId { get; set; }
            public string SiswaName { get; set; }
            public string Keterangan { get; set; }
        }
    }
}
