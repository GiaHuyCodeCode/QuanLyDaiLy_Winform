using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy.DTO
{
    public class BaoCaoDoanhSo
    {
        public string MaBCDS { get; set; } = string.Empty;
        public int Thang { get; set; }
        public int Name { get; set; }
        public string TongDoanhThu { get; set; } = string.Empty;

        public BaoCaoDoanhSo()
        {
            // Nothing
        }

        public BaoCaoDoanhSo(string maBCDS, int thang, int name, string tongDoanhThu)
        {
            MaBCDS = maBCDS;
            Thang = thang;
            Name = name;
            TongDoanhThu = tongDoanhThu;
        }
    }
}
