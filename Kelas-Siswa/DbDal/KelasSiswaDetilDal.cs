using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class KelasSiswaDetilDal
    {
        public IEnumerable<KelasSiswaDetilModel> ListData()
        {
            const string sql = @"
                    SELECT 
                        aa.KelasId, aa.NoUrut, aa.SiswaId, 
                        bb.NamaLengkap, aa.StatusAbsen, aa.Keterangan
                    FROM 
                        KelasSiswaDetil aa
                    LEFT JOIN Siswa bb ON aa.SiswaId = bb.SiswaId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());

            return Conn.Query<KelasSiswaDetilModel>(sql);
        }
    }
}
