using System;
using System.Collections.Generic;
using System.Text;

namespace Day01_QuanLySinhVien
{
    /// <summary>
    /// Class of MonHoc
    /// </summary>
    public class MonHoc
    {
        //==================================================================
        //Contructor & Destructor
        public MonHoc() { }
        ~ MonHoc() { }
        //==================================================================
        //Properties
        public string tenMH { get; set; }
        public int soTiet { get; set; }
        private double diemQT { get; set; }
        private double diemTP { get; set; }
        //==================================================================
        //Method
        public void setMH(string TenMH, int SoTiet)
        {
            tenMH = TenMH;
            soTiet = SoTiet;
        }
        public void setDiemMH(double DiemQT, double DiemTP)
        {
            DiemQT = diemQT;
            DiemTP = diemTP;
        }
        public void showInfoMH()
        {
            Console.Write("\n{0,-21}\t{1,-5}",tenMH, soTiet);
        }
        public void showInfoMH_DK()
        {
            Console.Write("\nTen mon: {0}\nSo tiet: {1}\n", tenMH, soTiet);
        }
        public void showInfoMH_SV()
        {
            Console.Write($"\nTen mon hoc: {tenMH}\nSo tiet: {soTiet}\nDiem qua trinh: {diemQT}\nDiem tong ket: {diemTongKet()}\nKet qua: {(isPass() == true ? "Dau" : "Rot")}");
        }
        public double diemTongKet()
        {
            return (diemQT + diemTP) / 2;
        }
        public bool isPass()
        {
            return diemTongKet() >= 4;
        }
    }
}
