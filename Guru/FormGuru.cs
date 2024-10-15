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
    public partial class FormGuru : Form
    {
        private readonly GuruDal _guruDal;
        private readonly GuruMapelDal _guruMapelDal;
        private readonly MataPelajaranDal _mataPelajaranDal;

        private readonly BindingList<MataPelajaranDto> _listMataPelajaran;
        private readonly BindingSource _listMapelBinding;

        public FormGuru()
        {
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mataPelajaranDal = new MataPelajaranDal();


            _listMataPelajaran = new BindingList<MataPelajaranDto>();
            _listMapelBinding = new BindingSource()
            {
                DataSource = _listMataPelajaran
            };


            InitializeComponent();

            ControlEvent();
            InitialGrid();
            InitialCombo();
            RefreshData();
        }

        #region EVENT
        private void ControlEvent()
        {
            GridListGuru.SelectionChanged += GridListGuru_SelectionChanged;
            GridListGuruMapel.CellValidated += GridListGuruMapel_CellValidated;
            GridListGuruMapel.KeyDown += GridListGuruMapel_KeyDown;


            ButtonGuruNew.Click += ButtonGuruNew_Click;
            ButtonGuruSave.Click += ButtonGuruSave_Click;
            ButtonGuruDelete.Click += ButtonGuruDelete_Click;

        }
         
        private void GridListGuruMapel_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                DataGridViewRow currenRow = GridListGuruMapel.CurrentRow;

                using var formMapel = new FormMataPelajaranDialog();
                if (formMapel.ShowDialog() == DialogResult.OK)
                {
                    var mapelId = formMapel.MapelId;
                    var mapelName = formMapel.MapelName;


                    GridListGuruMapel.BeginEdit(true);

                    currenRow.Cells[0].Value = mapelId; 
                    currenRow.Cells[1].Value = mapelName; 

                    GridListGuruMapel.EndEdit(DataGridViewDataErrorContexts.Commit);

                    _listMapelBinding.ResetBindings(false);
                    GridListGuruMapel.CurrentCell = GridListGuruMapel.Rows[GridListGuruMapel.Rows.Count - 1 ].Cells[0];

                }
            }
        }

        private void GridListGuruMapel_CellValidated(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var dataGrid = (DataGridView)sender;
            var getIdMapel = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (dataGrid.CurrentCell.OwningColumn.Name)
            {
                case "Id":
                    var mapel = _mataPelajaranDal.GetData(Convert.ToInt32(getIdMapel));
                    if (mapel == null)
                    {
                        _listMataPelajaran[e.RowIndex].MataPelajaran = " ";
                        return;
                    }

                    _listMataPelajaran[e.RowIndex].Id = mapel.MapelId;
                    _listMataPelajaran[e.RowIndex].MataPelajaran = mapel.MapelName;

                    break;
            }
        }

        private void GridListGuru_SelectionChanged(object? sender, EventArgs e)
        {
            if (GridListGuru.Rows.Count > 0)
            {
                var GuruId = Convert.ToInt32(GridListGuru.CurrentRow.Cells[0].Value);
                GetData(GuruId);
            }
        }



           
        private void ButtonGuruDelete_Click(object? sender, EventArgs e)
        {
            var IdGuru = Convert.ToInt32(GridListGuru.CurrentRow.Cells[0].Value);
            var namaGuru = GridListGuru.CurrentRow.Cells[1].Value.ToString();

            if (IdGuru == 0) 
                return;

            if (MessageBox.Show($"Delete data \"{namaGuru}\" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _guruDal.Delete(IdGuru);
                _guruMapelDal.Delete(IdGuru);

                RefreshData();
                ClearInput();
            }
        }

        private void ButtonGuruSave_Click(object? sender, EventArgs e)
        {
            SaveData();
            RefreshData();
            ClearInput();
        }

        private void ButtonGuruNew_Click(object? sender, EventArgs e)
        {
            ClearInput();
        }

        #endregion


        private void InitialGrid()
        {
            GridListGuruMapel.DataSource = _listMapelBinding;

            GridListGuruMapel.Columns["Id"].Width = 40;
            GridListGuruMapel.Columns["MataPelajaran"].Width = 200;
        }

        private void InitialCombo()
        {
            ComboTingkatPendidikan.Items.Clear();
            ComboTingkatPendidikan.Items.Add("-");
            ComboTingkatPendidikan.Items.Add("D3");
            ComboTingkatPendidikan.Items.Add("S1");
            ComboTingkatPendidikan.Items.Add("S2");
            ComboTingkatPendidikan.Items.Add("S3");

            ComboTingkatPendidikan.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTingkatPendidikan.SelectedIndex = 0;
        }

        private void RefreshData()
        {
            var listGuru = _guruDal.ListData() ?? new List<GuruModel>();

            var dataSource = listGuru
                .Select(x => new GuruDto
                {
                    Id = x.GuruId,
                    Nama = x.GuruName,
                    Pendidikan = $"{x.TingkatPendidikan} - {x.JurusanPendidikan}"
                })
                .ToList();

            GridListGuru.DataSource = dataSource;
            GridListGuru.Refresh();
        }

        private void ClearInput()
        {
            TextGuruId.Clear();
            TextGuruNama.Clear();
            PickerTglLahirGuru.Value = new DateTime(2000, 01, 01);
            ComboTingkatPendidikan.SelectedIndex = 0;
            TextInstansiPendidikan.Clear();
            TextJurusanPendidikan.Clear();
            TextTahunLulus.Clear();
            TextKota.Clear();
            TextInstansiPendidikan.Clear();

            _listMapelBinding.Clear();
        }

        private int SaveData()
        {
            var guruId = TextGuruId.Text == string.Empty ? 0 : Convert.ToInt32(TextGuruId.Text);

            var guru = new GuruModel
            {
                GuruId = guruId,
                GuruName = TextGuruNama.Text,
                TglLahir = PickerTglLahirGuru.Value,
                TingkatPendidikan = ComboTingkatPendidikan.SelectedItem.ToString() ?? string.Empty,
                JurusanPendidikan = TextJurusanPendidikan.Text,
                TahunLulus = TextTahunLulus.Text,
                InstansiPendidikan = TextInstansiPendidikan.Text,
                KotaPendidikan = TextKota.Text,

                ListMapel = _listMataPelajaran
                    .Select(x => new GuruMapelModel
                    {
                        GuruId = guruId,
                        MapelId = x.Id,
                    }).ToList()
            };

            if (guru.GuruId == 0)
                guru.GuruId = _guruDal.Insert(guru);    
            else
                _guruDal.Update(guru);

            _guruMapelDal.Delete(guru.GuruId);
            _guruMapelDal.Insert(guru.ListMapel,guru.GuruId);

            return guruId;
        }

        private void GetData(int GuruId)
        {
            var guru = _guruDal.GetData(GuruId);

            if (guru == null)
            {
                ClearInput();
                return;
            }

            TextGuruId.Text = guru.GuruId.ToString();
            TextGuruNama.Text = guru.GuruName;
            PickerTglLahirGuru.Value = guru.TglLahir;
            ComboTingkatPendidikan.SelectedItem = guru.TingkatPendidikan;
            TextJurusanPendidikan.Text = guru.JurusanPendidikan;
            TextInstansiPendidikan.Text = guru.InstansiPendidikan;
            TextTahunLulus.Text = guru.TahunLulus;
            TextKota.Text = guru.KotaPendidikan;

            var listMapel = _guruMapelDal.GetData(GuruId)?.ToList() ?? new List<GuruMapelModel>();

            _listMataPelajaran.Clear();
            listMapel.ForEach(x => _listMataPelajaran.Add(new MataPelajaranDto
            {
                Id = x.MapelId,
                MataPelajaran = x.MapelName,
            }));
        }




        public class GuruDto
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Pendidikan { get; set; }
        }

        public class MataPelajaranDto
        {
            public int Id { get; set; }
            public string MataPelajaran { get; set; } 
        }

    }
}