using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.ConnectDB
{
    public class SiswaLulusModel
    {
        public int SiswaId { get; set;}
        public string LanjutDi { get; set; }
        public DateTime TglMulaiKerja { get; set; }
        public string NamaPerusahaan { get; set; }
        public decimal Penghasilan { get; set; }

    }
}
