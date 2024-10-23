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
    public partial class FormKelasSiswa : Form
    {
        public FormKelasSiswa()
        {
            InitializeComponent();
            ControlEvent();
        }

        private void ControlEvent()
        {
            GridListKelasSiswa.KeyDown += GridListKelasSiswa_KeyDown;
            ButtonAddData.Click += ButtonAddData_Click;
        }

        private void ButtonAddData_Click(object? sender, EventArgs e)
        {
            if (new FormDataSiswa().ShowDialog() != DialogResult.OK) return;


        }

        private void GridListKelasSiswa_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F1) return;
            new FormDataSiswa().Show();

        }

    }
}
