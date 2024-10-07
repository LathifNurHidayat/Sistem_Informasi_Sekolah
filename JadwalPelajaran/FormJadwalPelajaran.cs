using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormJadwalPelajaran : Form
    {
        private readonly MataPelajaranDal _mataPelajaranDal;
        private readonly GuruDal _guruDal;
        private readonly JadwalPelajaranDal _jadwalPelajaranDal;
        private int _jadwalId = 0;

        public FormJadwalPelajaran()
        {
            _mataPelajaranDal = new MataPelajaranDal();
            _guruDal = new GuruDal();
            _jadwalPelajaranDal = new JadwalPelajaranDal();

            InitializeComponent();
            InitialCombo();
            InitialMaskText();

            ControlEvent();
        }

        #region INITIAL FORM
        private void InitialCombo()
        {   
            List<string> Hari = new () { "--Pilih Hari--","Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
            ComboHari.DataSource = Hari;
            ComboHari.SelectedIndex = 0;


            var dataMapel = new List<MataPelajaranModel>
            {
                new MataPelajaranModel {MapelId = -1, MapelName = "--Pilih Mata Pelajaran--"}
            };
            dataMapel.AddRange(_mataPelajaranDal.ListData()?.ToList() ?? new List<MataPelajaranModel>() );
            ComboMataPelajaran.Items.Clear();
            ComboMataPelajaran.DataSource = dataMapel;
            ComboMataPelajaran.SelectedIndex = 0;
            ComboMataPelajaran.DisplayMember = "MapelName";
            ComboMataPelajaran.ValueMember = "MapelId";


            var dataGuru = new List<GuruModel>
            {
                new GuruModel {GuruId = -1 , GuruName = "--Pilih Guru--"}
            };
            dataGuru.AddRange(_guruDal.ListData()?.ToList() ?? new List<GuruModel>());
            ComboGuru.Items.Clear();
            ComboGuru.DataSource = dataGuru;
            ComboGuru.SelectedIndex = 0;
            ComboGuru.DisplayMember = "GuruName";
            ComboGuru.ValueMember = "GuruId";
        }

        private void InitialMaskText()
        {
            MaskedJamMulai.Mask = "00:00";
            MaskedJamMulai.Font = new Font("Segoe UI", 11);
            MaskedJamMulai.TextAlign = HorizontalAlignment.Center;

            MaskedSelesai.Mask = "00:00";
            MaskedSelesai.Font = new Font("Segoe UI", 11);
            MaskedSelesai.TextAlign = HorizontalAlignment.Center;
        }

        private void LoadData()
        {
            int KelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);
            if (KelasId == 0)
                return;

            var jenisJadwal = RadioListKhusus.Checked ? "Khusus" : RadioListUmum.Checked ? "Umum" : " ";
            var listData = _jadwalPelajaranDal.ListData(KelasId) ?? new List<JadwalPelajaranModel>();

            var listJadwal = listData
                .Where(x => x.JenisJadwal == jenisJadwal)
                .Select(x => new JadwalDto
                {
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai} - {x.JamSelesai}",
                    MataPelajaran = $"{x.MapelName} {x.Keterangan}",
                    Guru = x.GuruName,
                    JadwalId = x.JadwalId,
                }).ToList();

            GridListJadwalPelajaran.DataSource = listJadwal;
            GridListJadwalPelajaran.Columns["JadwalId"].Visible = false;
            GridListJadwalPelajaran.ReadOnly = true;

            GridListJadwalPelajaran.Paint += GridListJadwalPelajaran_Paint;
            GridListJadwalPelajaran.CellPainting += GridListJadwalPelajaran_CellPainting;
        }

        private void GridListJadwalPelajaran_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    e.PaintBackground(e.ClipBounds, true);  

                    var cellValue = e.Value?.ToString();
                    if (cellValue != null)
                    {
                        e.Graphics.DrawString(cellValue, e.CellStyle.Font, Brushes.Black, e.CellBounds);
                    }

                    e.Handled = true;  
                }
            }
        }

        private void GridListJadwalPelajaran_Paint(object? sender, PaintEventArgs e)
        {

            {
                int rowIndex = 0;

                while (rowIndex < GridListJadwalPelajaran.Rows.Count)
                {
                    var currentHariValue = GridListJadwalPelajaran.Rows[rowIndex].Cells[0].Value?.ToString();

                    int rowSpan = 1;

                    for (int i = rowIndex + 1; i < GridListJadwalPelajaran.Rows.Count && i < rowIndex + 6; i++)  // Cek hingga 6 baris ke depan
                    {
                        var nextHariValue = GridListJadwalPelajaran.Rows[i].Cells[0].Value?.ToString();
                        if (nextHariValue == currentHariValue)
                        {
                            rowSpan++;
                        }
                        else
                        {
                            break;  // Jika ada nilai yang berbeda, hentikan loop
                        }
                    }

                    if (rowSpan > 1)
                    {
                        var cellHeight = GridListJadwalPelajaran.GetRowDisplayRectangle(rowIndex, true).Height * rowSpan;
                        var cellBounds = new Rectangle(GridListJadwalPelajaran.GetCellDisplayRectangle(0, rowIndex, true).Location, new Size(GridListJadwalPelajaran.GetCellDisplayRectangle(0, rowIndex, true).Width, cellHeight));

                        e.Graphics.FillRectangle(new SolidBrush(GridListJadwalPelajaran.DefaultCellStyle.BackColor), cellBounds);
                        e.Graphics.DrawRectangle(Pens.Gainsboro, cellBounds);
                        e.Graphics.DrawString(currentHariValue, GridListJadwalPelajaran.DefaultCellStyle.Font, Brushes.Black, cellBounds);

                        rowIndex += rowSpan;
                    }
                    else
                    {
                        rowIndex++;
                    } 
                }
            }
        }
        
        
        #endregion


        #region EVENT
        private void ControlEvent()
        {
            ButtonDialogKelas.Click += ButtonDialogKelas_Click;
            ButtonJadwalSave.Click += ButtonJadwalSave_Click;
            ButtonJadwalNew.Click += ButtonJadwalNew_Click;
            ButtonJadwalDelete.Click += ButtonJadwalDelete_Click;

            GridListJadwalPelajaran.RowEnter += GridListJadwalPelajaran_RowEnter;
            TextKelasId.TextChanged += TextKelasId_TextChanged;
            RadioListUmum.CheckedChanged += RadioListUmum_CheckedChanged;
            RadioListKhusus.CheckedChanged += RadioListKhusus_CheckedChanged;
        }

        private void GridListJadwalPelajaran_RowEnter(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != null)
            {
                int jadwalId = Convert.ToInt32(GridListJadwalPelajaran.Rows[e.RowIndex].Cells["JadwalId"].Value);
                _jadwalId = jadwalId;

            }GetData(_jadwalId);
        }

        private void RadioListKhusus_CheckedChanged(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void RadioListUmum_CheckedChanged(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void TextKelasId_TextChanged(object? sender, EventArgs e)
        {
            RadioListUmum.Checked = true;
            LoadData();
        }

        private void ButtonJadwalDelete_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus data ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                _jadwalPelajaranDal.Delete(_jadwalId);
                LoadData();
            }
        }

        private void ButtonJadwalNew_Click(object? sender, EventArgs e)
        {
            ClearForm();   
        }

        private void ButtonJadwalSave_Click(object? sender, EventArgs e)
        {

            string JamMulai, JamSelesai;
            int Jenis, Hari, Mapel, Guru;

            Jenis = RadioKhusus.Checked ? 1 : RadioUmum.Checked ? 1 : 0;
            Hari = ComboHari.SelectedIndex;
            JamMulai = MaskedJamMulai.Text;
            JamSelesai = MaskedSelesai.Text;
            Mapel = ComboMataPelajaran.SelectedIndex;
            Guru = ComboGuru.SelectedIndex;

            if (Jenis == 0 || Hari == 0 || JamMulai == string.Empty || JamSelesai == string.Empty || Mapel == 0 || Guru == 0)
            {
                MessageBox.Show("Mohon lengkapi data!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SaveData();
            LoadData();
            ClearForm();
        }

        private void ButtonDialogKelas_Click(object? sender, EventArgs e)
        {
            using var formKelas = new FormKelasDialog();

            if (formKelas.ShowDialog() == DialogResult.OK)
            {
                TextKelasId.Text = formKelas.KelasId.ToString() ?? string.Empty;
                TextKelasName.Text = formKelas.KelasName?.ToString() ?? string.Empty;
            }
        }


        #endregion 


        private void SaveData()
        {
            var kelasId = TextKelasId.Text == string.Empty ? 0 : Convert.ToInt32(TextKelasId.Text);
            if (kelasId == 0)
            {
                MessageBox.Show("Masukan kelas terlebih dahulu", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var jenisJadwal = string.Empty;
            if (RadioUmum.Checked) jenisJadwal = RadioUmum.Text;
            if (RadioKhusus.Checked) jenisJadwal = RadioKhusus.Text;

            var jadwal = new JadwalPelajaranModel
            {
                JadwalId = _jadwalId,
                KelasId = kelasId,
                JenisJadwal = jenisJadwal,
                Hari = ComboHari.Text,
                JamMulai = MaskedJamMulai.Text,
                JamSelesai = MaskedSelesai.Text,
                MapelId = Convert.ToInt32(ComboMataPelajaran.SelectedValue),
                GuruId = Convert.ToInt32(ComboGuru.SelectedValue),
                Keterangan = TextKeterangan.Text,
            };

            if (_jadwalId == 0)
            {
                _jadwalPelajaranDal.Insert(jadwal);
            }
            else
                _jadwalPelajaranDal.Update(jadwal);
            return;
        }

        private void ClearForm()
        {
            RadioKhusus.Checked = false;
            RadioUmum.Checked = false;

            MaskedJamMulai.Clear();
            MaskedSelesai.Clear();

            ComboHari.SelectedIndex = 0; 
            ComboMataPelajaran.SelectedIndex = 0;
            ComboGuru.SelectedIndex = 0;

            TextKeterangan.Clear();
            _jadwalId = 0;
        }

        private void GetData(int JadwalId)
        {
            if (JadwalId == 0)
                return;

            var jadwal = _jadwalPelajaranDal.GetData(JadwalId);

            if (jadwal != null)
            {
                if (jadwal.JenisJadwal == "Umum")
                    RadioUmum.Checked = true;
                if (jadwal.JenisJadwal == "Khusus")
                    RadioKhusus.Checked = true;

                ComboHari.Text = jadwal.Hari;
                MaskedJamMulai.Text = jadwal.JamMulai;
                MaskedSelesai.Text = jadwal.JamSelesai;
                ComboMataPelajaran.SelectedValue = jadwal.MapelId;
                ComboGuru.SelectedValue = jadwal.GuruId;
                TextKeterangan.Text = jadwal.Keterangan;
            }
            else
            {
                RadioKhusus.Checked = false;
                RadioUmum.Checked = false;
            }
        }


        private class JadwalDto
        {
            public string Hari { get; set; }
            public string Waktu { get; set; }
            public string MataPelajaran { get; set; }
            public string Guru { get; set; }
            public int JadwalId { get; set; }
        }
    }
}
