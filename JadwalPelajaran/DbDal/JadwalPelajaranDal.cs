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
    public class JadwalPelajaranDal
    {
        public IEnumerable<JadwalPelajaranModel> ListData(int KelasId)
        {
            const string sql = @"
               
                    SELECT 
                        aa.JadwalId, aa.JenisJadwal, aa.KelasId, aa.Hari, aa.JamMulai, aa.JamSelesai, aa.Keterangan,
                        ISNULL (bb.MapelName , '') AS MapelName,
                        ISNULL (cc.GuruName , '') AS GuruName
                    FROM 
                        JadwalPelajaran aa 
                        LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                        LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId
                    WHERE
                        KelasId = @KelasId
                    ORDER BY 
                        CASE 
                            WHEN Hari = 'Senin' THEN 1
                            WHEN Hari = 'Selasa' THEN 2
                            WHEN Hari = 'Rabu' THEN 3
                            WHEN Hari = 'Kamis' THEN 4
                            WHEN Hari = 'Jumat' THEN 5
                            WHEN Hari = 'Sabtu' THEN 6
                        ELSE 7
                        END, JamMulai";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", KelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<JadwalPelajaranModel>(sql, Dp);
        }


        public void Insert(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                INSERT INTO JadwalPelajaran
                    (KelasId, JenisJadwal,
                    Hari, JamMulai, JamSelesai, MapelId, GuruId)
                VALUES 
                    (@KelasId, @JenisJadwal,
                    @Hari, @JamMulai, @JamSelesai, @MapelId, @GuruId) ";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", jadwal.KelasId , DbType.Int32);
            Dp.Add("@JenisJadwal", jadwal.JenisJadwal, DbType.String);
            Dp.Add("@Hari", jadwal.Hari, DbType.String);
            Dp.Add("@JamMulai", jadwal.JamMulai, DbType.String);
            Dp.Add("@JamSelesai", jadwal.JamSelesai, DbType.String);
            Dp.Add("@MapelId", jadwal.MapelId, DbType.Int32);
            Dp.Add("@GuruId", jadwal.GuruId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Update(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                UPDATE 
                    JadwalPelajaran
                SET
                    KelasId = @KelasId,
                    JenisJadwal = @JenisJadwal,
                    Hari = @Hari,
                    JamMulai = @JamMulai,
                    JamSelesai = @JamSelesai,
                    MapelId = @MapelId,
                    GuruId = @GuruId,
                    Keterangan = @Keterangan
                WHERE 
                    JadwalId = @JadwalId";

            var Dp = new DynamicParameters();
            Dp.Add("@JadwalId", jadwal.JadwalId, DbType.Int32);
            Dp.Add("@KelasId", jadwal.KelasId, DbType.Int32);
            Dp.Add("@JenisJadwal", jadwal.JenisJadwal, DbType.String);
            Dp.Add("@Hari", jadwal.Hari, DbType.String);
            Dp.Add("@JamMulai", jadwal.JamMulai, DbType.String);
            Dp.Add("@JamSelesai", jadwal.JamSelesai, DbType.String);
            Dp.Add("@MapelId", jadwal.MapelId, DbType.Int32);
            Dp.Add("@GuruId", jadwal.GuruId, DbType.Int32);
            Dp.Add("@Keterangan", jadwal.Keterangan, DbType.String);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

        public void Delete(int JadwalId)
        {
            const string sql = "DELETE FROM JadwalPelajaran WHERE JadwalId = @JadwalId";

            var Dp = new DynamicParameters();
            Dp.Add("@JadwalId", JadwalId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

         
        public JadwalPelajaranModel? GetData(int JadwalId)
        {
            const string sql = @"
                SELECT 
                    JadwalId, JenisJadwal, Hari, JamMulai, JamSelesai,
                    MapelId, GuruId, Keterangan
                FROM
                    JadwalPelajaran
                WHERE
                    JadwalId = @JadwalId";

            var Dp = new DynamicParameters();
            Dp.Add("@JadwalId", JadwalId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.QueryFirstOrDefault<JadwalPelajaranModel>(sql, Dp);
        }
    }
}