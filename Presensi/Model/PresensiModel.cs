using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class PresensiModel
    {
        public int PresensiId { get; set; }
        public DateTime Tanggal { get; set; }
        public TimeSpan Jam { get; set; }


        public int KelasId { get; set; }
        public string KelasName { get; set; }
        public int MapelId { get; set; }
        public string MapelName { get; set; }
        public int GuruId { get; set; }
        public string GuruName { get; set; }    


        public int SiswaId { get; set; }
        public string SiswaName { get; set; }
        public int Kehadiran { get; set; }
        public string Keterangan { get; set; }
    }
}