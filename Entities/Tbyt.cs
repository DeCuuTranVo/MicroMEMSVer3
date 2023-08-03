using System;
using System.Collections.Generic;

namespace MicroMEMSVer3.Entities
{
    public partial class Tbyt
    {
        public Tbyt()
        {
            TbytLks = new HashSet<TbytLk>();
        }

        public int Id { get; set; }
        public string NhomTb { get; set; } = null!;
        public string LoaiTb { get; set; } = null!;
        public string MaTb { get; set; } = null!;
        public string TenTb { get; set; } = null!;
        public string Dvt { get; set; } = null!;
        public string HangSx { get; set; } = null!;
        public string NuocSx { get; set; } = null!;
        public int NamSx { get; set; }
        public int GiaTri { get; set; }
        public int SoLanBaoTriMotNam { get; set; }

        public virtual ICollection<TbytLk> TbytLks { get; set; }
    }
}
