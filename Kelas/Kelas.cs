using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class Kelas : Form
    {
        private readonly JurusanDal _jurusanDal;
        private readonly KelasDal _kelasDal;
        private readonly MesBoxHelper _mesBoxHelper;
        public Kelas()
        {
            _jurusanDal = new JurusanDal();
            _kelasDal = new KelasDal();
            _mesBoxHelper = new MesBoxHelper();

            InitializeComponent();

            LoadData();
            InitEvent();
            InitCombo();
        }

        private void InitCombo()
        {
            var jurusan = _jurusanDal.ListData();
            ComboKelasJurusan.DataSource = jurusan;

            ComboKelasJurusan.DisplayMember = "JurusanName";
            ComboKelasJurusan.ValueMember = "JurusanId";
        }


        #region EVENT
        private void InitEvent()
        {
            ButtonKelasSave.Click += ButtonKelasSave_Click;
            ButtonKelasNew.Click += ButtonKelasNew_Click;
            ButtonKelasDelete.Click += ButtonKelasDelete_Click;
            GridListKelas.SelectionChanged += GridListKelas_SelectionChanged;
            ComboKelasJurusan.SelectedIndexChanged += ComboKelasJurusan_SelectedIndexChanged;
            TextFlagKelas.Validated += TextFlagKelas_Validated;

            RadioKelas_10.Click += RadioKelas_Click;
            RadioKelas_11.Click += RadioKelas_Click;
            RadioKelas_12.Click += RadioKelas_Click;



        }

        private void TextFlagKelas_Validated(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void RadioKelas_Click(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void ComboKelasJurusan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SetKelasName();
        }

        private void GridListKelas_SelectionChanged(object? sender, EventArgs e)
        {
            var kelasId = Convert.ToInt32(GridListKelas.CurrentRow.Cells[0].Value);
            var kelas = _kelasDal.GetData(kelasId);
            if (kelas == null)
            {
                ClearData();
                return;
            }

            TextKelasId.Text = kelasId.ToString();
            TextKelasName.Text = kelas?.KelasName?? string.Empty;
            TextFlagKelas.Text = kelas?.Flag??string.Empty;
            ComboKelasJurusan.SelectedValue = kelas?.JurusanId ?? 1;
            if (kelas?.KelasTingkat == 10) RadioKelas_10.Checked = true;
            else if (kelas?.KelasTingkat == 11) RadioKelas_11.Checked = true;
            else if (kelas?.KelasTingkat == 12) RadioKelas_12.Checked = true;
        }

        private void ButtonKelasDelete_Click(object? sender, EventArgs e)
        {
            var kelasName = ComboKelasJurusan.Text;
            var kelasClick = Convert.ToInt32(GridListKelas.CurrentRow.Cells["KelasId"].Value);

            if (MessageBox.Show($"Apakah anda ingin menghapus data \" {kelasName} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                _kelasDal.Delete(kelasClick);
                LoadData();
            }
            else
                return;
        }

        private void ButtonKelasNew_Click(object? sender, EventArgs e)
        {
           if (_mesBoxHelper.MessageKonfirmasi("Tambahkan data baru ?"))
                ClearData();
        }

        private void ButtonKelasSave_Click(object? sender, EventArgs e)
        {
            SaveData();
            LoadData();
        }

        #endregion

        private int SaveData()
        {
            var kelasId = Convert.ToInt32(TextKelasId.Text);

            var kelas = new KelasModel
            {
                KelasId = kelasId,
                KelasName = TextKelasName.Text,
                KelasTingkat = RadioKelas_10.Checked ? 10 : RadioKelas_11.Checked ? 11 : 12,
                JurusanId = Convert.ToInt32(ComboKelasJurusan.SelectedValue),
                Flag = TextFlagKelas.Text
            };

            if (kelas.KelasId == 0)
                _kelasDal.Insert(kelas);
            else 
                _kelasDal.Update(kelas);
            return kelasId;


        }

        private void LoadData()
        {
            GridListKelas.DataSource = _kelasDal.ListData();
            CustomGrid();
        }

        private void CustomGrid()
        {
            GridListKelas.Columns["KelasId"].HeaderText = "Id Kelas";
            GridListKelas.Columns["KelasName"].HeaderText = "Nama Kelas";
            GridListKelas.Columns["KelasTingkat"].HeaderText = "Tingkat";

            GridListKelas.Columns["JurusanId"].Visible = false;

            GridListKelas.Columns["KelasId"].Width = 100;
            GridListKelas.Columns["KelasName"].Width = 200;
            GridListKelas.Columns["KelasTingkat"].Width = 100;
        }

        private void ClearData()
        {
            TextKelasId.Clear();
            TextKelasName.Clear();
            TextFlagKelas.Clear();
            RadioKelas_10.Checked = false;
            RadioKelas_11.Checked = false;
            RadioKelas_12.Checked = false;
            ComboKelasJurusan.SelectedIndex = 0;
        }

        private void SetKelasName()
        { 
            var  radioTingkat = RadioKelas_10.Checked? 10 : RadioKelas_11.Checked ? 11 : 12;

            var jurusanId = Convert.ToInt16(ComboKelasJurusan.SelectedValue);
            var jurusan = _jurusanDal.GetData(jurusanId)?? new JurusanModel { JurusanKode = "X"};
            var jurusanKode = jurusan.JurusanKode;

            var flagKelas = TextFlagKelas.Text;

            TextKelasName.Text = $"{radioTingkat} {jurusanKode}-{flagKelas}";
        }
    }
}