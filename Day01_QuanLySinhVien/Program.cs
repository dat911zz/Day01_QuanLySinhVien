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
                        dssv.AutoDKMH_SV("DKHP");
                        break;
                    case 2:
                        dssv.showListSV();
                        break;
                    case 3:
                        //dssv.showCurrentListMH(dssv.list_MH);
                        //dssv.list_SV[2].dangKyMonHoc(dssv.list_MH);                      
                        dssv.SearchInfoSV();
                        break;
                    case 4:
                        dssv.SearchListMHSV();
                        break;
                    case 5:
                        dssv.AutoImportScoreSV();
                        dssv.ShowListScoreSV();
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("EXIT!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (chon > 0 && chon < 9);
        }
        static void menu()
        {
            Console.Write("\n1. Doc File");
            Console.Write("\n2. Xuat danh sach sinh vien");
            Console.Write("\n3. Xuat thong tin sinh vien");
            Console.Write("\n4. Xem so mon hoc");
            Console.Write("\n5. Xem so diem mon hoc");
            Console.Write("\n6. Nhap diem sinh vien");
            Console.Write("\n7. Xem ket qua hoc tap");
        }
    }
    
}
