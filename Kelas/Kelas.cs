using Microsoft.VisualBasic;
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
    public partial class Kelas : Form
    {
        private readonly JurusanDal _jurusanDal;
        private readonly KelasDal _kelasDal;
        int kelasTingkat = 0 ;
        public Kelas()
        {
            _jurusanDal = new JurusanDal();
            _kelasDal = new KelasDal();

            InitializeComponent();
            LoadData();
            InitCombo();
            InitialEvent();
        }

        #region CUSTOM COMBO RADIO
        private void InitCombo()
        {
            var dataJurusan = _jurusanDal.ListData();
            ComboKelasJurusan.DataSource = dataJurusan;
            ComboKelasJurusan.DisplayMember = "JurusanName";
            ComboKelasJurusan.ValueMember = "JurusanId";

            string jurusanName = string.Empty;
            if (ComboKelasJurusan.SelectedItem != null)
            {
                jurusanName = ((dynamic)ComboKelasJurusan.SelectedItem).JurusanName;
            }

            List<string> kelas = new List<string> { "","1", "2", "3", "4", "5" };
            List<string> kelasNama = kelas.Select(k => $"{kelasTingkat} {jurusanName} {k}").ToList();

            ComboKelasName.DataSource = kelasNama;
        }

        private void RefreshComboRadio()
        {
            string jurusanName = string.Empty;
            if (ComboKelasJurusan.SelectedItem != null)
            {
                jurusanName = ((dynamic)ComboKelasJurusan.SelectedItem).JurusanName;
            }

            List<string> kelas = new List<string> { "","1", "2", "3", "4", "5" };
            List<string> kelasNama = kelas.Select(k => $"{kelasTingkat} {jurusanName} {k}").ToList();

            ComboKelasName.DataSource = kelasNama;
        }

        #endregion


        #region EVENT
        private void InitialEvent()
        {
            ButtonKelasSave.Click += ButtonKelasSave_Click;
            ButtonKelasNew.Click += ButtonKelasNew_Click;
            ButtonKelasDelete.Click += ButtonKelasDelete_Click;
            GridListKelas.SelectionChanged += GridListKelas_SelectionChanged;
            ComboKelasJurusan.SelectedIndexChanged += ComboKelasJurusan_SelectedIndexChanged;

            List<RadioButton> radioTingkat = new List<RadioButton> 
            {
                RadioKelas_10,
                RadioKelas_11,
                RadioKelas_12
            };
            foreach (var radio in radioTingkat)
                radio.CheckedChanged += Radio_CheckedChanged;
        }

        private void ComboKelasJurusan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            RefreshComboRadio();
        }

        private void Radio_CheckedChanged(object? sender, EventArgs e)
        {
            if (RadioKelas_10.Checked) kelasTingkat = 10;
            if (RadioKelas_11.Checked) kelasTingkat = 11;
            if (RadioKelas_12.Checked) kelasTingkat = 12;
            RefreshComboRadio();
        }

        private void GridListKelas_SelectionChanged(object? sender, EventArgs e)
        {
            var kelasStr = GridListKelas.CurrentRow.Cells["KelasId"].Value.ToString();

            GetListData(Convert.ToInt32(kelasStr));   
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
            if (MessageBox.Show("Tambahkan data baru ?","Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ClearData();
            }
        }

        private void ButtonKelasSave_Click(object? sender, EventArgs e)
        {
            SaveData();
            LoadData();
        }

        #endregion

        private void SaveData()
        {
            var kelasInsert = new KelasModel()
            {
                KelasName = ComboKelasName.Text,
                KelasTingkat = kelasTingkat,
                JurusanId = Convert.ToInt16(ComboKelasJurusan.SelectedValue)
            };

            var kelasName = ComboKelasName.Text;

            if (TextKelasId.Text == string.Empty)
            {
                if (MessageBox.Show($"Tambahkan data \" {kelasName} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    _kelasDal.Insert(kelasInsert);
            }
            
            if(TextKelasId.Text != string.Empty)
            {
                if(MessageBox.Show("Update data ?","Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    var kelasUpdate = new KelasModel()
                    {
                        KelasId = Convert.ToInt16(TextKelasId.Text),
                        KelasName = ComboKelasName.Text,
                        KelasTingkat = kelasTingkat,
                        JurusanId = Convert.ToInt16(ComboKelasJurusan.SelectedValue)
                    };
                    _kelasDal.Update(kelasUpdate);
                }
            }
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
            TextKelasId.Text = string.Empty;
            ComboKelasName.Text = "";
            RadioKelas_10.Checked = false;
            RadioKelas_11.Checked = false;
            RadioKelas_12.Checked = false;
            ComboKelasJurusan.SelectedIndex = 0;
        }

       private void GetListData(int KelasId)
        {
            var getKelas = _kelasDal.GetData(KelasId);

            if (getKelas == null)
                MessageBox.Show("Data tidak ditemukan");

            TextKelasId.Text = KelasId.ToString();
            
            if (getKelas.KelasTingkat == 10) 
                RadioKelas_10.Checked = true;
            if (getKelas.KelasTingkat == 11)
                RadioKelas_11.Checked = true;
            if (getKelas.KelasTingkat == 12)
                RadioKelas_12.Checked = true;

            ComboKelasJurusan.SelectedValue = getKelas.JurusanId;
        }
    }
}