using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public string IdPengembalian { get; set; }
        public string TglPengembalian { get; set; }
        public string IdPeminjaman { get; set; }
        public string IdKondisi { get; set; }
        public string Denda { get; set; }
    }
}
