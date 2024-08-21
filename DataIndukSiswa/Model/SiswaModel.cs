using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.Model
{
    public class SiswaModel
    {
        public int SiswaId { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaPanggil { get; set; }
        public int Gender { get; set; }
        public string TmpLahir { get; set; }
        public DateTime TglLahir { get; set; }
        public string Agama { get; set; }
        public string Kewarganegaraan { get; set; }
        public string NIK { get; set; }
        public int AnakKe { get; set; }
        public int JmlhSdrKandung { get; set; }
        public int JmlhSdrTiri { get; set; }
        public int JmlhSdrAngkat { get; set; }
        public string YatimPiatu { get; set; }
        public string Bahasa { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public string TngglDengan { get; set; }
        public int JrkKeSekolah { get; set; }
        public string TransportSekolah { get; set; }
    }
}
