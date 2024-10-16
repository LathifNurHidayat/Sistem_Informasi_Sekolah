using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class KelasSiswaDal
    {
        public IEnumerable<KelasSiswaModel> ListData ()
        {
            const string sql = @"
                    SELECT
                        aa.KelasId, bb.KelasName, aa.TahunAjaran, 
                        aa.GuruId AS WaliKelasId , cc.GuruName AS WaliKelasName
                    FROM 
                        KelasSiswa aa 
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId
";
        }
    }
}
