using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.Model
{
    public class SiswaRiwayatModel
    {


        public int SiswaId { get; set; }
        public string GolDarah { get; set; }
        public string RiwayatPenyakit { get; set; }
        public string KelainanJasmani { get; set; }
        public int TinggiBdn { get; set; }
        public int BeratBdn { get; set; }
        public string LulusanDr { get; set; }
        public DateTime TglIjazah { get; set; }
        public string NoIjazah { get; set; }
        public string LamaBljr { get; set; }
        public string PindahanDr { get; set; }
        public string AlasanPindah { get; set; }
        public string DiterimaTingkat { get; set; }
        public string KompKeahlian { get; set; }
        public DateTime TglDiterima { get; set; }
        public string Kesenian { get; set; }
        public string Olahraga { get; set; }
        public string Organisasi { get; set; }
        public string Hobi { get; set; }
        public string CitaCita { get; set; }
        public DateTime TglTinggalSekolah { get; set; }
        public string AlasanTinggal { get; set; }
        public DateTime AkhirTamatBljr { get; set; }
        public string AkhirNoIjazah { get; set; }

    }
}
