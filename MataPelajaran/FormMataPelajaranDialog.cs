using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistem_Informasi_Sekolah.FormGuru;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormMataPelajaranDialog : Form
    {

        private readonly MataPelajaranDal _mataPelajaranDal;
        public int MapelId { get; set; } = 0;
        public string MapelName { get; set; } = "";



        public FormMataPelajaranDialog()
        {
            InitializeComponent();

            KeyPreview = true;
            _mataPelajaranDal = new MataPelajaranDal();


            ListMapel();
            ControlEvent();

        }

        private void ListMapel()
        {
            var listMapel = _mataPelajaranDal.ListData()?.ToList() ?? new List<MataPelajaranModel>();
            GridListMapelDialog.DataSource = listMapel
                .Select(x => new
                {
                    Id = x.MapelId,
                    Name  = x.MapelName,
                }).ToList();
        }


        private void ControlEvent()
        {
            this.KeyDown += FormMataPelajaranPopUp_KeyDown;
            GridListMapelDialog.CellDoubleClick += GridListMapelPopUp_CellDoubleClick;
            GridListMapelDialog.KeyDown += GridListMapelPopUp_KeyDown;
        }

        private void GridListMapelPopUp_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && GridListMapelDialog != null)
            {
                e.Handled = true;

                DataGridViewRow selectedRow = GridListMapelDialog.CurrentRow;

                MapelId = Convert.ToInt32(selectedRow.Cells[0].Value);
                MapelName = selectedRow ?.Cells[1].Value.ToString() ?? string.Empty;

                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void GridListMapelPopUp_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = GridListMapelDialog.Rows[e.RowIndex];

            MapelId = Convert.ToInt32(selectedRow.Cells[0].Value);
            MapelName = selectedRow?.Cells[1].Value.ToString() ?? string.Empty;

            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void FormMataPelajaranPopUp_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
