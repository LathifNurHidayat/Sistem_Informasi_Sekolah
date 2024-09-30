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
    public partial class FormKelasDialog : Form
    {
        private readonly KelasDal _kelasDal;

        public int KelasId = 0;
        public string KelasName = string.Empty;

        public FormKelasDialog()
        {
            _kelasDal = new KelasDal(); 
            InitializeComponent();
            ListData();
            ControlEvent();

        }

        private void ListData()
        {
            var data = _kelasDal.ListData()
                .Select (x => new
                {
                    Id = x.KelasId,
                    NamaKelas = x.KelasName
                }).ToList();

            GridListKelasDialog.DataSource = data;
            GridListKelasDialog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ControlEvent()
        {
            GridListKelasDialog.DoubleClick += GridListKelasDialog_DoubleClick;
            GridListKelasDialog.KeyDown += GridListKelasDialog_KeyDown;
        }

        private void GridListKelasDialog_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && GridListKelasDialog != null)
            {
                DataGridViewRow currentRow = GridListKelasDialog.CurrentRow;
                KelasId = Convert.ToInt32(currentRow?.Cells[0].Value ?? 0);
                KelasName = currentRow?.Cells[1].Value.ToString() ?? string.Empty;

                e.Handled = true;
                DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void GridListKelasDialog_DoubleClick(object? sender, EventArgs e)
        {
            DataGridViewRow currentRow = GridListKelasDialog.CurrentRow;
            KelasId = Convert.ToInt32(currentRow?.Cells[0].Value ?? 0);
            KelasName = currentRow?.Cells[1].Value.ToString() ?? string.Empty;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
