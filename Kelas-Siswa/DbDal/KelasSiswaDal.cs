using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public void Update (KelasSiswaModel siswa)
        {
            const string sql = @"
                    UPDATE 
                        KelasSiswa
                    SET 
                        KelasId = @KelasId,
                        TahunAjaran = @TahunAjaran,
                        WaliKelasId = @WaliKelasId
                    WHERE 
                        KelasId = @KelasId";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", siswa.KelasId, DbType.Int32);
            Dp.Add("@TahunAjaran", siswa.TahunAjaran, DbType.String);
            Dp.Add("@WaliKelasId", siswa.WaliKelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

    }
}
