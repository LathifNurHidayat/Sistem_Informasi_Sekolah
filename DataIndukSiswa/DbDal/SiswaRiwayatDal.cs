using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal
{
    public class SiswaRiwayatDal
    {
        public void Insert(SiswaRiwayatModel siswaRiwayat)
        {
            const string sql = @"
            INSERT INTO SiswaRiwayat
                    (SiswaId, GolDarah, RiwayatPenyakit, KelainanJasmani, 
                    TinggiBdn, BeratBdn, LulusanDr, TglIjazah, 
                    NoIjazah, LamaBljr, PindahanDr, AlasanPindah, 
                    DiterimaTingkat, KomKeahlian, TglDiterima, Kesenian, 
                    Olahraga, Organisasi, Hobi, CitaCita, TglTinggalSekolah, 
                    AlasanPindah, AkhirTamatBljr, AkhirNoIjazah)
            
            VALUE 
                    (@SiswaId, @GolDarah, @RiwayatPenyakit, @KelainanJasmani, 
                    @TinggiBdn, @BeratBdn, @LulusanDr, @TglIjazah, 
                    @NoIjazah, @LamaBljr, @PindahanDr, @AlasanPindah, 
                    @DiterimaTingkat, @KomKeahlian, @TglDiterima, @Kesenian, 
                    @Olahraga, @Organisasi, @Hobi, @CitaCita, @TglTinggalSekolah, 
                    @AlasanPindah, @AkhirTamatBljr, @AkhirNoIjazah)";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", siswaRiwayat.SiswaId, DbType.Int32);
            Dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.String);
            Dp.Add("@RiwayatPenyakit", siswaRiwayat.RiwayatPenyakit, DbType.String);
            Dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String);
            Dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, DbType.Int16);
            Dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, DbType.Int16);
            Dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, DbType.String);
            Dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.DateTime);
            Dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String);
            Dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, DbType.String);
            Dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, DbType.String);
            Dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            Dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, DbType.String);
            Dp.Add("@KomKeahlian", siswaRiwayat.KompKeahlian, DbType.String);
            Dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.DateTime);
            Dp.Add("@Kesenian", siswaRiwayat.Kesenian, DbType.String);
            Dp.Add("@Olahraga", siswaRiwayat.Olahraga, DbType.String);
            Dp.Add("@Organisasi", siswaRiwayat.Organisasi, DbType.String);
            Dp.Add("@Hobi", siswaRiwayat.Hobi, DbType.String);
            Dp.Add("@CitCita", siswaRiwayat.CitaCita, DbType.String);
            Dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, DbType.DateTime);
            Dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, DbType.String);
            Dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, DbType.DateTime);
            Dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, DbType.String);

            var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, Dp);
        }


        public void Update(SiswaRiwayatModel siswaRiwayat)
        {
            const string Sql = @"
                UPDATE SiswaRiwayat 
                    SET
                        GolDarah = @GolDarah,
                        RiwayatPenyakit = @RiwayatPenyakit,
                        KelainanJasmani = @KelainanJasmani,
                        TinggiBdn = @ TinggiBdn,
                        BeratBdn = @BeratBdn,
                        LulusanDr = @LulusanDr,
                        TglIjazah = @TglIjazah,
                        NoIjazah = @NoIjazah,
                        LamaBljr = @LamaBljr,
                        PindahanDr = @PindahanDr,
                        AlasanPindah = @AlasanPindah,
                        DiterimaTingkat = @DiterimaTingkat,
                        KomKeahlian = @KomKeahlian,
                        TglDiterima = @TglDiterima,
                        Kesenian = @Kesenian,
                        Olahraga = @Olahraga,
                        Organisasi = @Organisasi,
                        Hobi = @Hobi,
                        CitaCita = @CitaCita,
                        TglTinggalSekolah = @TglTinggalSekolah,
                        AlasanTinggal = @AlasanTinggal,
                        AkhirTamatBljr = @AkhirTamatBljr,
                        AkhirNoIjazah = @AkhirNoIjazah

                    WHERE 
                        SiswaId = @SiswaId";


            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", siswaRiwayat, DbType.Int32);
            Dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.String);
            Dp.Add("@RiwayatPenyakit", siswaRiwayat.RiwayatPenyakit, DbType.String);
            Dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String);
            Dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, DbType.Int16);
            Dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, DbType.Int16);
            Dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, DbType.String);
            Dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.DateTime);
            Dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String);
            Dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, DbType.String);
            Dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, DbType.String);
            Dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            Dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, DbType.String);
            Dp.Add("@KomKeahlian", siswaRiwayat.KompKeahlian, DbType.String);
            Dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.DateTime);
            Dp.Add("@Kesenian", siswaRiwayat.Kesenian, DbType.String);
            Dp.Add("@Olahraga", siswaRiwayat.Olahraga, DbType.String);
            Dp.Add("@Organisasi", siswaRiwayat.Organisasi, DbType.String);
            Dp.Add("@Hobi", siswaRiwayat.Hobi, DbType.String);
            Dp.Add("@CitCita", siswaRiwayat.CitaCita, DbType.String);
            Dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, DbType.DateTime);
            Dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, DbType.String);
            Dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, DbType.DateTime);
            Dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, DbType.String);

            var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }



        public void Delete(int SiswaId)
        {
            const string Sql = @"
            DELETE FROM 
                SiswaRiwayat
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }



        public SiswaRiwayatModel? GetData(int SiswaId)
        {
            const string Sql = @"
            SELECT 
                GolDarah, RiwayatPenyakit, KelainanJasmani, TinggiBdn, 
                BeratBdn, LulusanDr, TglIjazah, NoIjazah, LamaBljr, 
                PindahanDr, AlasanPindah, DiterimaTingkat, KomKeahlian, TglDiterima
            FROM
                SiswaRiwayat
            WHERE 
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<SiswaRiwayatModel>(Sql, Dp);       
        }



        public IEnumerable<SiswaRiwayatModel> ListData()
        {
            const string Sql = @"
            SELECT 
                SiswaId, GolDarah, RiwayatPenyakit, KelainanJasmani, TinggiBdn, 
                BeratBdn, LulusanDr, TglIjazah, NoIjazah, LamaBljr, 
                PindahanDr, AlasanPindah, DiterimaTingkat, KomKeahlian, TglDiterima
            FROM
                SiswaRiwayat";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaRiwayatModel>(Sql);

        }
    }   
}
