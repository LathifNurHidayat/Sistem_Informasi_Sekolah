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

        private readonly BindingSource _listMapelBinding;
        private readonly BindingList<MataPelajaranDto> _mataPelajaranDto;

        public FormGuru()
        {
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mataPelajaranDal = new MataPelajaranDal();
            

            _mataPelajaranDto = new BindingList<MataPelajaranDto>();
            _listMapelBinding = new BindingSource()
            {
                DataSource = _mataPelajaranDto
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
            ButtonGuruNew.Click += ButtonGuruNew_Click;
            ButtonGuruSave.Click += ButtonGuruSave_Click;
            ButtonGuruDelete.Click += ButtonGuruDelete_Click;
        }

        private void ButtonGuruDelete_Click(object? sender, EventArgs e)
        {
            var IdGuru = Convert.ToInt32(GridListGuru.CurrentRow.Cells[0].Value);
            var namaGuru = GridListGuru.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Delete data \"{namaGuru}\" ?", "Konfirmasi", MessageBoxButtons.YesNo  , MessageBoxIcon.Question)== DialogResult.Yes)
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

        private void GridListGuru_SelectionChanged(object? sender, EventArgs e)
        {
            if (GridListGuru.Rows.Count > 0)
            {
                var GuruId = Convert.ToInt32(GridListGuru.CurrentRow.Cells[0].Value);
                GetData(GuruId);
            }
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

        private void  ClearInput()
        {
            TextGuruId.Clear();
            TextGuruNama.Clear();
            PickerTglLahirGuru.Value = new DateTime(2000-01-01);
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
            int guruId = TextGuruId.Text == string.Empty ? 0 : Convert.ToInt32(TextGuruId.Text);

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

                ListMapel = _mataPelajaranDto
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
            _guruMapelDal.Insert(guru.ListMapel);


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
            TextKota.Text = guru.KotaPendidikan;

            var listMapel = _guruMapelDal.GetData(GuruId)?.ToList() ?? new List<GuruMapelModel>();

            _mataPelajaranDto.Clear();
            listMapel.ForEach(x => _mataPelajaranDto.Add(new MataPelajaranDto
            {
                Id = x.MapelId,
                MataPelajaran = x.MapelName,
            }));               
        }


        public class GuruDto
        {
            public int Id {  get; set; }
            public string Nama { get; set; }
            public string Pendidikan { get; set; }
        }

        public class MataPelajaranDto
        {
            public int Id {  get; set; }
            public string MataPelajaran { get; set; }
        }
    }
}
