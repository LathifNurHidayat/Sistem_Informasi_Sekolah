using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal
{
    public class SiswaWaliDal
    {
        public void Insert(IEnumerable<SiswaWaliModel> siswaWali)
        {
            const string sql = @"
            INSERT INTO SiswaWali 
                    (SiswaId, JenisWali, Nama, TmpLahir, TglLahir, Agama, 
                    Kewarga, Pendidikan, Pekerjaan, Penghasilan,    
                    Alamat, NoKK, NoTelp, StatusHidup, NIK)
            VALUES     
                    (@SiswaId, @JenisWali, @Nama, @TmpLahir, @TglLahir, @Agama, 
                    @Kewarga, @Pendidikan, @Pekerjaan, @Penghasilan, 
                    @Alamat, @NoKK, @NoTelp, @StatusHidup, @NIK)";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            foreach (var item in siswaWali) 
            {
                var Dp = new DynamicParameters();
                Dp.Add("@SiswaId", item.SiswaId, System.Data.DbType.Int32);
                Dp.Add("@JenisWali", item.JenisWali, DbType.String);
                Dp.Add("@Nama", item.Nama, DbType.String);
                Dp.Add("@TmpLahir", item.TmpLahir, DbType.String);
                Dp.Add("@TglLahir", item.TglLahir, DbType.DateTime);
                Dp.Add("@Agama", item.Agama, DbType.String);
                Dp.Add("@Kewarga", item.Kewarga, DbType.String);
                Dp.Add("@Pendidikan", item.Pendidikan, DbType.String);
                Dp.Add("@Pekerjaan", item.Pekerjaan, DbType.String);
                Dp.Add("@Penghasilan", item.Penghasilan, DbType.Decimal);
                Dp.Add("@Alamat", item.Alamat, DbType.String);
                Dp.Add("@NoKK", item.NoKK, DbType.String);
                Dp.Add("@NoTelp", item.NoTelp, DbType.String);
                Dp.Add("@StatusHidup", item.StatusHidup, DbType.String);
                Dp.Add("@NIK", item.NIK, DbType.String);
                conn.Execute(sql, Dp);
            }
        }


        public void Delete(int SiswaId)
        {
            const string Sql = @"
            DELETE FROM
                SiswaWali
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }


        public IEnumerable<SiswaWaliModel> ListData(int SiswaId)
        {
            const string Sql = @"
            SELECT 
                SiswaId, JenisWali, Nama, TmpLahir, TglLahir, Agama, 
                Kewarga, Pendidikan, Pekerjaan, Penghasilan,    
                Alamat, NoKK, NoTelp, StatusHidup, NIK
            FROM 
                SiswaWali
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaWaliModel>(Sql, Dp);
        }
    }
}
