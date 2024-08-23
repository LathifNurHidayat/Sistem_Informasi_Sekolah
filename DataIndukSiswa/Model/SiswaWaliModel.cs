using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.Model
{
    public class SiswaWaliModel
    {

        public int SiswaId { get; set; }
        public int JenisWali { get; set; }
        public string Nama { get; set; }
        public string TmpLahir { get; set; }
        public DateTime TglLahir { get; set; }
        public string Agama { get; set; }
        public string Kewarga { get; set; }
        public string Pendidikan { get; set; }
        public string Pekerjaan { get; set; }
        public decimal Penghasilan { get; set; }
        public string Alamat { get; set; }
        public string NoKK { get; set; }
        public string NoTelp { get; set; }
        public string StatusHidup { get; set; }
        public string NIK { get; set; }
    }
}
