using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTiet_CaDay
    {
		public ChiTiet_CaDay() { }
		public string MaLH { get; set; }
		public string MaGV { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public string CaDay { get; set; }

    }
}

