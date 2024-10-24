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
    public class KelasSiswaDetilDal
    {
        public IEnumerable<KelasSiswaDetilModel> ListData()
        {
            const string sql = @"
                    SELECT 
                        aa.KelasId, aa.SiswaId, ISNULL ( bb.NamaLengkap , '')AS SiswaName
                    FROM KelasSiswaDetil aa
                        LEFT JOIN Siswa bb ON aa.SiswaId = bb.SiswaId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<KelasSiswaDetilModel>(sql);
        }

        public IEnumerable<KelasSiswaDetilModel> ListData(int kelasId)
        {
            const string sql = @"
                    SELECT 
                        aa.KelasId, aa.SiswaId, ISNULL ( bb.NamaLengkap , '')AS SiswaName
                    FROM 
                        KelasSiswaDetil aa
                        LEFT JOIN Siswa bb ON aa.SiswaId = bb.SiswaId
                    WHERE 
                        aa.KelasId = @KelasId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<KelasSiswaDetilModel>(sql, new { KelasId = kelasId });
        }

        public void Insert(KelasSiswaDetilModel kelas)
        {
            const string sql = @"
                    INSERT INTO KelasSiswaDetil 
                        (KelasId, SiswaId)
                    VALUES 
                        (@KelasId, @SiswaId)";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", kelas.KelasId, DbType.Int32);
            Dp.Add("@SiswaId", kelas.SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }


        public void Delete(int kelasId)
        {
            const string sql = @"
                    DELETE FROM 
                        KelasSiswaDetil 
                    WHERE 
                        KelasId = @KelasId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, new { kelasId = kelasId });
        }
    }
}
