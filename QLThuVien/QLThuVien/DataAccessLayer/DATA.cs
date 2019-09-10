using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLThuVien.ValueObject;

namespace QLThuVien.DataAccessLayer
{
    public class DAO
    {
      
        //Ke Sach
        public static DataTable Select_KeSach()
        {
            return DataProvider.GetData("Select_KeSach");
        }


        public static int Insert_KeSach(KeSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKe", a.MaKe),
                new SqlParameter("@chatLieu", a.ChatLieu),
                new SqlParameter("@sucChua", a.SucChua),

            };
            return DataProvider.ExecuteNonQuery("Insert_KeSach", para);
        }


        public static int Update_KeSach(KeSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
               new SqlParameter("@maKe", a.MaKe),
                new SqlParameter("@chatLieu", a.ChatLieu),
                new SqlParameter("@sucChua", a.SucChua),

            };
            return DataProvider.ExecuteNonQuery("Update_KeSach", para);
        }



        public static int Delete_KeSach(KeSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maKe", a.MaKe),

            };
            return DataProvider.ExecuteNonQuery("Delete_KeSach", para);
        }

        //Thu Thu
        public static DataTable Select_TT()
        {
            return DataProvider.GetData("Select_TT");
        }


        public static int Insert_TT(ThuThu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@matt", a.MaTT),
                       new SqlParameter("@tentt", a.TenTT),                       
                       new SqlParameter("@ngaysinhtt", a.NgaySinh),
                       new SqlParameter("@gioitinhtt", a.GioiTinh),
                       new SqlParameter("@diachitt", a.DiaChi),
                       new SqlParameter("@sdttt", a.SDT),
                       new SqlParameter("@Chucvu", a.ChucVu),


                      };
            return DataProvider.ExecuteNonQuery("Insert_TT", para);
        }

        public static int Update_TT(ThuThu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@matt", a.MaTT),
                       new SqlParameter("@tentt", a.TenTT),
                       new SqlParameter("@gioitinhtt", a.GioiTinh),
                       new SqlParameter("@ngaysinhtt", a.NgaySinh),
                       new SqlParameter("@diachitt", a.DiaChi),
                       new SqlParameter("@sdttt", a.SDT),
                       new SqlParameter("@Chucvu", a.ChucVu),


                      };
            return DataProvider.ExecuteNonQuery("Update_TT", para);
        }


        public static int Delete_TT(ThuThu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@matt", a.MaTT),


                      };
            return DataProvider.ExecuteNonQuery("Delete_TT", para);
        }
        //NXB
        public static DataTable Select_NXB()
        {
            return DataProvider.GetData("Select_NXB");
        }


        public static int Insert_NXB(NXB a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb", a.MaNXB),
                new SqlParameter("@tennxb", a.TenNXB),
                new SqlParameter("@diachinxb", a.DiaChi),
                new SqlParameter("@sdtnxb", a.SDT),
                new SqlParameter("@emailnxb", a.Email),
              
            };
            return DataProvider.ExecuteNonQuery("Insert_NXB", para);
        }


        public static int Update_NXB(NXB a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb", a.MaNXB),
                new SqlParameter("@tennxb", a.TenNXB),
                new SqlParameter("@diachinxb", a.DiaChi),
                new SqlParameter("@sdtnxb", a.SDT),
                new SqlParameter("@emailnxb", a.Email),
              
            };
            return DataProvider.ExecuteNonQuery("Update_NXB", para);
        }



        public static int Delete_NXB(NXB a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manxb", a.MaNXB),
              
            };
            return DataProvider.ExecuteNonQuery("Delete_NXB", para);
        }


        //Tac Gia
        public static DataTable Select_TG()
        {
            return DataProvider.GetData("Select_TG");
        }


        public static int Insert_TG(TacGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg", a.MaTG),
                new SqlParameter("@tentg", a.TenTG),
                 new SqlParameter("@gioitinhtg", a.GioiTinh),
                new SqlParameter("@ngaysinhtg", a.NgaySinh),
                new SqlParameter("@quequantg", a.QueQuan),
               
              
            };
            return DataProvider.ExecuteNonQuery("Insert_TG", para);
        }


        public static int Update_TG(TacGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg", a.MaTG),
                new SqlParameter("@tentg", a.TenTG),
                 new SqlParameter("@gioitinhtg", a.GioiTinh),
                new SqlParameter("@ngaysinhtg", a.NgaySinh),
                new SqlParameter("@quequantg", a.QueQuan),
               
              
            };
            return DataProvider.ExecuteNonQuery("Update_TG", para);
        }



        public static int Delete_TG(TacGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matg", a.MaTG),
            };
            return DataProvider.ExecuteNonQuery("Delete_TG", para);
        }


        // Viet
        public static DataTable Select_Viet()
        {

            return DataProvider.GetData("Select_Viet");
        }


        public static int Insert_Viet(Viet a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matg", a.MaTG),
                  new SqlParameter("@sotrang", a.SoTrang),
                                      
            };
            return DataProvider.ExecuteNonQuery("Insert_V", para);
        }

        public static int Update_Viet(Viet a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matg", a.MaTG),
                  new SqlParameter("@sotrang", a.SoTrang),
                                      
            };
            return DataProvider.ExecuteNonQuery("Update_V", para);
        }

        public static int Delete_Viet(Viet a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@matg", a.MaTG),       
            };
            return DataProvider.ExecuteNonQuery("Delete_V", para);
        }


        //Tua Sach
        public static DataTable Select_TS()
        {
            return DataProvider.GetData("Select_TS");
        }

        public static DataTable Get_TS(char @mats)
        {
            return DataProvider.GetData("Get_TS '@mats'");
        }

        public static int Insert_TS(TuaSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@mats", a.MaTS),
                  new SqlParameter("@tents", a.TenTS),
                  new SqlParameter("@namxb", a.NamXB),
                  new SqlParameter("@theloai", a.TheLoai),
                  new SqlParameter("@manxb", a.MaNXB),
                  new SqlParameter("@make", a.MaKe),
                  new SqlParameter("@soluong", a.SoLuong),

            };
            return DataProvider.ExecuteNonQuery("Insert_TS", para);
        }

        public static int Update_TS(TuaSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@mats", a.MaTS),
                  new SqlParameter("@tents", a.TenTS),
                  new SqlParameter("@namxb", a.NamXB),
                  new SqlParameter("@make", a.MaKe),
                  new SqlParameter("@theloai", a.TheLoai),
                  new SqlParameter("@manxb", a.MaNXB),
                  new SqlParameter("@soluong", a.SoLuong),

            };
            return DataProvider.ExecuteNonQuery("Update_TS", para);
        }


        public static int Delete_TS(TuaSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@mats", a.MaTS),


            };
            return DataProvider.ExecuteNonQuery("Delete_TS", para);
        }


        //Doc Gia
        public static DataTable Select_DG()
        {
            return DataProvider.GetData("Select_DG");
        }



        public static int Insert_DG(DocGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                      new SqlParameter("@madg", a.MaDG),
                      new SqlParameter("@tendg", a.TenDG),
                      new SqlParameter("@gioitinhdg", a.GioiTinh),
                      new SqlParameter("@ngaysinhdg", a.NgaySinh),
                      new SqlParameter("@diachidg", a.DiaChi),
                      new SqlParameter("@sdtdg", a.SDT),

            };
            return DataProvider.ExecuteNonQuery("Insert_DG", para);
        }

        public static int Update_DG(DocGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                      new SqlParameter("@madg", a.MaDG),
                      new SqlParameter("@tendg", a.TenDG),
                      new SqlParameter("@gioitinhdg", a.GioiTinh),
                      new SqlParameter("@ngaysinhdg", a.NgaySinh),
                      new SqlParameter("@diachidg", a.DiaChi),
                      new SqlParameter("@sdtdg", a.SDT),

            };
            return DataProvider.ExecuteNonQuery("Update_DG", para);
        }

        public static int Delete_DG(DocGia a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                      new SqlParameter("@madg", a.MaDG),

                      };
            return DataProvider.ExecuteNonQuery("Delete_DG", para);
        }

        //Cuon Sach
        public static DataTable Select_CS()
        {
            return DataProvider.GetData("Select_CS");
        }


        public static int Insert_CS(CuonSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macs", a.MaCS),       
                new SqlParameter("@mats", a.MaTS),
                
            };
            return DataProvider.ExecuteNonQuery("Insert_CS", para);

        }


        public static int Update_CS(CuonSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macs", a.MaCS),
                new SqlParameter("@mats", a.MaTS),
            };
            return DataProvider.ExecuteNonQuery("Update_CS", para);
        }


        public static int Delete_CS(CuonSach a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macs", a.MaCS),
            
            };
            return DataProvider.ExecuteNonQuery("Delete_CS", para);
        }




        //Chi Tiet Nhap
        public static DataTable Select_CTN()
        {
            return DataProvider.GetData("Select_CTN");
        }

        public static int Insert_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@soluong", a.SoLuong),
                new SqlParameter("@dongia", a.DonGia),
            
            };
            return DataProvider.ExecuteNonQuery("Insert_CTN", para);

        }

        public static int Update_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
                new SqlParameter("@mats", a.MaTS),
                new SqlParameter("@soluong", a.SoLuong),
                new SqlParameter("@dongia", a.DonGia),
            
            };
            return DataProvider.ExecuteNonQuery("Update_CTN", para);
        }


        public static int Delete_CTN(ChiTietNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
            };
            return DataProvider.ExecuteNonQuery("Delete_CTN", para);
        }




        //Phieu Nhap
        public static DataTable Select_PN()
        {
            return DataProvider.GetData("Select_PN");
        }

        public static int Insert_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
                new SqlParameter("@ngaylap", a.NgayLap),
                new SqlParameter("@matt", a.MaTT),
                new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("Insert_PN", para);
        }

        public static int Update_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
                new SqlParameter("@ngaylap", a.NgayLap),
                new SqlParameter("@matt", a.MaTT),
                new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("Update_PN", para);
        }

        public static int Delete_PN(PhieuNhap a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn", a.MaPN),
            
            };
            return DataProvider.ExecuteNonQuery("Delete_PN", para);
        }



        //Nha Cung Cap
        public static DataTable Select_NCC()
        {
            return DataProvider.GetData("Select_NCC");
        }

        public static int Insert_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc", a.MaNCC),
                new SqlParameter("@tenncc", a.TenNCC),
                new SqlParameter("@diachincc", a.DiaChi),
                new SqlParameter("@sdtncc", a.SDT),
                new SqlParameter("@email",a.Email),
            
            };
            return DataProvider.ExecuteNonQuery("Insert_NCC", para);
        }

        public static int Update_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc", a.MaNCC),
                new SqlParameter("@tenncc", a.TenNCC),
                new SqlParameter("@diachincc", a.DiaChi),
                new SqlParameter("@sdtncc", a.SDT),
                new SqlParameter("@email",a.Email),

            };
            return DataProvider.ExecuteNonQuery("Update_NCC", para);
        }


        public static int Delete_NCC(NCC a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc", a.MaNCC),
            };
            return DataProvider.ExecuteNonQuery("Delete_NCC", para);
        }

        //Phieu Muon
        public static DataTable Select_PM()
        {
            return DataProvider.GetData("Select_PM");
        }


        public static int Insert_PM(PhieuMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@mapm", a.MaPM),
                       new SqlParameter("@ngaymuon", a.NgayMuon),
                       new SqlParameter("@ngaytra", a.NgayTra),
                       new SqlParameter("@madg", a.MaDG),
                       new SqlParameter("@matt", a.MaTT),
                       
             };
            return DataProvider.ExecuteNonQuery("Insert_PM", para);
        }

        public static int Update_PM(PhieuMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {

                       new SqlParameter("@mapm", a.MaPM),
                       new SqlParameter("@ngaymuon", a.NgayMuon),
                       new SqlParameter("@ngaytra", a.NgayTra),
                       new SqlParameter("@madg", a.MaDG),
                       new SqlParameter("@matt", a.MaTT),


                      };
            return DataProvider.ExecuteNonQuery("Update_PM", para);
        }


        public static int Delete_PM(PhieuMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@mapm", a.MaPM),
            
                      };
            return DataProvider.ExecuteNonQuery("Delete_PM", para);
        }


        //Chi Tiet Muon
        public static DataTable Select_CTM()
        {
            return DataProvider.GetData("Select_CTM");
        }

        public static int Insert_CTM(ChiTietMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@mapm", a.MaPM),
                       new SqlParameter("@macs", a.MaCS),
                       new SqlParameter("@tinhtrang", a.TinhTrang),

                      };
            return DataProvider.ExecuteNonQuery("Insert_CTM", para);
        }


        public static int Update_CTM(ChiTietMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@mapm", a.MaPM),
                    new SqlParameter("@macs", a.MaCS),
                    new SqlParameter("@tinhtrang", a.TinhTrang),
                       
                      };
            return DataProvider.ExecuteNonQuery("Update_CTM", para);
        }



        public static int Delete_CTM(ChiTietMuon a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                       new SqlParameter("@mapm", a.MaPM),
                       new SqlParameter("@macs", a.MaCS),
                    
                      };
            return DataProvider.ExecuteNonQuery("Delete_CTM", para);
        }


      
        
    }
}
