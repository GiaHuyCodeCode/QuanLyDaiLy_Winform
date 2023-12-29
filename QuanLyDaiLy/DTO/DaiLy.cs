using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy.DTO
{
    public class DaiLy
    {
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string MaLoaiDaiLy { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaQuan { get; set; }
        public DateTime NgayTiepNhap { get; set; }
        public string Email { get; set; }
        public SqlMoney TienNo { get; set; }

        public DaiLy()
        {
            // Nothing
        }
        public DaiLy(string maDaiLy, string tenDaiLy, string maLoaiDaiLy, string dienThoai, string diaChi, string maQuan, DateTime ngayTiepNhap, string email, SqlMoney tienNo)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            MaLoaiDaiLy = maLoaiDaiLy;
            DienThoai = dienThoai;
            DiaChi = diaChi;
            MaQuan = maQuan;
            NgayTiepNhap = ngayTiepNhap;
            Email = email;
            TienNo = tienNo;
        }

        public DaiLy(DataRow row)
        {
            this.MaDaiLy = row["MaDaiLy"].ToString();
            TenDaiLy = row["TenDaiLy"].ToString();
            MaLoaiDaiLy = row["MaLoaiDaiLy"].ToString();
            DienThoai = row["DienThoai"].ToString();
            MaQuan = row["MaQuan"].ToString();
            NgayTiepNhap = (DateTime)row["NgayTiepNhan"];
            Email = row["Email"].ToString();
            //TienNo = (SqlMoney)row["TienNo"];
        }


    }
}
