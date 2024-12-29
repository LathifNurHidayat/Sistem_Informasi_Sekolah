using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class MesBoxHelper
    {
        public bool MessageInformasi(string isiMessege)
        {
            MessageBox.Show($"{isiMessege}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool MessageKonfirmasi(string isiMessage)
        {
            bool cek = false;
            if (MessageBox.Show($"{isiMessage}", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)cek = true;

            return cek;
        }

        public bool MessagePeringatan(string isiMessage)
        {
            bool cek = false;
            if (MessageBox.Show($"{isiMessage}", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) cek = true;
            return cek;
        }

        public bool MessageError(string isiMessage)
        {
            MessageBox.Show($"{isiMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
