using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;

namespace Sistem_Informasi_Sekolah
{
    public class JurusanDal
    {
        public void Insert(JurusanModel jurusan)
        {
            const string sql = @"
                INSERT INTO Jurusan 
                    ( JurusanName, JurusanKode)
                VALUES 
                    (@JurusanName, @JurusanKode)";
              
            var Dp = new DynamicParameters();
            Dp.Add("@JurusanName", jurusan.JurusanName, DbType.String);
            Dp.Add("@JurusanKode", jurusan.JurusanKode, DbType.String);


            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Update(JurusanModel jurusan)
        {
            const string sql = @"
                UPDATE Jurusan
                    SET 
                    JurusanName = @JurusanName,
                    JurusanKode = @JurusanKode
                WHERE
                    JurusanId = @JurusanId";

            var Dp = new DynamicParameters();
            Dp.Add("@JurusanId", jurusan.JurusanId, DbType.Int32);
            Dp.Add("@JurusanName", jurusan.JurusanName, DbType.String);
            Dp.Add("@JurusanKode", jurusan.JurusanKode, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }
             
        public IEnumerable<JurusanModel>ListData()
        {
            const string Sql = "SELECT JurusanId , JurusanName, JurusanKode FROM Jurusan";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<JurusanModel>(Sql);
        }

        public void Delete(int JurusanId)
        {
            const string Sql = @"
            DELETE 
                Jurusan
            WHERE
                JurusanId = @JurusanId";

            var Dp = new DynamicParameters();
            Dp.Add("@JurusanId", JurusanId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }

        public JurusanModel? GetData(int JurusanId)
        {
            const string sql = @"
                SELECT 
                    JurusanId , JurusanName, JurusanKode
                FROM 
                    Jurusan
                WHERE 
                    JurusanId = @JurusanId";

            var Dp = new DynamicParameters();
            Dp.Add("@JurusanId", JurusanId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<JurusanModel>(sql, Dp);
        }
    }
}
