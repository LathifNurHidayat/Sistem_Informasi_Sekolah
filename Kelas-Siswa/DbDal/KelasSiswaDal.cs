using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Sistem_Informasi_Sekolah
{
    public class KelasSiswaDal
    {
        public IEnumerable<KelasSiswaModel> ListData ()
        {
            const string sql = @"
                    SELECT
                        aa.KelasId, aa.TahunAjaran, 
                        aa.WaliKelasId,
                        ISNULL( bb.KelasName, ''),
                        ISNULL( cc.GuruName, '') AS WaliKelasName
                    FROM 
                        KelasSiswa aa 
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Guru cc ON aa.WaliKelasId = cc.GuruId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());

            return Conn.Query<KelasSiswaModel>(sql);
        }


        public void Insert (KelasSiswaModel siswa)
        {
            const string sql = @"
                    INSERT INTO KelasSiswa
                        (KelasId, TahunAjaran, WaliKelasId)
                            
                    OUTPUT INSERTED.KelasId                        

                    VALUES 
                        (@KelasId, @TahunAjaran, @WaliKelasId)";


            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", siswa.KelasId, DbType.Int32);
            Dp.Add("@TahunAjaran", siswa.TahunAjaran, DbType.String);
            Dp.Add("@WaliKelasId", siswa.WaliKelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.QuerySingle<int>(sql, Dp);  
        }


        public KelasSiswaModel GetData(int kelasId)
        {
            const string sql = @"
                    SELECT
                        aa.KelasId, aa.TahunAjaran, 
                        aa.WaliKelasId ,
                        ISNULL( bb.KelasName, ''),
                        ISNULL( cc.GuruName, '') WaliKelasName
                    FROM 
                        KelasSiswa aa 
                        LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                        LEFT JOIN Guru cc ON aa.WaliKelasId = cc.GuruId
                    WHERE 
                        aa.KelasId = @KelasId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            var result = Conn.Query<KelasSiswaModel>(sql, dp).FirstOrDefault();
            return result;
        }

    }
}
