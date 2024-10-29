using Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormKelasSiswa : Form
    {
        private readonly SiswaDal _siswaDal;
        private readonly KelasDal _kelasDal;
        private readonly GuruDal _guruDal;
        private readonly KelasSiswaDetilDal _kelasSiswaDetilDal;
        private readonly KelasSiswaDal _kelasSiswaDal;

        private BindingList<SiswaDto> _listAllSiswa = new ();
        private BindingList<SiswaDto> _listKelasSiswaDetil = new ();
        private BindingSource _allSiswaBinding = new ();
        private BindingSource _allKelasSiswaBinding = new ();

        private bool _isChange = false;
        private int _kelasId = 0;

        public FormKelasSiswa()
        {
            InitializeComponent();

            _siswaDal = new SiswaDal();
            _kelasDal = new KelasDal();
            _guruDal = new GuruDal();
            _kelasSiswaDetilDal = new KelasSiswaDetilDal();
            _kelasSiswaDal = new KelasSiswaDal();

            _allSiswaBinding.DataSource = _listAllSiswa;
            _allKelasSiswaBinding.DataSource = _listKelasSiswaDetil;
            GridListAllSiswa.DataSource = _listAllSiswa;
            GridListKelasSiswa.DataSource = _listKelasSiswaDetil;
            
            InitialCombo();
            ControlEvent();

            GridListAllSiswa.ReadOnly = true;
            GridListKelasSiswa.ReadOnly = true;
        }

        private void InitialCombo()
        {
            var kelas = new List<KelasModel>
            {
                new KelasModel{KelasId = -1, KelasName = "--Pilih Kelas--"}
            };
            kelas.AddRange(_kelasDal.ListData()? .ToList() ?? new ());
            ComboKelas.DataSource = kelas;
            ComboKelas.DisplayMember = "KelasName";
            ComboKelas.ValueMember = "KelasId";
            ComboKelas.SelectedIndex = 0;

            var guru = new List<GuruModel>
            {
                new GuruModel{GuruId = -1, GuruName = "--Pilih Guru--"}
            };
            guru.AddRange(_guruDal.ListData()?.ToList() ?? new ());
            ComboWaliKelas.DataSource = guru;
            ComboWaliKelas.DisplayMember = "GuruName";
            ComboWaliKelas.ValueMember = "GuruId";
        }

        #region EVENT 
        private void ControlEvent()
        {
            ComboKelas.SelectedIndexChanged += ComboKelas_SelectedIndexChanged;
            GridListAllSiswa.CellDoubleClick += GridListAllSiswa_CellDoubleClick;
            GridListKelasSiswa.CellDoubleClick += GridListKelasSiswa_CellDoubleClick;
            ButtonSaveData.Click += ButtonSaveData_Click;
            TextSearch.TextChanged += TextSearch_TextChanged;
        }

        private void TextSearch_TextChanged(object? sender, EventArgs e)
        {
            if ((int)ComboKelas.SelectedValue == -1) return;
            LoadData(TextSearch.Text);
        }


        private void ButtonSaveData_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Simpan Data ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            SaveData(_kelasId);
            _isChange = false;
        }

        private void GridListKelasSiswa_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _listKelasSiswaDetil.Count) return;
            
            var dataGrid = sender as DataGridView;
            var selectedSiswa = _listKelasSiswaDetil[e.RowIndex];

            if (selectedSiswa != null)
            {
                if (selectedSiswa.SiswaId == 0) return; 

                _listAllSiswa.Add(selectedSiswa);
                _listKelasSiswaDetil.Remove(selectedSiswa);

                GridListAllSiswa.Refresh();
                GridListKelasSiswa.Refresh();
            }
            _isChange = true;
        }
         
        private void GridListAllSiswa_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _listAllSiswa.Count) return;

            var dataGrid = sender as DataGridView;
            var selectedAllSiswa = _listAllSiswa[e.RowIndex];

            if (selectedAllSiswa != null)
            {
                if (selectedAllSiswa.SiswaId == 0) return;

                _listKelasSiswaDetil.Add(selectedAllSiswa);
                _listAllSiswa.Remove(selectedAllSiswa);

                GridListKelasSiswa.Refresh();
                GridListAllSiswa.Refresh();
            }
            _isChange = true;
        }

        private void ComboKelas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isChange == true)
            {
                if (MessageBox.Show("Simpan Perubahan ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveData(_kelasId);
                }
            }
            ClearForm();
            LoadData(TextSearch.Text);
            _isChange = false;
            _kelasId = (int)ComboKelas.SelectedValue;
        }

        #endregion



        private void SaveData(int kelasId)
        {
            if (ComboKelas.SelectedIndex == -1) return;
            var kelasSiswa = new KelasSiswaModel
            {
                KelasId = kelasId,
                TahunAjaran = TextTahunAjaran.Text,
                WaliKelasId = (int)ComboWaliKelas.SelectedValue
            };

            var cekKelasSiswa = _kelasSiswaDal.ListData().Select(x => x.KelasId).ToList();
            if (!cekKelasSiswa.Any()) return;
            _kelasSiswaDal.Insert(kelasSiswa);

            _kelasSiswaDetilDal.Delete(kelasId);
            foreach (var item in _listKelasSiswaDetil)
            {
                if (item != null)
                {
                    var data = new KelasSiswaDetilModel
                    {
                        KelasId = kelasId,
                        SiswaId = item.SiswaId
                    };
                    _kelasSiswaDetilDal.Insert(data);
                }
            }

        }

        private void LoadData(string nama)
        {   
            var kelasId = (int)ComboKelas.SelectedValue;
            if (kelasId == -1)
            {
                ClearForm();
                return;
            }

            var kelasSiswa = _kelasSiswaDal.GetData(kelasId);
            if (kelasSiswa == null) ClearForm();

            TextTahunAjaran.Text = kelasSiswa?.TahunAjaran?? string.Empty;
            ComboWaliKelas.SelectedValue = kelasSiswa?.WaliKelasId?? -1 ;
            _listAllSiswa.Clear();
            _listKelasSiswaDetil.Clear();

            var dataAllSiswa = _siswaDal.ListDataFilter(nama).Select(x => new SiswaDto(x.SiswaId, x.NamaLengkap))?.ToList() ?? new ();
            var dataKelasSiswaDetil = _kelasSiswaDetilDal.ListData().Select( x => new SiswaDto(x.SiswaId, x.SiswaName))?.ToList() ?? new ();
            var dataPerKelas = _kelasSiswaDetilDal.ListData(kelasId).Select(x => new SiswaDto(x.SiswaId, x.SiswaName))?.ToList() ?? new();
            
            var IdKelasSiswa = dataKelasSiswaDetil.Select(x => x.SiswaId).ToList();
            dataAllSiswa.RemoveAll(x => IdKelasSiswa.Contains(x.SiswaId));

            foreach (var item in dataAllSiswa) 
                _listAllSiswa.Add(item);
            foreach (var item in dataPerKelas)
                _listKelasSiswaDetil.Add(item);

        }

        private void ClearForm()
        {
            TextTahunAjaran.Clear();
            ComboWaliKelas.SelectedValue = -1;
            _listAllSiswa.Clear();
            _listKelasSiswaDetil.Clear();
        }

       
        public class SiswaDto
        {
            public SiswaDto(int id, string name) => (SiswaId, NamaLengkap) = (id, name);
            public int SiswaId { get; set; }
            public string NamaLengkap { get; set; }
        }
    }
}
