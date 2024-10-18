using Sistem_Informasi_Sekolah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class AbsensiDetilModel
    {
        public int AbsensiId { get; set; }
        public int NoUrut { get; set; }
        public int SiswaId { get; set; }
        public string SiswaName { get; set; }
        public int StatusAbsen { get; set; }
        public string Keterangan { get; set; }

    }
}