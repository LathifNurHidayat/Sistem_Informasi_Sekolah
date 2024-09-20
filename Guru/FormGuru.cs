using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Sekolah
{
    public partial class FormGuru : Form
    {
        private readonly GuruDal _guruDal;
        private readonly GuruMapelDal _guruMapelDal;
        private readonly MataPelajaranDal _mataPelajaranDal;



        public FormGuru()
        {
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mataPelajaranDal = new MataPelajaranDal();

            InitializeComponent();
        }
    }
}
