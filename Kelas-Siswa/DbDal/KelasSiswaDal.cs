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
                    LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());

            return Conn.Query<KelasSiswaModel>(sql);
        }


        public

    }
}
