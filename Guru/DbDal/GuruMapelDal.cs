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
    public class GuruMapelDal
    {
        public void Insert(IEnumerable<GuruMapelModel> listMapel)
        {
            const string sql = @"
                INSERT INTO GuruMapel
                    (GuruId, MapelId)
                VALUES 
                    (@GuruId, @MapelId)";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            
            foreach (var item in listMapel)
            {
                var Dp  = new DynamicParameters();
                Dp.Add("@GuruId", item.GuruId);
                Dp.Add("@MapelId", item.MapelId);

                Conn.Execute(sql, Dp);
            }            
        }

        public void Delete(int GuruId)
        {
            const string sql = @"
                DELETE FROM Guru 
                WHERE GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", GuruId);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public IEnumerable<GuruMapelModel> GetData(int GuruId)
        {
            const string sql = @"
                SELECT 
                    aa.GuruId,  aa.MapelId,
                    ISNULL(bb.MapelName, '') AS MapelName
                FROM
                    GuruMapel aa    LEFT JOIN    Mapel bb
                    ON aa.MapelId = bb.MapelId
                WHERE 
                    GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", GuruId);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<GuruMapelModel>(sql, Dp).ToList();
        }
    }
}
 