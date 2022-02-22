using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Day01_QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLy dssv = new QuanLy();
            string fname;
            int chon = 0;        
            do
            {
                menu();
                Console.Write("\nChon: ");
                if (int.TryParse(Console.ReadLine(), out chon) == false)
                {
                    return;
                }
                switch (chon)
                {
                    case 1:
                        Console.Write("\nNhap ten file can lay thong tin: ");
                        fname = Console.ReadLine();
                        dssv.ReadFile_SV(fname);
                        dssv.ReadFile_MH("MonHoc");
                        break;
                    case 2:
                        dssv.showListSV();
                        break;
                    case 3:
                        //dssv.showCurrentListMH(dssv.list_MH);
                        //dssv.list_SV[2].dangKyMonHoc(dssv.list_MH);
                        dssv.AutoDKMH_SV("DKHP");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("EXIT!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (chon > 0 && chon < 9);

            //Console.Write("Nhap so luong sinh vien: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    SinhVien tmp = new SinhVien();
            //    tmp.getData();
            //    sv.Add(tmp);
            //}
            

        }
        static void menu()
        {
            Console.WriteLine("\n1. Doc File\n2. Xuat danh sach sinh vien\n3. Xuat thong tin sinh vien\n4. UNKNOWN!");
        }
    }
    
}
