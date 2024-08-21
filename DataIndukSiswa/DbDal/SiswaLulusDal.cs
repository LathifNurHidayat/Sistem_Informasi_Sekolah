using Dapper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistem_Informasi_Sekolah.ConnHelper;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal
{
    public class SiswaLulusDal
    {
        public void Insert(SiswaLulusModel siswaLulus)
        {
            const string Sql = @"
            INSERT INTO SiswaLulus
                (SiswaId, LanjutDi, TglMulaiKerja, NamaPerusahaan, Penghasilan)
            VALUE 
                (@SiswaId, @LanjutDi, @TglMulaiKerja, @NamaPerusahaan, @Penghasilan)";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", siswaLulus.SiswaId, DbType.Int32);
            Dp.Add("@LanjutDi", siswaLulus.LanjutDi, DbType.String);
            Dp.Add("@TglMulaiKerja", siswaLulus.TglMulaiKerja, DbType.DateTime);
            Dp.Add("@NamaPerusahaan", siswaLulus.NamaPerusahaan, DbType.String);
            Dp.Add("@Penghasilan", siswaLulus.Penghasilan, DbType.Decimal);

            var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }



        public void Update(SiswaLulusModel siswaLulus)
        {
            const string Sql = @"
            UPDATE 
                SiswaLulus
            SET
                LanjutDi = @LanjutDi,
                TglMulaiKerja = @TglMulaiKerja,
                NamaPerusahaan = @NamaPerusahaan,
                Penghasilan = @Penghasilan
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", siswaLulus.SiswaId, DbType.Int32);
            Dp.Add("@lanjutDi", siswaLulus.LanjutDi, DbType.String);
            Dp.Add("@TglMulaiKerja", siswaLulus.TglMulaiKerja, DbType.DateTime);
            Dp.Add("@NamaPerusahaan", siswaLulus.NamaPerusahaan, DbType.String);
            Dp.Add("@Penghasilan", siswaLulus.Penghasilan, DbType.Decimal);

            var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }



        public void Dalete(int SiswaId)
        {
            const string Sql = @"
            DELETE 
                SiswaLulus
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }



        public SiswaLulusModel? GetData(int SiswaId)
        {
            const string Sql = @"
            SELECT
                LanjutDi, TglMulaiKerja, NamaPerusahaan, Penghasilan
            FROM
                SiswaLulus
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<SiswaLulusModel>(Sql, Dp);
        }



        public IEnumerable<SiswaLulusModel> ListData(int SiswaId)
        {
            const string Sql = @"
            SELECT
                SiswaId, LanjutDi, TglMulaiKerja, NamaPerusahaan, Penghasilan
            FROM
                SiswaLulus";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaLulusModel>(Sql);
        }
    }
}











