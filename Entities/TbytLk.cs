using System;
using System.Collections.Generic;

namespace MicroMEMSVer3.Entities
{
    public partial class TbytLk
    {
        public int Id { get; set; }
        public string MaLk { get; set; } = null!;
        public string TenLk { get; set; } = null!;
        public string Dvt { get; set; } = null!;
        public int SoLuong { get; set; }
        public int Tbytid { get; set; }

        public virtual Tbyt Tbyt { get; set; } = null!;
    }
}
