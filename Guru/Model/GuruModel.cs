using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
	public class GuruModel
	{
		public int GuruId { get; set; }
		public string GuruName { get; set; }
		public DateTime TglLahir { get; set; }
		public string JurusanPendidikan {  get; set; }
		public string TingkatPendidikan { get; set; }
		public string TahunLulus {  get; set; }
		public string InstansiPendidikan { get; set; }
		public string KotaPendidikan { get; set; }

		public List<GuruMapelModel> ListMapel { get; set; }
    }
}
