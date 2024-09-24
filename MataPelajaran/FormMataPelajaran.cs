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
    public partial class FormMataPelajaran : Form
    {
        private readonly MataPelajaranDal _mataPelajaranDal;

        public FormMataPelajaran()
        {
            _mataPelajaranDal = new MataPelajaranDal();

            InitializeComponent();
            InitialEvent();
            LoadData();
        }

        #region EVENT
        private void InitialEvent()
        {
            ButtonMapelNew.Click += ButtonMapelNew_Click;
            ButtonMapelSave.Click += ButtonMapelSave_Click;
            ButtonMapelDelete.Click += ButtonMapelDelete_Click;
            GridListMapel.SelectionChanged += GridListMapel_SelectionChanged;
        }

        private void GridListMapel_SelectionChanged(object? sender, EventArgs e)
        {
            LabelMapelUpdate.Text = "UPDATE";
            var mapelId = GridListMapel.CurrentRow.Cells["MapelId"].Value;


            GetData(Convert.ToInt32(mapelId));
        }

        private void ButtonMapelDelete_Click(object? sender, EventArgs e)
        {
            int MapelId = Convert.ToInt32(GridListMapel.CurrentRow.Cells["MapelId"].Value);
            string MapelName = GridListMapel.CurrentRow.Cells["MapelName"].Value.ToString();

            if (MessageBox.Show($"Anda yakin akan menghapus data \"{MapelName}\" ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                _mataPelajaranDal.Delete(MapelId);
                LoadData();
            }
        }

        private void ButtonMapelSave_Click(object? sender, EventArgs e)
        {
            SaveData();
            LoadData();
            Clear();
        }

        private void ButtonMapelNew_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show($"Tambahkan data baru ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LabelMapelUpdate.Text = "INSERT";
                Clear();
            }
        }


        #endregion

        #region CLEAR & LOAD
        private void Clear()
        {
            TextMapelId.Text = string.Empty;
            TextMapelName.Text = string.Empty;
        }

        private void LoadData()
        {
            GridListMapel.DataSource = _mataPelajaranDal.ListData();
            CustomGrid();
        }
        #endregion

        private void CustomGrid()
        {
            GridListMapel.Columns["MapelId"].HeaderText = "Id Mapel";
            GridListMapel.Columns["MapelName"].HeaderText = "Nama Mapel";

            GridListMapel.Columns["MapelId"].Width = 100;
            GridListMapel.Columns["MapelName"].Width = 200;
        }

        private int SaveData()
        {
            var mapelId = TextMapelId.Text == string.Empty ? 0 : Convert.ToInt32(TextMapelId.Text);
            var mapelName = TextMapelName.Text;

            var mapelInsert = new MataPelajaranModel()
            {
                MapelId = mapelId,
                MapelName = TextMapelName.Text
            };

            if (mapelId == 0)
            {
                if (MessageBox.Show($"Tambahkan data \" {mapelName} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    _mataPelajaranDal.Insert(mapelInsert);
            }

            else
            {
                if (MessageBox.Show("Update data ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _mataPelajaranDal.Update(mapelInsert);
                }
            }

            return mapelId;
        }

        private void GetData(int MapelId)
        {
            var mapel = _mataPelajaranDal.GetData(MapelId);

            if (mapel == null)
                return;

            TextMapelId.Text = mapel.MapelId.ToString();
            TextMapelName.Text = mapel.MapelName;
        }
    }
}
