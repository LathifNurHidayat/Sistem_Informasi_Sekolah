using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
using Sistem_Informasi_Sekolah.DataIndukSiswa.DbDal;
using Sistem_Informasi_Sekolah.DataIndukSiswa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormDataSiswa : Form
    {
        private readonly SiswaDal _siswaDal;

        public FormDataSiswa()
        {
            _siswaDal = new SiswaDal();
            InitializeComponent();
            CekLIstBoxSiswa.Items.AddRange(_siswaDal.ListData()
                .Select(x => x.NamaLengkap).ToArray());
        }
    }
}
