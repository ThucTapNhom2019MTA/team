using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLThuVien.DataAccessLayer;
using QLThuVien.ValueObject;


namespace QLThuVien.BUSLayer
{
    public class BUS
    {

        //Ke Sach
        public static DataTable Select_KeSach()
        {
            return DAO.Select_KeSach();
        }
        public static int Insert_KeSach(KeSach a)
        {
            return DAO.Insert_KeSach(a);
        }
        public static int Update_KeSach(KeSach a)
        {
            return DAO.Update_KeSach(a);
        }
        public static int Delete_KeSach(KeSach a)
        {
            return DAO.Delete_KeSach(a);
        }

        //Thu Thu
        public static DataTable Select_TT()
        {
            return DAO.Select_TT();
        }
        public static int Insert_TT(ThuThu a)
        {
            return DAO.Insert_TT(a);
        }
        public static int Update_TT(ThuThu a)
        {
            return DAO.Update_TT(a);
        }
        public static int Delete_TT(ThuThu a)
        {
            return DAO.Delete_TT(a);
        }

        //Doc Gia
        public static DataTable Select_DG()
        {
            return DAO.Select_DG();
        }
        public static int Insert_DG( DocGia a)
        {
            return DAO.Insert_DG(a);
        }
        public static int Update_DG( DocGia a)
        {
            return DAO.Update_DG(a);
        }
        public static int Delete_DG(DocGia a)
        {
            return DAO.Delete_DG(a);
        }
       
        //Tac Gia
        public static DataTable Select_TG()
        {
            return DAO.Select_TG();
        }
        public static int Insert_TG(TacGia a)
        {
            return DAO.Insert_TG(a);
        }
        public static int Update_TG(TacGia a)
        {
            return DAO.Update_TG(a);
        }
        public static int Delete_TG(TacGia a)
        {
            return DAO.Delete_TG(a);
        }
        //NXB
        public static DataTable Select_NXB()
        {
            return DAO.Select_NXB();
        }
        public static int Insert_NXB(NXB a)
        {
            return DAO.Insert_NXB(a);
        }
        public static int Update_NXB(NXB a)
        {
            return DAO.Update_NXB(a);
        }
        public static int Delete_NXB(NXB a)
        {
            return DAO.Delete_NXB(a);
        }

        //Tua Sach
        public static DataTable Get_TS(char @mats)
        {
            return DAO.Get_TS(@mats);
        }

        public static DataTable Select_TS()
        {
            return DAO.Select_TS();
        }
        public static int Insert_TS(TuaSach a)
        {
            return DAO.Insert_TS(a);
        }
        public static int Update_TS(TuaSach a)
        {
            return DAO.Update_TS(a);
        }
        public static int Delete_TS(TuaSach a)
        {
            return DAO.Delete_TS(a);
        }

        //CUon Sach
        public static DataTable Select_CS()
        {
            return DAO.Select_CS();
        }
        public static int Insert_CS(CuonSach a)
        {
            return DAO.Insert_CS(a);
        }
        public static int Update_CS(CuonSach a)
        {
            return DAO.Update_CS(a);
        }
        public static int Delete_CS(CuonSach a)
        {
            return DAO.Delete_CS(a);
        }

        //Viet
        public static DataTable Select_Viet()
        {
            return DAO.Select_Viet();
        }
        public static int Insert_Viet(Viet a)
        {
            return DAO.Insert_Viet(a);
        }
        public static int Update_Viet(Viet a)
        {
            return DAO.Update_Viet(a);
        }
        public static int Delete_Viet(Viet a)
        {
            return DAO.Delete_Viet(a);
        }

        //Phieu PM
        public static DataTable Select_PM()
        {
            return DAO.Select_PM();
        }
        public static int Insert_PM(PhieuMuon a)
        {
            return DAO.Insert_PM(a);
        }
        public static int Update_PM(PhieuMuon a)
        {
            return DAO.Update_PM(a);
        }
        public static int Delete_PM(PhieuMuon a)
        {
            return DAO.Delete_PM(a);
        }

        //Chi Tiet Muon
        public static DataTable Select_CTM()
        {
            return DAO.Select_CTM();
        }
        public static int Insert_CTM(ChiTietMuon a)
        {
            return DAO.Insert_CTM(a);
        }
        public static int Update_CTM(ChiTietMuon a)
        {
            return DAO.Update_CTM(a);
        }
        public static int Delete_CTM(ChiTietMuon a)
        {
            return DAO.Delete_CTM(a);
        }
        //Nha Cung Cap
        public static DataTable Select_NCC()
        {
            return DAO.Select_NCC();
        }
        public static int Insert_NCC(NCC a)
        {
            return DAO.Insert_NCC(a);
        }
        public static int Update_NCC(NCC a)
        {
            return DAO.Update_NCC(a);
        }
        public static int Delete_NCC(NCC a)
        {
            return DAO.Delete_NCC(a);
        }

        //Phieu Nhap
        public static DataTable Select_PN()
        {
            return DAO.Select_PN();
        }
        public static int Insert_PN(PhieuNhap a)
        {
            return DAO.Insert_PN(a);
        }
        public static int Update_PN(PhieuNhap a)
        {
            return DAO.Update_PN(a);
        }
        public static int Delete_PN(PhieuNhap a)
        {
            return DAO.Delete_PN(a);
        }


        //Chi Tiet Nhap
        public static DataTable Select_CTN()
        {
            return DAO.Select_CTN();
        }
        public static int Insert_CTN(ChiTietNhap a)
        {
            return DAO.Insert_CTN(a);
        }
        public static int Update_CTN(ChiTietNhap a)
        {
            return DAO.Update_CTN(a);
        }
        public static int Delete_CTN(ChiTietNhap a)
        {
            return DAO.Delete_CTN(a);
        }
       

        }
    }

