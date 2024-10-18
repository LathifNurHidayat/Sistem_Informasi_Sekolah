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
    public class AbsensiDetilDal
    {
        public IEnumerable<AbsensiDetilModel> ListData ()
        {
            const string sql = @"
                    SELECT 
                        aa.AbsensiId, aa.NoUrut, aa.SiswaId
                        bb.NamaLengkap AS SiswaName, aa.StatusAbsensi, aa.Keterangan
                    FROM 
                        AbsensiDetil aa
                    LEFT JOIN 
                        Siswa bb ON aa.SiswaId = bb.SiswaId";

            using var Conn = new SqlConnection(ConnStringHelper.Get());

            Conn.Query<AbsensiDetilModel>(sql);
        }

        public void Insert (AbsensiDetilModel absen)
        {
            const string sql = @"
                    INSERT INTO AbsensiDetil
                        (AbsensiId, NoUrut, SiswaId, StatusAbsensi, Keterangan)
                    VALUES 
                        (@AbsensiId, @NoUrut, @SiswaId, @StatusAbsensi, @Keterangan)";

            var Dp = new DynamicParameters();
            Dp.Add("@AbsensiId", absen.AbsensiId, DbType.Int32);
            Dp.Add("@NoUrut", absen.NoUrut, DbType.Int32);
            Dp.Add("@SiswaId", absen.SiswaId, DbType.Int32);
            Dp.Add("@StatusAbsensi", absen.StatusAbsen, DbType.Int32);
            Dp.Add("@Keterangan", absen.Keterangan, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);

        }
    }
}
