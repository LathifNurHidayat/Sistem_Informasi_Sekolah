using Dapper;
using Sistem_Informasi_Sekolah.ConnHelper;
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
        public string Data = string.Empty;

        public FormDataSiswa()
        {
            InitializeComponent();
            
            foreach (var item in ListData())
            {
                CekLIstBoxSiswa.Items.Add(item);
            }

            ButtonAdd.Click += ButtonAdd_Click;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e)
        {
            foreach (var item in CekLIstBoxSiswa.CheckedItems)
            {
                List<string> ListData = new 
            }
        }

        public IEnumerable<SiswaModel> ListData()
        {

            const string sql = @"
                SELECT 
                    SiswaId , NamaLengkap
                FROM 
                    Siswa";

            using var Conn = new SqlConnection(ConnStringHelper.Get());
            return Conn.Query<SiswaModel>(sql);
        }
    }
}
