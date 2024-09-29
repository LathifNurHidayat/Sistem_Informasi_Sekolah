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
        public int JenisJadwal { get; set; }
        public string Hari { get; set; }
        public DateTime JamMulai { get; set; }      
        public DateTime JamSelesai { get; set; }
        public int MapelId { get; set; }
        public int GuruId { get; set; }
    }
}