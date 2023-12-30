using QuanLyDaiLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy.DAL
{
	public static class BaoCaoDoanhSoDAL
	{
		public static Tuple<BaoCaoDoanhSo, CtBcds[]> GetBaoCaoDoanhSo(int month, int year)
		{
			MessageBox.Show(DataProvider.Instance.ExecuteStoredProcedure($@"
EXEC CalculateAndDisplayReport @Thang = {month}, @Nam = {year}").ToString());
			var table = DataProvider.Instance.ExecuteQuery($@"
SELECT TOP 1 MaBCDS, Thang, Nam, TongDoanhThu
FROM BAOCAODOANHSO
WHERE Thang = {month} AND Nam = {year}");
			string maBCDS;
			BaoCaoDoanhSo bcdsObj = null;
			List<CtBcds> ctBcdsList = new List<CtBcds>();
			{
				var row = table.Rows[0];
				maBCDS = row["MaBCDS"].ToString();
				bcdsObj = new BaoCaoDoanhSo(
					maBCDS,
					int.Parse(row["Thang"].ToString()),
					int.Parse(row["Nam"].ToString()),
					row["TongDoanhThu"].ToString());
			}
			if (bcdsObj == null)
			{
				return null;
			}
			table = DataProvider.Instance.ExecuteQuery($@"
SELECT MaBCDS, MaDaiLy, SoPhieuXuat, TongTriGia, TyLe
FROM CT_BCDS
WHERE MaBCDS = '{maBCDS}'");
			foreach (DataRow row in table.Rows)
			{
				ctBcdsList.Add(new CtBcds(
					row["MaBCDS"].ToString(),
					row["MaDaiLy"].ToString(),
					int.Parse(row["SoPhieuXuat"].ToString()),
					(int)float.Parse(row["TongTriGia"].ToString()),
					float.Parse(row["TyLe"].ToString())));
			}
			return new Tuple<BaoCaoDoanhSo, CtBcds[]>(bcdsObj, ctBcdsList.ToArray());
		}
	}
}
