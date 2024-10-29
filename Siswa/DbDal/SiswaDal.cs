using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal
{
    public class SiswaDal
    {
        public  int Insert(SiswaModel siswa)
        {
            const string sql = @"
             INSERT INTO Siswa
                    (
                        NamaLengkap, NamaPanggil, Gender, TmpLahir, TglLahir,Agama, 
                        Kewarganegaraan, NIK, AnakKe, JmlhSdrKandung, JmlhSdrTiri, 
                        JmlhSdrAngkat, YatimPiatu, Bahasa, Alamat, NoTelp, TngglDengan,
                        JrkKeSekolah, TransportSekolah, LokasiPhoto
                    )
             OUTPUT INSERTED.SiswaId
             VALUES 
                    (
                        @NamaLengkap, @NamaPanggil, @Gender, @TmpLahir, @TglLahir,@Agama, 
                        @Kewarganegaraan, @NIK, @AnakKe, @JmlhSdrKandung, @JmlhSdrTiri, 
                        @JmlhSdrAngkat, @YatimPiatu, @Bahasa, @Alamat, @NoTelp, @TngglDengan,
                        @JrkKeSekolah, @TransportSekolah, @LokasiPhoto
                    )";

            var Dp = new DynamicParameters();
            Dp.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            Dp.Add("@NamaPanggil", siswa.NamaPanggil, DbType.String);
            Dp.Add("@Gender", siswa.Gender, DbType.Int16);
            Dp.Add("@TmpLahir", siswa.TmpLahir, DbType.String);
            Dp.Add("@TglLahir", siswa.TglLahir, DbType.DateTime);
            Dp.Add("@Agama", siswa.Agama, DbType.String);
            Dp.Add("@Kewarganegaraan", siswa.Kewarganegaraan, DbType.String);
            Dp.Add("@NIK", siswa.NIK, DbType.String);
            Dp.Add("@AnakKe", siswa.AnakKe, DbType.Int16);
            Dp.Add("@JmlhSdrKandung", siswa.JmlhSdrKandung, DbType.Int16);
            Dp.Add("@JmlhSdrTiri", siswa.JmlhSdrTiri, DbType.Int16);
            Dp.Add("@JmlhSdrAngkat", siswa.JmlhSdrAngkat, DbType.Int16);
            Dp.Add("@YatimPiatu", siswa.YatimPiatu, DbType.String);
            Dp.Add("@Bahasa", siswa.Bahasa, DbType.String);
            Dp.Add("@Alamat", siswa.Alamat, DbType.String);
            Dp.Add("@NoTelp", siswa.NoTelp, DbType.String);
            Dp.Add("@TngglDengan", siswa.TngglDengan, DbType.String);
            Dp.Add("@JrkKeSekolah", siswa.JrkKeSekolah, DbType.Int16);
            Dp.Add("@TransportSekolah", siswa.TransportSekolah, DbType.String);
            Dp.Add("@LokasiPhoto", siswa.LokasiPhoto, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, Dp);
            return result;
        }


        public void Update(SiswaModel siswa)
        {
            const string Sql = @"
            UPDATE 
                Siswa 
            SET
                NamaLengkap = @NamaLengkap,
                NamaPanggil = @NamaPanggil,
                Gender = @Gender,
                TmpLahir = @TmpLahir,
                TglLahir = @TglLahir,
                Agama = @Agama,
                Kewarganegaraan = @Kewarganegaraan,
                NIK = @NIK,
                AnakKe = @AnakKe,
                JmlhSdrKandung = @JmlhSdrKandung,
                JmlhSdrTiri = @JmlhSdrTiri,
                JmlhSdrAngkat = @JmlhSdrAngkat,
                YatimPiatu = @YatimPiatu,
                Bahasa = @Bahasa,
                Alamat = @Alamat,
                NoTelp = @NoTelp,
                TngglDengan = @TngglDengan,
                JrkKeSekolah = @JrkKeSekolah,
                TransportSekolah = @TransportSekolah,
                LokasiPhoto = @LokasiPhoto
            WHERE 
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", siswa.SiswaId, DbType.Int16);
            Dp.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            Dp.Add("@NamaPanggil", siswa.NamaPanggil, DbType.String);
            Dp.Add("@Gender", siswa.Gender, DbType.Int16);
            Dp.Add("@TmpLahir", siswa.TmpLahir, DbType.String);
            Dp.Add("@TglLahir", siswa.TglLahir, DbType.DateTime);
            Dp.Add("@Agama", siswa.Agama, DbType.String);
            Dp.Add("@Kewarganegaraan", siswa.Kewarganegaraan, DbType.String);
            Dp.Add("@NIK", siswa.NIK, DbType.String);
            Dp.Add("@AnakKe", siswa.AnakKe, DbType.Int16);
            Dp.Add("@JmlhSdrKandung", siswa.JmlhSdrKandung, DbType.Int16);
            Dp.Add("@JmlhSdrTiri", siswa.JmlhSdrTiri, DbType.Int16);
            Dp.Add("@JmlhSdrAngkat", siswa.JmlhSdrAngkat, DbType.Int16);
            Dp.Add("@YatimPiatu", siswa.YatimPiatu, DbType.String);
            Dp.Add("@Bahasa", siswa.Bahasa, DbType.String);
            Dp.Add("@Alamat", siswa.Alamat, DbType.String);
            Dp.Add("@NoTelp", siswa.NoTelp, DbType.String);
            Dp.Add("@TngglDengan", siswa.TngglDengan, DbType.String);
            Dp.Add("@JrkKeSekolah", siswa.JrkKeSekolah, DbType.Int16);
            Dp.Add("@TransportSekolah", siswa.TransportSekolah, DbType.String);
            Dp.Add("@LokasiPhoto", siswa.LokasiPhoto, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }


        public void Delete(int SiswaId)
        {
            const string Sql = @"
            DELETE FROM
                Siswa
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int16);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(Sql, Dp);
        }


        public SiswaModel? GetData(int SiswaId)
        {
            const string Sql = @"
            SELECT 
                SiswaId, NamaLengkap, NamaPanggil, Gender, TmpLahir, TglLahir,Agama, 
                Kewarganegaraan, NIK, AnakKe, JmlhSdrKandung, JmlhSdrTiri, 
                JmlhSdrAngkat, YatimPiatu, Bahasa, Alamat, NoTelp, TngglDengan,
                JrkKeSekolah, TransportSekolah, LokasiPhoto
            FROM 
                Siswa
            WHERE
                SiswaId = @SiswaId";

            var Dp = new DynamicParameters();
            Dp.Add("@SiswaId", SiswaId, DbType.Int16);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<SiswaModel>(Sql, Dp);
        }


        public IEnumerable<SiswaModel> ListData()
        {
            const string Sql = @"
            SELECT 
                SiswaId, NamaLengkap, NamaPanggil, Gender, TmpLahir, TglLahir,Agama, 
                Kewarganegaraan, NIK, AnakKe, JmlhSdrKandung, JmlhSdrTiri, 
                JmlhSdrAngkat, YatimPiatu, Bahasa, Alamat, NoTelp, TngglDengan,
                JrkKeSekolah, TransportSekolah,LokasiPhoto
            FROM
                Siswa";

            var Dp = new DynamicParameters();

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaModel>(Sql, Dp);
        }

  

        public IEnumerable<SiswaModel> ListDataFilter(string nama)
        {
            const string Sql = @"
            SELECT 
                SiswaId, NamaLengkap
            FROM
                Siswa
            WHERE
                NamaLengkap LIKE CONCAT ('%',@nama,'%') ";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaModel>(Sql, new { nama = nama });
        }
    }
}
