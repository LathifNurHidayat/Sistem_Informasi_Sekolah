using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class JadwalPelajaranModel
    {
        public int JadwalId { get; set; }
        public int KelasId { get; set; }
        public string Hari { get; set; }
        public string JenisJadwal { get; set; }
        public string JamMulai { get; set; }      
        public string JamSelesai { get; set; }
        public int MapelId { get; set; }
        public int GuruId { get; set; }
        public string Keterangan { get; set; }
    }
}