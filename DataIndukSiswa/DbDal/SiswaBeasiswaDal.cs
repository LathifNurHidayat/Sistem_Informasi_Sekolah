using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal
{
    public class SiswaBeasiswaDal
    {
        public void Insert(IEnumerable<SiswaBeasiswaModel> siswaBeasiswa)
        {
            const string Sql = @"
            INSERT INTO SiswaBeasiswa
                (
                    SiswaId, Tahun, Kelas, AsalBeasiswa
                )
            VALUES 
                (
                    @SiswaId, @Tahun, @Kelas, @AsalBeasiswa
                )";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            foreach (var item in siswaBeasiswa)
            {
                var Dp = new DynamicParameters();
                Dp.Add("@SiswaId", item.SiswaId);
                Dp.Add("@Tahun", item.Tahun);
                Dp.Add("@Kelas", item.Kelas);
                Dp.Add("@AsalBeasiswa", item.AsalBeasiswa);

                Conn.Execute(Sql,Dp);
            }
        }


        public void Delete(int SiswaId)
        {
            const string Sql = @"
            DELETE FROM 
                SiswaBeasiswa
            WHERE 
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId);


            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql,Dp);
        }


        public IEnumerable<SiswaBeasiswaModel> ListData(int SiswaId)
        {
            const string Sql = @"
            SELECT 
                SiswaId, Tahun, Kelas, AsalBeasiswa
            FROM 
                SiswaBeasiswa
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, System.Data.DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaBeasiswaModel>(Sql,Dp);

        }
    }
}
