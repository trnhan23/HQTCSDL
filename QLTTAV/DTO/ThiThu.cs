using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class ThiThu
    {
        public string MaTT { get; set; }
        public string PhongThi { get; set; }
        public DateTime NgayThi { get; set; }
        public TimeSpan GioThi { get; set; }
        public int GioiHan { get; set; }
        public string MaNV { get; set; }
    }
}
