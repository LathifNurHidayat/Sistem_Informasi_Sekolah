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
    public class MataPelajaranDal
    {
        public int Insert(MataPelajaranModel mapel)
        {
            const string sql = @"
                INSERT  INTO MataPelajaran
                    (MapelName)
                OUTPUT inserted.MapelId
                VALUES
                    (@Mapelname)";

            var Dp = new DynamicParameters();
            Dp.Add("@MapelName", mapel.MapelName, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QuerySingle<int>(sql, Dp);
        }

        public void Update(MataPelajaranModel model)
        {
            const string sql = @"
                UPDATE 
                    MataPelajaran
                SET
                    MapelName = @MapelName
                WHERE 
                    MapelId = @MapelId";

            var Dp = new DynamicParameters();
            Dp.Add("@MapelId", model.MapelId, DbType.Int32);
            Dp.Add("@MapelName", model.MapelName, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Delete(int MapelId)
        {
            const string sql = "DELETE FROM MataPelajaran WHERE MapelId = @MapelId";

            var Dp = new DynamicParameters();
            Dp.Add("@MapelId", MapelId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public IEnumerable<MataPelajaranModel> ListData()
        {
            const string sql = "SELECT * FROM MataPelajaran";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<MataPelajaranModel>(sql);
        }

        public MataPelajaranModel? GetData(int MapelId)
        {
            const string sql = @"
                SELECT 
                    MapelId, MapelName 
                FROM MataPelajaran 
                    WHERE MapelId = @MapelId";

            var Dp = new DynamicParameters();
            Dp.Add("@MapelId", MapelId);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<MataPelajaranModel>(sql, Dp);
        }
    }
}
