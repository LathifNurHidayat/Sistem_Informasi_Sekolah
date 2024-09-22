using Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormJurusan : Form
    {
        private JurusanDal _jurusanDal;
        public FormJurusan()
        {
            _jurusanDal = new JurusanDal();
            InitializeComponent();
            InitialEvent();
            LoadData();
        }

        #region CLEAR & LOAD

        public void Clear()
        {
            TextJurusanId.Text = string.Empty;
            TextJurusanName.Text = string.Empty;
            TextJurusanKode.Text = string.Empty;
        }

        public void LoadData()
        {
            GridListJurusan.DataSource = _jurusanDal.ListData();
            CustomGrid();
        }

        #endregion

        private void CustomGrid()
        {
            GridListJurusan.Columns["JurusanId"].HeaderText = "Id Jurusan";
            GridListJurusan.Columns["JurusanName"].HeaderText = "Nama Jurusan";
            GridListJurusan.Columns["JurusanKode"].HeaderText = "Kode Jurusan";

            GridListJurusan.Columns["JurusanId"].Width = 100;
            GridListJurusan.Columns["JurusanName"].Width = 200;
            GridListJurusan.Columns["JurusanKode"].Width = 200;

        }

        #region EVENT
        private void InitialEvent()
        {
            ButtonJurusanSave.Click += ButtonJurusanSave_Click;
            GridListJurusan.SelectionChanged += GridListJurusan_SelectionChanged;
            ButtonJurusanNew.Click += ButtonJurusanNew_Click;
            ButtonJurusanDelete.Click += ButtonJurusanDelete_Click1;

        }

        private void ButtonJurusanDelete_Click1(object? sender, EventArgs e)
        {
            int jurusanId = Convert.ToInt32(GridListJurusan.CurrentRow.Cells["JurusanId"].Value);
            string jurusanName = GridListJurusan.CurrentRow.Cells["JurusanName"].Value.ToString();

            if (MessageBox.Show($"Anda yakin ingin menghapus data \"{jurusanName}\"", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                _jurusanDal.Delete(jurusanId);
                LoadData();
            }
            return;
        }

        private void ButtonJurusanNew_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show($"Tambahkan data baru ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LabelJurusanUpdate.Text = "INSERT";
                Clear();
            }
        }

        private void GridListJurusan_SelectionChanged(object? sender, EventArgs e)
        {
            LabelJurusanUpdate.Text = "UPDATE";
            string jurusanId = GridListJurusan.CurrentRow.Cells[0].Value.ToString();
            string jurusanName = GridListJurusan.CurrentRow.Cells[1].Value.ToString();
            string jurusanKode = GridListJurusan.CurrentRow.Cells[2].Value.ToString();

            if (jurusanId != null)
            {
                TextJurusanId.Text = jurusanId;
                TextJurusanName.Text = jurusanName;
                TextJurusanKode.Text = jurusanKode;
            }
            else
            {
                MessageBox.Show("Mohon pilih data terlebih dahulu");
            }
        }

        private void ButtonJurusanSave_Click(object? sender, EventArgs e)
        {
            
            SaveJurusan();
            LoadData();
            Clear();
            
        }

        #endregion 

        private int SaveJurusan()
        {
            int jurusanId = Convert.ToInt32(TextJurusanId.Text);

            var jurusan = new JurusanModel()
            {
                JurusanId = jurusanId,
                JurusanName = TextJurusanName.Text,
                JurusanKode = TextJurusanKode.Text
            };

            if (jurusanId == 0)
            {
                if (MessageBox.Show($"Tambahkan data \" {TextJurusanName.Text} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    _jurusanDal.Insert(jurusan);
            }
            else
            {
                if (MessageBox.Show("Update data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _jurusanDal.Update(jurusan);
                }
            }

            return jurusanId;
        }

        

    }
}
