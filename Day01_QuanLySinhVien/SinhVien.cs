using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day01_QuanLySinhVien
{
    /// <summary>
    /// Class for SinhVien
    /// </summary>
    public class SinhVien : Controler
    {
        //==================================================================
        //Contructor & Destructor
        public SinhVien() { }
        ~ SinhVien() { }
        //==================================================================
        //Properties
        private string MaSV { get; set; }
        private string TenSV { get; set; }
        private string GioiTinh { get; set; }
        private DateTime NgaySinh  { get; set; }
        private string Lop { get; set; }
        private string Khoa { get; set; }

        public List<MonHoc> MonHocDK = new List<MonHoc>();  
        //==================================================================
        //Method

        /// <summary>
        /// Get info of SinhVien
        /// </summary>
        public void getData()
        {
            Console.WriteLine("-Nhap thong tin cua sinh vien-");
            Console.Write("\nMa sinh vien: ");
            MaSV = Convert.ToString(Console.ReadLine());
            Console.Write("\nHo ten: ");
            TenSV = Convert.ToString(Console.ReadLine());
            Console.Write("\nGioi tinh: ");
            GioiTinh = Convert.ToString(Console.ReadLine());
            
            DateTime date = new DateTime();
            bool flag;
            do
            {
                Console.Write("\nNhap ngay sinh(mm/dd/yy) :");//theo thứ tự tháng/ngày/năm
                flag = DateTime.TryParse(Console.ReadLine(), out date);               
                if (flag == false)
                {
                    Console.WriteLine("KHONG DUNG DINH DANG, VUI LONG NHAP LAI!");
                }

            } while (flag == false);
            NgaySinh = date;
            Console.Write("\nLop: ");
            Lop = Convert.ToString(Console.ReadLine());
            Console.Write("\nKhoa: ");
            Khoa = Convert.ToString(Console.ReadLine());
        }
        public void getData(string maSV, string tenSV, string gioiTinh, DateTime ngaySinh, string lop, string khoa)
        {
            MaSV = maSV;
            TenSV = tenSV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Lop = lop;
            Khoa = khoa;
        }
        public void dangKyMonHoc(List<MonHoc> list_MH)
        {
            string pick;
            showCurrentListMH(list_MH);
            Console.WriteLine();
            DuongKe();
            Console.Write("\n-Dang Ky Mon Hoc-");
            foreach (var item in list_MH)
            {
                item.showInfoMH_DK();
                Console.Write("\nDang ky? (Y/N): ");
                pick = Console.ReadLine();
                if (pick == "Y" || pick == "y")
                {
                    MonHocDK.Add(item);
                }
            }
            showMonHocDaDK();

        }
        //public bool isMonHocDaDK(List<MonHoc> list_MH)
        //{
        //    bool flag = false;
        //    foreach (var item in MonHocDK)
        //    {
        //        item.tenMH;
        //    }
        //    return flag;
        //}
        //public bool searchMH(string mh_name)
        //{
        //    return 
        //}
        public void showMonHocDaDK()
        {
            Console.Write("\n\t---Cac mon hoc da dang ky---\n");
            DuongKe();
            showCurrentListMH(MonHocDK);
        }
        /// <summary>
        /// Show info of SinhVien
        /// </summary>
        public void showData()
        {
            Console.Write("\n{0,-11}\t{1,-18}\t{2,-3}\t{3}/{4}/{5}\t{6,-11}\t{7}", this.MaSV, this.TenSV, this.GioiTinh, this.NgaySinh.Day, this.NgaySinh.Month, this.NgaySinh.Year, this.Lop, this.Khoa);
        }
    }
}
