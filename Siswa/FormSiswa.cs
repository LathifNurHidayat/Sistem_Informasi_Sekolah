using Microsoft.VisualBasic.ApplicationServices;
using Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System.ComponentModel;
using System.Drawing.Text;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormSiswa : Form
    {

        private readonly SiswaDal _siswaDal;
        private readonly SiswaRiwayatDal _siswaRiwayatDal;
        private readonly SiswaWaliDal _siswaWaliDal;
        private readonly SiswaBeasiswaDal _siswaBeasiswaDal;
        private readonly SiswaLulusDal _siswaLulusDal;

        private readonly BindingSource _beasiswaBinding;
        private readonly BindingList<BeasiswaDto> _listBeasiswaBinding;

        private string _pilihGambar = string.Empty;
        private readonly MesBoxHelper _mesBoxHelper;



        public FormSiswa()
        {
            _siswaDal = new SiswaDal();
            _siswaRiwayatDal = new SiswaRiwayatDal();
            _siswaWaliDal = new SiswaWaliDal();
            _siswaBeasiswaDal = new SiswaBeasiswaDal();
            _siswaLulusDal = new SiswaLulusDal();

            _listBeasiswaBinding = new BindingList<BeasiswaDto>();
            _beasiswaBinding = new BindingSource
            {
                DataSource = _listBeasiswaBinding
            };
            _mesBoxHelper = new MesBoxHelper();

            InitializeComponent();
            InitialCombo();
            InitialGrid();
            ControlEvent();
            RefreshData();
        }


        #region INITIAL FORM

        public void InitialCombo()
        {
            List<string> agama = new List<string>() { "Islam", "Katolik", "Kristen", "Hindu", "Budha", "Konghucu" };
            ComboAgama.DataSource = new List<string>(agama);
            ComboAgamaAyah.DataSource = new List<string>(agama);
            ComboAgamaIbu.DataSource = new List<string>(agama);
            ComboAgamaWali.DataSource = new List<string>(agama);

            List<string> YatimPiatu = new List<string>() { "Kedua Orangtua Hidup", "Yatim", "Piatu", "Yatim Piatu" };
            ComboYatimPiatu.DataSource = new List<string>(YatimPiatu);

            List<string> TinggalDengan = new List<string>() { "Orang Tua", "Saudara", "Di Asrama" };
            ComboTinggal.DataSource = new List<string>(TinggalDengan);
        }

        public void InitialGrid()
        {
            GridBeasiswa.DataSource = _beasiswaBinding;
            GridBeasiswa.Columns["Kelas"].Width = 60;
            GridBeasiswa.Columns["Tahun"].Width = 60;
            GridBeasiswa.Columns["AsalBeasiswa"].Width = 120;
        }

        


        #endregion


        #region  EVENT

        private void ControlEvent()
        {
            NewButton.Click += NewButton_Click;
            ButtonRefresh.Click += ButtonRefresh_Click;
            GridListSiswa.CellDoubleClick += GridListData_CellDoubleClick;
            ButtonUpdate.Click += ButtonUpdate_Click;
            ButtonDelete.Click += ButtonDelete_Click;

            ButtonPilihGambar.Click += ButtonPilihGambar_Click;
            ButtonDeleteGambar.Click += ButtonDeleteGambar_Click;
            GridListSiswa.CellEnter += GridListData_CellEnter;
            ButtonPilihGambar.Click += ButtonSaveGambar_Click;



            List<Button> buttonSave = new List<Button>
            {
                ButtonSavePerson,
                ButtonSaveKesPendidikan,
                ButtonSaveWali,
                ButtonSaveLulus
            };
            foreach (var button in buttonSave)
                button.Click += ButtonSave_Click;
        }

        private void ButtonSaveGambar_Click(object? sender, EventArgs e)
        {
            var siswa = _siswaDal.GetData(Convert.ToInt32(LabelSiswaId.Text));

            _siswaDal.Update(siswa);

        }

        private void GridListData_CellEnter(object? sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow SelectRow = GridListSiswa.Rows[e.RowIndex];

                string SiswaId = SelectRow.Cells[0].Value.ToString();
                string NamaSiswa = SelectRow.Cells[1].Value.ToString();

                LabelSiswaId.Text = SiswaId;
                LabelSiswaNama.Text = NamaSiswa;


                var siswa = _siswaDal.GetData(Convert.ToInt32(SiswaId));
                _pilihGambar = siswa?.LokasiPhoto ?? string.Empty;

                if (_pilihGambar != string.Empty)
                    PictureSiswa.Image = Image.FromFile(_pilihGambar);
                else
                    PictureSiswa.Image = null;

            }
        }

        private void ButtonDeleteGambar_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus profil ?","Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.Yes)
            {
                PictureSiswa.Image = null;
                _pilihGambar = string.Empty;
            }
        }

        private void ButtonPilihGambar_Click(object? sender, EventArgs e)
        {
            var opendialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                FilterIndex = 1,
                Title = "Pilih Gambar"
            };

            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                PictureSiswa.Image = System.Drawing.Image.FromFile(opendialog.FileName);
                PictureSiswa.SizeMode = PictureBoxSizeMode.StretchImage;

                _pilihGambar = opendialog.FileName;

                UpdateGambar();
            }
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            var namaSiswa = GridListSiswa.CurrentRow.Cells["NamaLengkap"].Value.ToString();
            if (MessageBox.Show($"Anda yakin ingin menghapus seluruh data dari \"{namaSiswa}\"", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                var siswaStr = GridListSiswa.CurrentRow.Cells["SiswaId"].Value.ToString();
                if (siswaStr == null)
                    return;

                var siswaId = Convert.ToInt32(siswaStr);
                _siswaDal.Delete(siswaId);
                _siswaRiwayatDal.Delete(siswaId);
                _siswaWaliDal.Delete(siswaId);
                _siswaBeasiswaDal.Delete(siswaId);
                _siswaLulusDal.Dalete(siswaId);

                MessageBox.Show("Data berhasil dihapus");
                RefreshData();
            }
            else
                return;
        }


        private void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            var SiswaStr = GridListSiswa.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (SiswaStr is null)
                return;

            var SiswaId = Convert.ToInt32(SiswaStr);
            GetSiswa(SiswaId);
            TabControlSiswa.SelectedIndex = 1;
        }


        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            SaveSiswa();

            if (_mesBoxHelper.MessageInformasi("Data berhasil disimpan !"))
            {
                RefreshData();
            }
        }


        private void NewButton_Click(object? sender, EventArgs e)
        {
            var siswaId = TextIdSiswa.Text;
            var namaSiswa = TextNamaLengkap.Text;

            if (siswaId == string.Empty && namaSiswa != string.Empty)
            {
                var pesan = MessageBox.Show("Anda ingin membuat data baru ?", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (pesan != DialogResult.Yes)
                    return;
            }

            ClearInput();
            TabControlSiswa.SelectedTab = PagePersonal;
            TextNamaLengkap.Focus();
        }


        private void ButtonRefresh_Click(object? sender, EventArgs e)
        {
            RefreshData();
        }


        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            var SiswaStr = GridListSiswa.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (SiswaStr is null)
                return;

            var SiswaId = Convert.ToInt32(SiswaStr);
            GetSiswa(SiswaId);
            TabControlSiswa.SelectedIndex = 1;
        }

        #endregion


        #region SAVE

        private void SaveSiswa()
        {
            var SiswaId = SavePersonal();
            SaveSiswaRiwayat(SiswaId);
            SaveSiswaBeasiswa(SiswaId);
            SaveSiswaWali(SiswaId);
            SaveSiswaLulus(SiswaId);
        }

        private int SavePersonal()
        {
            var siswaId = TextIdSiswa.Text == string.Empty ? 0 : int.Parse(TextIdSiswa.Text);

            var siswa = new SiswaModel
            {

                SiswaId = siswaId,
                NIK = TextNIK.Text,
                NamaLengkap = TextNamaLengkap.Text,
                NamaPanggil = TextNamaPanggilan.Text,
                Gender = RadioLaki.Checked ? 1 : 0,
                TmpLahir = TextTempatLahir.Text,
                TglLahir = PickerTglLahir.Value,
                Agama = ComboAgama.SelectedItem.ToString() ?? string.Empty,
                Kewarganegaraan = RadioWni.Checked ? RadioWni.Text : RadioAsing.Text,
                AnakKe = (int)NumericAnakKe.Value,
                JmlhSdrKandung = (int)NumericSdrKandung.Value,
                JmlhSdrTiri = (int)NumericSdrTiri.Value,
                JmlhSdrAngkat = (int)NumericSdrAngkat.Value,
                YatimPiatu = ComboYatimPiatu.SelectedItem.ToString() ?? string.Empty,
                Bahasa = TextBahasa.Text,
                Alamat = TextAlamat.Text,
                NoTelp = TextNoHp.Text,
                TngglDengan = ComboTinggal.SelectedItem.ToString() ?? string.Empty,
                JrkKeSekolah = (int)NumericJarakKeSekolah.Value,
                TransportSekolah = TextTransportasi.Text,
                LokasiPhoto = string.Empty,
            };

            if (siswa.SiswaId == 0)
                siswaId = _siswaDal.Insert(siswa);
            else
                _siswaDal.Update(siswa);
            return siswaId;
        }

        private void SaveSiswaRiwayat(int SiswaId)
        {
            var GolDarah = string.Empty;
            if (RadioGolDarA.Checked)
                GolDarah = "A";
            if (RadioGolDarB.Checked)
                GolDarah = "B";
            if (RadioGolDarAB.Checked)
                GolDarah = "AB";
            if (RadioGolDarO.Checked)
                GolDarah = "O";

            var siswaRiwayat = new SiswaRiwayatModel
            {
                SiswaId = SiswaId,
                GolDarah = GolDarah,
                RiwayatPenyakit = TextRiwayat.Text,
                KelainanJasmani = TextKelainan.Text,
                TinggiBdn = (int)NumericTinggi.Value,
                BeratBdn = (int)NumericBerat.Value,
                LulusanDr = TextLulusanDr.Text,
                TglIjazah = PickerTglIjazah.Value,
                NoIjazah = TextNoIjazah.Text,
                LamaBljr = TextLamaBelajar.Text,
                PindahanDr = TextPindahanDr.Text,
                AlasanPindah = TextPindahanAlasan.Text,
                DiterimaTingkat = TextDiterimaTingkat.Text,
                KompKeahlian = TextDiterimaKeahlian.Text,
                TglDiterima = PickerDiterimaTgl.Value,
                Kesenian = TextKesenian.Text,
                Olahraga = TextOlahraga.Text,
                Organisasi = TextKemasyarakatan.Text,
                Hobi = TextHobi.Text,
                CitaCita = TextCitaCita.Text,
                TglTinggalSekolah = PickerMeninggalkanSekolah.Value,
                AlasanTinggal = TextAlasanMeninggalkan.Text,
                AkhirTamatBljr = PickerTamatBljr.Value,
                AkhirNoIjazah = TextIjazahNo.Text
            };

            var dataDB = _siswaRiwayatDal.GetData(SiswaId);
            if (dataDB is null)
                _siswaRiwayatDal.Insert(siswaRiwayat);
            else
                _siswaRiwayatDal.Update(siswaRiwayat);
        }

        private void SaveSiswaBeasiswa(int SiswaId)
        {
            var listBea = new List<SiswaBeasiswaModel>();
            _siswaBeasiswaDal.Delete(SiswaId);
            foreach (var item in _listBeasiswaBinding)
            {
                var newItem = new SiswaBeasiswaModel
                {
                    SiswaId = SiswaId,
                    Nomor = listBea.Count + 1,
                    Kelas = item.Kelas,
                    Tahun = item.Tahun,
                    AsalBeasiswa = item.AsalBeasiswa
                };
                if ($"{newItem.Kelas}{newItem.Tahun}" == string.Empty)
                    continue;

                listBea.Add(newItem);
            }
            _siswaBeasiswaDal.Insert(listBea);
        }

        private void SaveSiswaWali(int SiswaId)
        {
            var Ayah = new SiswaWaliModel
            {
                SiswaId = SiswaId,
                JenisWali = 0,
                Nama = TextNamaAyah.Text,
                TmpLahir = TextTmpLahirAyah.Text,
                TglLahir = PickerTglLahirAyah.Value,
                Agama = ComboAgamaAyah.SelectedItem.ToString() ?? string.Empty,
                Kewarga = RadioWniAyah.Checked ? RadioWniAyah.Text : RadioAsingAyah.Text,
                Pendidikan = TextPnddkanAyah.Text,
                Pekerjaan = TextPekerjaanAyah.Text,
                Penghasilan = (int)NumericPenghasilanAyah.Value,
                Alamat = TextAlamatAyah.Text,
                NoKK = TextNoKk.Text,
                NoTelp = TextNoTlpAyah.Text,
                StatusHidup = RadioHidupAyah.Checked ? RadioHidupAyah.Text : RadioMeningglAyah.Text,
                NIK = TextNikAyah.Text
            };

            var Ibu = new SiswaWaliModel
            {
                SiswaId = SiswaId,
                JenisWali = 1,
                Nama = TextNamaIbu.Text,
                TmpLahir = TextTmpLahirIbu.Text,
                TglLahir = PickerTglLahirIbu.Value,
                Agama = ComboAgamaIbu.SelectedItem.ToString() ?? string.Empty,
                Kewarga = RadioWniIbu.Checked ? RadioWniIbu.Text : RadioAsingIbu.Text,
                Pendidikan = TextPnddkanIbu.Text,
                Pekerjaan = TextPekerjaanIbu.Text,
                Penghasilan = (int)NumericPenghasilanIbu.Value,
                Alamat = TextAlamatIbu.Text,
                NoKK = string.Empty,
                NoTelp = TextNoTlpIbu.Text,
                StatusHidup = RadioHidupIbu.Checked ? RadioHidupIbu.Text : RadioMeningglIbu.Text,
                NIK = string.Empty

            };

            var Wali = new SiswaWaliModel
            {
                SiswaId = SiswaId,
                JenisWali = 2,
                Nama = TextNamaWali.Text,
                TmpLahir = TextTmpLahirWali.Text,
                TglLahir = PickerTglLahirWali.Value,
                Agama = ComboAgamaWali.SelectedItem.ToString() ?? string.Empty,
                Kewarga = RadioWniWali.Checked ? RadioWniWali.Text : RadioAsingWali.Text,
                Pendidikan = TextPnddkanWali.Text,
                Pekerjaan = TextPekerjaanWali.Text,
                Penghasilan = (int)NumericPenghasilanWali.Value,
                Alamat = TextAlamatWali.Text,
                NoKK = string.Empty,
                NoTelp = TextNoTeleponWali.Text,
                StatusHidup = string.Empty,
                NIK = string.Empty
            };

            var SiswaWali = new List<SiswaWaliModel>
            {
                Ayah,
                Ibu,
                Wali
            };

            _siswaWaliDal.Delete(SiswaId);
            _siswaWaliDal.Insert(SiswaWali);
        }

        private void SaveSiswaLulus(int SiswaId)
        {
            var siswalulus = new SiswaLulusModel
            {
                SiswaId = SiswaId,
                LanjutDi = TextMelanjutkanKe.Text,
                TglMulaiKerja = PickerTglBekerja.Value,
                NamaPerusahaan = TextNamaPerusahaan.Text,
                Penghasilan = (int)NumericPenghasilan.Value
            };

            var DataDB = _siswaLulusDal.GetData(SiswaId);
            if (DataDB is null)
                _siswaLulusDal.Insert(siswalulus);
            else
                _siswaLulusDal.Update(siswalulus);
        }

        #endregion


        #region  GET

        private void GetSiswa(int SiswaId)
        {
            ClearInput();
            TextIdSiswa.Text = SiswaId.ToString();
            GetSiswaPersonal(SiswaId);
            GetSiswaKesehatanPendidikan(SiswaId);
            GetSiswaWali(SiswaId);
            GetSiswaBeasiswa(SiswaId);
            GetSiswaLulus(SiswaId);
        }

        private void GetSiswaPersonal(int SiswaId)
        {
            var siswaPersonal = _siswaDal.GetData(SiswaId);
            if (siswaPersonal is null)
            {
                MessageBox.Show("Data tidak ditemukan");
                return;
            }

            TextNamaLengkap.Text = siswaPersonal.NamaLengkap;
            TextNamaPanggilan.Text = siswaPersonal.NamaPanggil;
            TextNIK.Text = siswaPersonal.NIK;

            if (siswaPersonal.Gender == 1)
                RadioLaki.Checked = true;
            else
                RadioPerempuan.Checked = true;

            foreach (var item in ComboAgama.Items)
            {
                if (item.ToString() == siswaPersonal.Agama)
                {
                    ComboAgama.SelectedItem = item;
                }
            }

            PickerTglLahir.Value = siswaPersonal.TglLahir;

            if (siswaPersonal.Kewarganegaraan == "WNI") RadioWni.Checked = true;
            if (siswaPersonal.Kewarganegaraan == "Asing") RadioAsing.Checked = true;

            NumericAnakKe.Value = siswaPersonal.AnakKe;
            NumericSdrKandung.Value = siswaPersonal.JmlhSdrKandung;
            NumericSdrTiri.Value = siswaPersonal.JmlhSdrTiri;
            NumericSdrAngkat.Value = siswaPersonal.JmlhSdrAngkat;

            foreach (var item in ComboYatimPiatu.Items)
            {
                if (item.ToString() == siswaPersonal.YatimPiatu)
                {
                    ComboYatimPiatu.SelectedItem = item;
                }
            }

            TextBahasa.Text = siswaPersonal.Bahasa;
            TextAlamat.Text = siswaPersonal.Alamat;
            TextNoHp.Text = siswaPersonal.NoTelp;

            foreach (var item in ComboTinggal.Items)
            {
                if (item.ToString() == siswaPersonal.TngglDengan)
                {
                    ComboTinggal.SelectedItem = item;
                }
            }

            NumericJarakKeSekolah.Value = siswaPersonal.JrkKeSekolah;
            TextTransportasi.Text = siswaPersonal.TransportSekolah;
        }

        private void GetSiswaKesehatanPendidikan(int SiswaId)
        {
            var siswaRiwayat = _siswaRiwayatDal.GetData(SiswaId);
            if (siswaRiwayat == null)
                return;

            if (siswaRiwayat.GolDarah == "A") RadioGolDarA.Checked = true;
            if (siswaRiwayat.GolDarah == "B") RadioGolDarB.Checked = true;
            if (siswaRiwayat.GolDarah == "AB") RadioGolDarAB.Checked = true;
            if (siswaRiwayat.GolDarah == "O") RadioGolDarO.Checked = true;


            TextRiwayat.Text = siswaRiwayat.RiwayatPenyakit;
            TextKelainan.Text = siswaRiwayat.KelainanJasmani;
            NumericTinggi.Value = siswaRiwayat.TinggiBdn;
            NumericBerat.Value = siswaRiwayat.BeratBdn;
            TextLulusanDr.Text = siswaRiwayat.LulusanDr;
            PickerTglIjazah.Value = siswaRiwayat.TglIjazah;
            TextNoIjazah.Text = siswaRiwayat.NoIjazah;
            TextLamaBelajar.Text = siswaRiwayat.LamaBljr;
            TextPindahanDr.Text = siswaRiwayat.PindahanDr;
            TextPindahanAlasan.Text = siswaRiwayat.AlasanPindah;
            TextDiterimaTingkat.Text = siswaRiwayat.DiterimaTingkat;
            TextDiterimaKeahlian.Text = siswaRiwayat.KompKeahlian;
            PickerDiterimaTgl.Value = siswaRiwayat.TglDiterima;
            TextKesenian.Text = siswaRiwayat.Kesenian;
            TextOlahraga.Text = siswaRiwayat.Olahraga;
            TextKemasyarakatan.Text = siswaRiwayat.Organisasi;
            TextHobi.Text = siswaRiwayat.Hobi;
            TextCitaCita.Text = siswaRiwayat.CitaCita;
            PickerMeninggalkanSekolah.Value = siswaRiwayat.TglTinggalSekolah;
            TextAlasanMeninggalkan.Text = siswaRiwayat.AlasanTinggal;
            PickerTamatBljr.Value = siswaRiwayat.AkhirTamatBljr;
            TextIjazahNo.Text = siswaRiwayat.AkhirNoIjazah;
        }

        private void GetSiswaWali(int SiswaId)
        {
            var siswaWali = _siswaWaliDal.ListData(SiswaId);
            if (siswaWali == null)
                return;

            //AYAH
            var ayah = siswaWali.FirstOrDefault(x => x.JenisWali == 0);
            if (ayah is not null)
            {
                TextNamaAyah.Text = ayah.Nama;
                TextTmpLahirAyah.Text = ayah.TmpLahir;
                PickerTglLahirAyah.Value = ayah.TglLahir;

                foreach (var item in ComboAgamaAyah.Items)
                {
                    if (item.ToString() == ayah.Agama)
                        ComboAgamaAyah.SelectedItem = item;
                }

                if (ayah.Kewarga == "WNI") RadioWniAyah.Checked = true;
                if (ayah.Kewarga == "Asing") RadioAsingAyah.Checked = true;

                TextPnddkanAyah.Text = ayah.Pendidikan;
                TextPekerjaanAyah.Text = ayah.Pekerjaan;
                NumericPenghasilanAyah.Value = ayah.Penghasilan;
                TextAlamatAyah.Text = ayah.Alamat;
                TextNoKk.Text = ayah.NoKK;
                TextNoTlpAyah.Text = ayah.NoTelp;

                if (ayah.StatusHidup == "Masih Hidup") RadioHidupAyah.Checked = true;
                if (ayah.StatusHidup == "Sudah Meninggal") RadioMeningglAyah.Checked = true;

                TextNikAyah.Text = ayah.NIK;
            }


            //IBU
            var ibu = siswaWali.FirstOrDefault(x => x.JenisWali == 1);
            if (ibu is not null)
            {
                TextNamaIbu.Text = ibu.Nama;
                TextTmpLahirIbu.Text = ibu.TmpLahir;
                PickerTglLahirIbu.Value = ibu.TglLahir;

                foreach (var item in ComboAgamaIbu.Items)
                {
                    if (item.ToString() == ibu.Agama)
                        ComboAgamaIbu.SelectedItem = item;
                }

                if (ibu.Kewarga == "WNI") RadioWniIbu.Checked = true;
                if (ibu.Kewarga == "Asing") RadioAsingIbu.Checked = true;

                TextPnddkanIbu.Text = ibu.Pendidikan;
                TextPekerjaanIbu.Text = ibu.Pekerjaan;
                NumericPenghasilanIbu.Value = ibu.Penghasilan;
                TextAlamatIbu.Text = ibu.Alamat;
                TextNoTlpIbu.Text = ibu.NoTelp;

                if (ibu.StatusHidup == "Masih Hidup") RadioHidupIbu.Checked = true;
                if (ibu.StatusHidup == "Sudah Meninggal") RadioMeningglIbu.Checked = true;


            }



            //WALi
            var wali = siswaWali.FirstOrDefault(x => x.JenisWali == 2);
            if (wali is not null)
            {
                TextNamaWali.Text = wali.Nama;
                TextTmpLahirWali.Text = wali.TmpLahir;
                PickerTglLahirWali.Value = wali.TglLahir;

                foreach (var item in ComboAgamaWali.Items)
                {
                    if (item.ToString() == wali.Agama)
                        ComboAgamaWali.SelectedItem = item;
                }

                if (wali.Kewarga == "WNI") RadioWniWali.Checked = true;
                if (wali.Kewarga == "Asing") RadioAsingWali.Checked = true;

                TextPnddkanWali.Text = wali.Pendidikan;
                TextPekerjaanWali.Text = wali.Pekerjaan;
                NumericPenghasilanWali.Value = wali.Penghasilan;
                TextAlamatWali.Text = wali.Alamat;
                TextNoTeleponWali.Text = wali.NoTelp;
            }
        }

        private void GetSiswaBeasiswa(int SiswaId)
        {
            var listBeasiswa = _siswaBeasiswaDal.ListData(SiswaId)?.ToList();
            if (listBeasiswa is null)
                return;

            _listBeasiswaBinding.Clear();
            listBeasiswa.ForEach(x => _beasiswaBinding.Add(new BeasiswaDto
            {
                Nomor = x.Nomor,
                Kelas = x.Kelas,
                Tahun = x.Tahun,
                AsalBeasiswa = x.AsalBeasiswa
            }));
        }

        private void GetSiswaLulus(int SiswaId)
        {
            var siswaLulus = _siswaLulusDal.GetData(SiswaId);
            if (siswaLulus == null) return;

            TextMelanjutkanKe.Text = siswaLulus.LanjutDi;
            PickerTglBekerja.Value = siswaLulus.TglMulaiKerja;
            TextNamaPerusahaan.Text = siswaLulus.NamaPerusahaan;
            NumericPenghasilan.Value = siswaLulus.Penghasilan;
        }

        #endregion


        #region  CLEAR & REFRESH

        public void ClearInput()
        {
            // Personal
            TextIdSiswa.Clear();
            TextNamaLengkap.Clear();
            TextNamaPanggilan.Clear();
            TextTempatLahir.Clear();
            PickerTglLahir.Value = new DateTime(2000, 1, 1);
            ComboAgama.SelectedIndex = 0;
            NumericAnakKe.Value = 0;
            NumericSdrKandung.Value = 0;
            NumericSdrTiri.Value = 0;
            NumericSdrAngkat.Value = 0;
            ComboYatimPiatu.SelectedIndex = 0;
            TextBahasa.Clear();
            TextAlamat.Clear();
            TextNoHp.Clear();
            ComboTinggal.SelectedIndex = 0;
            NumericJarakKeSekolah.Value = 0;
            TextTransportasi.Clear();


            // Kesehatan & Pendidikan
            TextRiwayat.Clear();
            TextKelainan.Clear();
            NumericTinggi.Value = 0;
            NumericBerat.Value = 0;
            TextLulusanDr.Clear();
            PickerTglIjazah.Value = new DateTime(2000, 1, 1);
            TextNoIjazah.Clear();
            TextLamaBelajar.Clear();
            TextPindahanDr.Clear();
            TextPindahanAlasan.Clear();
            TextDiterimaTingkat.Clear();
            TextDiterimaKeahlian.Clear();
            PickerDiterimaTgl.Value = new DateTime(2000, 1, 1);
            TextKesenian.Clear();
            TextOlahraga.Clear();
            TextKemasyarakatan.Clear();
            TextHobi.Clear();
            TextCitaCita.Clear();
            PickerMeninggalkanSekolah.Value = new DateTime(2000, 1, 1);
            TextAlasanMeninggalkan.Clear();
            PickerTamatBljr.Value = new DateTime(2000, 1, 1);
            TextIjazahNo.Clear();


            // Ayah
            TextNamaAyah.Clear();
            TextTmpLahirAyah.Clear();
            PickerTglLahirAyah.Value = new DateTime(2000, 1, 1);
            ComboAgamaAyah.SelectedIndex = 0;
            TextPnddkanAyah.Clear();
            TextPekerjaanAyah.Clear();
            NumericPenghasilanAyah.Value = 0;
            TextAlamatAyah.Clear();
            TextNoKk.Clear();
            TextNoTlpAyah.Clear();
            TextNikAyah.Clear();


            //Ibu
            TextNamaIbu.Clear();
            TextTmpLahirIbu.Clear();
            PickerTglLahirIbu.Value = new DateTime(2000, 1, 1);
            ComboAgamaIbu.SelectedIndex = 0;
            TextPnddkanIbu.Clear();
            TextPekerjaanIbu.Clear();
            NumericPenghasilanIbu.Value = 0;
            TextAlamatIbu.Clear();
            TextNoTlpIbu.Clear();


            // Wali
            TextNamaWali.Clear();
            TextTmpLahirWali.Clear();
            PickerTglLahirWali.Value = new DateTime(2000, 1, 1);
            ComboAgamaWali.SelectedIndex = 0;
            TextPnddkanWali.Clear();
            TextPekerjaanWali.Clear();
            NumericPenghasilanWali.Value = 0;
            TextAlamatWali.Clear();
            TextNoTeleponWali.Clear();


            // Lulus
            TextMelanjutkanKe.Clear();
            PickerTglBekerja.Value = new DateTime(2000, 1, 1);
            TextNamaPerusahaan.Clear();
            NumericPenghasilan.Value = 0;
        }
         
        private void RefreshData()
        {
            var listSiswa = _siswaDal.ListData() ?? new List<SiswaModel>();
            var DataSiswa = listSiswa.Select(x => new SiswaDto
            {
                SiswaId = x.SiswaId,
                NamaLengkap = x.NamaLengkap,
                TglLahir = x.TglLahir,
                Gender = x.Gender == 1 ? "Laki-laki" : "Perempuan",
                Alamat = x.Alamat
            }).ToList();

            GridListSiswa.DataSource = DataSiswa;
            CustomGrid();
            GridListSiswa.Refresh();
        }

        #endregion


        private void UpdateGambar()
        {
            var siswaCek = _siswaDal.GetData(Convert.ToInt32(LabelSiswaId.Text));

            if (siswaCek is null)
            {
                PictureSiswa.Image = null;
                _pilihGambar = string.Empty;
                return;
            }
            siswaCek.LokasiPhoto = _pilihGambar;
            _siswaDal.Update(siswaCek);
        }

        private void CustomGrid()
        {
            GridListSiswa.Columns["SiswaId"].HeaderText = "Id Siswa";
            GridListSiswa.Columns["NamaLengkap"].HeaderText = "Nama Lengkap";
            GridListSiswa.Columns["TglLahir"].HeaderText = "Tanggal lahir";
            GridListSiswa.Columns["Gender"].HeaderText = "Jenis Kelamin";
            GridListSiswa.Columns["Alamat"].HeaderText = "Alamat";

            GridListSiswa.Columns["SiswaId"].Width = 100 ;
            GridListSiswa.Columns["NamaLengkap"].Width = 200;
            GridListSiswa.Columns["TglLahir"].Width = 100; 
            GridListSiswa.Columns["Gender"].Width = 100;
            GridListSiswa.Columns["Alamat"].Width = 200;
        }


        public class SiswaDto
        {
            public int SiswaId { get; set; }
            public string NamaLengkap { get; set; }
            public DateTime TglLahir { get; set; }
            public string Gender { get; set; }
            public string Alamat { get; set; }
        }


        public class BeasiswaDto
        {
            public int Nomor { get; set; }
            public string Kelas { get; set; }
            public string Tahun { get; set; }
            public string AsalBeasiswa { get; set; }
        }

        private void GridListData_SelectionChanged(object sender, EventArgs e)
        {
            if (GridListSiswa.SelectedRows.Count >0)
            {
                DataGridViewRow SelectRow = GridListSiswa.SelectedRows[0];

                string SiswaId = SelectRow.Cells[0].Value.ToString();
                string NamaSiswa = SelectRow.Cells[1].Value.ToString();

                LabelSiswaId.Text = SiswaId;
                LabelSiswaNama.Text = NamaSiswa;


                var siswa = _siswaDal.GetData(Convert.ToInt32(SiswaId));
                _pilihGambar = siswa?.LokasiPhoto ?? string.Empty;

                if (_pilihGambar != string.Empty)
                    PictureSiswa.Image = Image.FromFile(_pilihGambar);
                else
                    PictureSiswa.Image = null;

            }
        }
    }
}