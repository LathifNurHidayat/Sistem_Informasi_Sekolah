using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistem_Informasi_Sekolah.ConnHelper;

namespace Sistem_Informasi_Sekolah
{
    public class KelasDal
    {
        public void Insert(KelasModel kelas)
        {
            const string sql = @"
                INSERT INTO Kelas
                    (KelasName, KelasTingkat, JurusanId)
                VALUES
                    (@KelasName, @KelasTingkat, @JurusanId)";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasName", kelas.KelasName, DbType.String);
            Dp.Add("@KelasTingkat", kelas.KelasTingkat, DbType.Int16);
            Dp.Add("@JurusanId", kelas.JurusanId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Update(KelasModel kelas)
        {
            const string sql = @"
                UPDATE Kelas SET 
                    KelasName = @KelasName,
                    KelasTingkat = @KelasTingkat,
                    JurusanId = @JurusanId
                WHERE
                    KelasId = @KelasId";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasName", kelas.KelasName, DbType.String);
            Dp.Add("@KelasTingkat", kelas.KelasTingkat, DbType.Int16);
            Dp.Add("@JurusanId", kelas.JurusanId, DbType.Int32);
            Dp.Add("@KelasId", kelas.KelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Delete(int KelasId)
        {
            const string sql = "DELETE FROM Kelas WHERE KelasId = @KelasId";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", KelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public IEnumerable<KelasModel> ListData()
        {
            const string sql = @"
                SELECT 
                    KelasId, KelasName, KelasTingkat  
                FROM 
                    Kelas";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<KelasModel>(sql);
        }

        public KelasModel? GetData(int KelasId)
        {
            const string sql = @"
                SELECT 
                    KelasId, KelasName, KelasTingkat, JurusanId
                FROM 
                    Kelas
                WHERE
                    KelasId = @KelasId";

            var Dp = new DynamicParameters();
            Dp.Add("KelasId", KelasId, DbType.Int16);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<KelasModel>(sql, Dp);
        }
    }
}
