using Sistem_Informasi_Sekolah;
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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            InitialEvent();
            LoadForm(new DataInduk());
        }


        #region EVENT
        private void InitialEvent()
        {
            dataIndukSiswaToolStripMenuItem.Click += DataIndukSiswaToolStripMenuItem_Click;
            jurusanToolStripMenuItem.Click += JurusanToolStripMenuItem_Click;
            kelasToolStripMenuItem.Click += KelasToolStripMenuItem_Click;
            mataPelajaranToolStripMenuItem.Click += MataPelajaranToolStripMenuItem_Click;
        }

        private void MataPelajaranToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new MataPelajaran());
        }

        private void KelasToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new Kelas());
        }

        private void JurusanToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new Jurusan());
        }

        private void DataIndukSiswaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new DataInduk());
        }

        #endregion


        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(form);
            form.Show();
        }

        
    }
}
