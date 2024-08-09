using Dapper;
using Sistem_Informasi_Sekolah.ConnectDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DbDal
{
    public class SiswaDal
    {
        private const string _constString = "Server = (local); Database = Sekolahku ; Trusted_Connection = True ; TrustServerCertificate = True";

        public IEnumerable<SiswaModel> ListSiswa()
        {
            const string sql = @"Select * from Siswa";


            using var conn = new SqlConnection(_constString);
            var listSiswa = conn.Query<SiswaModel>(sql);
            return listSiswa;
        }


        public IEnumerable<SiswaRiwayatModel> ListSiswaRiwayat()
        {
            const string sql = @"Select * from SiswaRiwayat";


            using var conn = new SqlConnection(_constString);
            var listRiwayat = conn.Query<SiswaRiwayatModel>(sql);
            return listRiwayat;
        }


        public IEnumerable<SiswaWaliModel> ListSiswaWali()
        {
            const string sql = @"Select * from SiswaWali";

            using var conn = new SqlConnection(_constString);
            var listWali = conn.Query<SiswaWaliModel>(sql);
            return listWali;
        }


        public IEnumerable<SiswaBeasiswaModel> ListSiswaBeasiswa()
        {
            const string sql = @"Select * from SiswaBeasiswa";

            using var conn = new SqlConnection(_constString);
            var listBeasiswa = conn.Query<SiswaBeasiswaModel>(sql);
            return listBeasiswa;
        }


        public IEnumerable<SiswaLulusModel> ListSiswaLulus()
        {
            const string sql = @"Select * from SiswaLulus";


            using var conn = new SqlConnection(_constString);
            var listLulus = conn.Query<SiswaLulusModel>(sql);
            return listLulus;
        }
    }
}
