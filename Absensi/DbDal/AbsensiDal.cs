using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class AbsensiDal
    {
        public int GetAbsensiId(AbsensiModel absen)
        {
            const string sql = @"
        SELECT 
            AbsensiId
        FROM 
            Absensi
        WHERE 
            KelasId = @KelasId AND Tanggal = @Tanggal AND
            Jam = @Jam AND MapelId = @MapelId AND GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", absen.KelasId, DbType.Int32);
            Dp.Add("@Tanggal", absen.Tanggal, DbType.DateTime);
            Dp.Add("@Jam", absen.Jam, DbType.String);  
            Dp.Add("@MapelId", absen.MapelId, DbType.Int32);
            Dp.Add("@GuruId", absen.GuruId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<int>(sql, Dp); 
        }



        public int Insert (AbsensiModel absen)
        {
            const string sql = @"
                    INSERT INTO Absensi
                        (AbsensiId, Tanggal, Jam, 
                        KelasId, MapelId, GuruId)

                    OUTPUT INSERTED.AbsensiId

                    VALUES
                        (@AbsensiId, @Tanggal, @Jam, 
                        @KelasId, @MapelId, @GuruId)";

            var Dp = new DynamicParameters();
            Dp.Add("@AbsensiId", absen.AbsensiId, DbType.Int32);
            Dp.Add("@Tanggal", absen.Tanggal, DbType.DateTime);
            Dp.Add("@Jam", absen.Jam, DbType.Time);
            Dp.Add("@KelasId", absen.KelasId, DbType.Int32);
            Dp.Add("@MapelId", absen.MapelId, DbType.Int32);
            Dp.Add("@GuruId", absen.GuruId, DbType.Int32);

            using var Conn = new SqlConnection (ConnStringHelper.Get());
            return Conn.QuerySingle<int>(sql, Dp);
        }
    }
}
