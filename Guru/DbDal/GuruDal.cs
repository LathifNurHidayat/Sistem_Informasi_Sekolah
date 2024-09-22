using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using Sistem_Informasi_Sekolah.ConnHelper;

namespace Sistem_Informasi_Sekolah
{
    public class GuruDal
    {
        public int Insert(GuruModel  guruModel)
        {
            const string sql = @"
                INSERT INTO Guru
                    (GuruId, GuruName, TglLahir, JurusanPendidikan, 
                    TingkatPendidikan, TahunLulus, InstansiPenidikan, 
                    KotaPendidikan)
                VALUES 
                    (@GuruId, @GuruName, @TglLahir, @JurusanPendidikan, 
                    @TingkatPendidikan, @TahunLulus, @InstansiPenidikan, 
                    @KotaPendidikan)";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", guruModel.GuruId, DbType.Int32);
            Dp.Add("@GuruName", guruModel.GuruName, DbType.String);
            Dp.Add("@TglLahir", guruModel.TglLahir, DbType.DateTime);
            Dp.Add("@JurusanPendidikan", guruModel.JurusanPendidikan, DbType.String);
            Dp.Add("@TingkatPendidikan", guruModel.TingkatPendidikan, DbType.String);
            Dp.Add("@TahunLulus", guruModel.TahunLulus, DbType.String);
            Dp.Add("@InstansiPendidikan", guruModel.InstansiPendidikan, DbType.String);
            Dp.Add("@KotaPendidikan", guruModel.KotaPendidikan, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QuerySingle<int>(sql, Dp);
        }

        public void Update(GuruModel guruModel)
        {
            const string sql = @"
                UPDATE Guru SET
                    GuruName = @GuruName,
                    TglLahir = @TglLahir, 
                    JurusanPendidikan = @JurusanPendidikan,
                    TingkatPendidikan = @TingkatPendidikan,
                    TahunLulus = @TahunLulus,
                    InstansiPendidikan = @InstansiPendidikan,
                    KotaPendidikan = @KotaPendidikan
                WHERE
                    GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", guruModel.GuruId, DbType.Int32);
            Dp.Add("@GuruName", guruModel.GuruName, DbType.String);
            Dp.Add("@TglLahir", guruModel.TglLahir, DbType.DateTime);
            Dp.Add("@JurusanPendidikan", guruModel.JurusanPendidikan, DbType.String);
            Dp.Add("@TingkatPendidikan", guruModel.TingkatPendidikan, DbType.String);
            Dp.Add("@InstansiPendidikan", guruModel.InstansiPendidikan, DbType.String);
            Dp.Add("@KotaPendidikan", guruModel.KotaPendidikan, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Delete(int GuruId)
        {
            const string sql = "DELETE FROM Guru WHERE GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", GuruId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public IEnumerable<GuruModel> ListData()
        {
            const string sql = "SELECT * FROM Guru";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<GuruModel>(sql);
        }

        public  GuruModel GetData(int GuruId)
        {
            const string sql = @"
                SELECT * FROM Guru WHERE GuruId = @GuruId";

            var Dp = new DynamicParameters();
            Dp.Add("@GuruId", GuruId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QuerySingle<GuruModel>(sql);
        }
    }
}
