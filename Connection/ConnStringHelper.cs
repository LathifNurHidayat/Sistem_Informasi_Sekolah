using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah.ConnHelper
{
    public class ConnStringHelper
    {
        public static string Get()
            =>$"Server=(local);Database=SekolahKuy;Trusted_Connection=True;TrustServerCertificate=True";

    }
}