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
            LoadForm(new FormSiswa());

            this.MinimumSize = new Size(1000, 800);
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(form);
            form.Show();
        }
        #region EVENT
        private void InitialEvent()
        {
            dataIndukSiswaToolStripMenuItem.Click += DataIndukSiswaToolStripMenuItem_Click;
            jurusanToolStripMenuItem.Click += JurusanToolStripMenuItem_Click;
            kelasToolStripMenuItem.Click += KelasToolStripMenuItem_Click;
            mataPelajaranToolStripMenuItem.Click += MataPelajaranToolStripMenuItem_Click;
            guruToolStripMenuItem.Click += GuruToolStripMenuItem_Click;
            jadwalPelajaranToolStripMenuItem.Click += JadwalPelajaranToolStripMenuItem_Click;
            kelasSiswaToolStripMenuItem.Click += KelasSiswaToolStripMenuItem_Click;
            absensiToolStripMenuItem.Click += AbsensiToolStripMenuItem_Click;
        }

        private void AbsensiToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormAbsensi());
        }

        private void KelasSiswaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormKelasSiswa());
        }

        private void JadwalPelajaranToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormJadwalPelajaran());
        }

        private void GuruToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormGuru());
        }

        private void MataPelajaranToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormMataPelajaran());
        }

        private void KelasToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormKelas());
        }

        private void JurusanToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormJurusan());
        }

        private void DataIndukSiswaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormSiswa());
        }

        #endregion
    }
}
