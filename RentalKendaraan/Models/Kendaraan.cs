﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string NoPolisi { get; set; }
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public byte[] Ketersediaan { get; set; }
    }
}
