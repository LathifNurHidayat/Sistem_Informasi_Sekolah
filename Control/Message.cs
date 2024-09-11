using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class Message
    {
        public bool MessageInput(string isiMessege)
        {
            return MessageBox.Show($"Tambahkan data \" {isiMessege} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes; 
        }


        public bool MessageDelete(string isiMessege)
        {
            return MessageBox.Show($"Hapus data \" {isiMessege} \" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }


        public bool MessageUpdate(string awal , string akhir)
        {
            return MessageBox.Show($"Update data \"{awal}\" menjadi \"{akhir}\" ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public bool MessageBerhasil(string keterangan)
        {
            return MessageBox.Show($"Data berhasil {keterangan}", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes;
        }
    }
}
