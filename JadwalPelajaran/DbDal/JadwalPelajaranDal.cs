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
                    aa.Hari , aa.JamMulai, aa.JamSelesai, bb.MapelName, cc.GuruName 
                FROM
                    JadwalPelajaran aa
                INNER JOIN 
                    MataPelajaran bb ON aa.MapelId = bb.MapelId
                INNER JOIN
                    Guru cc ON  aa.GuruId = cc.GuruId
                WHERE 
                    KelasId = @KelasId
                
                ORDER BY
                    CASE 
                        WHEN aa.Hari = 'Senin' THEN 1
                        WHEN aa.Hari = 'Selasa' THEN 2
                        WHEN aa.Hari = 'Rabu' THEN 3
                        WHEN aa.Hari = 'Kamis' THEN 4
                        WHEN aa.Hari = 'Jumat' THEN 5
                        WHEN aa.Hari = 'Sabtu' THEN 6
                    ELSE 8
                END,
                    aa.JamMulai ";

            var Dp = new DynamicParameters();
            Dp.Add("@KelasId", KelasId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<JadwalPelajaranModel>(sql, Dp);
        }


        public void Insert(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                INSERT INTO JadwalPelajaran
                    (JadwalId, KelasId, JenisJadwal,
                    Hari, JamMulai, JamSelesai, MapelId, GuruId)
                VALUES 
                    (@JadwalId, @KelasId, @JenisJadwal,
                    @Hari, @JamMulai, @JamSelesai, @MapelId, @GuruId) ";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql);
        }

        public void Update(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                UPDATE 
                    JadwalPelajaran
                SET
                    JadwalId = @JadwalId,
                    KelasId = @KelasId,
                    JenisJadwal = @JenisJadwal,
                    Hari = @Hari,
                    JamMulai = @JamMulai,
                    JamSelesai = @JamSelesai,
                    MapelId = @MapelId,
                    GuruId = @GuruId 
                WHERE 
                    KelasId = @KelasId";

            var Dp = new DynamicParameters();
            Dp.Add("@JadwalId", jadwal.JadwalId, DbType.Int32);
            Dp.Add("@KelasId", jadwal.KelasId, DbType.Int32);
            Dp.Add("@JenisJadwal", jadwal.JenisJadwal, DbType.Int16);
            Dp.Add("@Hari", jadwal.Hari, DbType.String);
            Dp.Add("@JamMulai", jadwal.JamMulai, DbType.DateTime);
            Dp.Add("@JamSelesai", jadwal.JamSelesai, DbType.DateTime);
            Dp.Add("@MapelId", jadwal.MapelId, DbType.Int32);
            Dp.Add("@GuruId", jadwal.GuruId, DbType.Int32);

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            Conn.Execute(sql, Dp);
        }

         
    }
}
