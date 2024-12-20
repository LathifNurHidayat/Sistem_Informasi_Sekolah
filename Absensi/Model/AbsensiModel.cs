﻿using Sistem_Informasi_Sekolah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Informasi_Sekolah
{
    public class AbsensiModel
    {
        public int AbsensiId { get; set; }
        public DateTime Tanggal { get; set; }
        public string Jam { get; set; }
        public int KelasId { get; set; }
        public string KelasName { get; set; }
        public int MapelId { get; set; }
        public string MapelName { get; set; }
        public int GuruId { get; set; }
        public string GuruName { get; set; }
        public List<AbsensiDetilModel> ListData { get; set; }
    }
}
