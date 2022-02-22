using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day01_QuanLySinhVien
{

    public class QuanLy : Controler
    {
        //==================================================================
        //Contructor & Destructor
        public QuanLy() { }
        ~ QuanLy() { }
        //==================================================================
        //Properties
        public List<SinhVien> list_SV = new List<SinhVien>();
        public List<MonHoc> list_MH = new List<MonHoc>();
        
        //==================================================================
        //Method
        //----------------------------------------------------------
        /// <summary>
        /// Get data from file
        /// </summary>
        /// <param name="list"></param>
        public void ReadFile_SV(string fname)
        {
            string[] line;
            //Đọc giá trị từ file
            try
            {
                line = File.ReadAllLines($"../../../{fname}.txt");
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t_[Doc file khong thanh cong!]_\t");
                Console.ResetColor();
                return;
            }
            try
            {

                for (int i = 0; i < line.Length; ++i)
                {
                    SinhVien x = new SinhVien();
                    string[] data = line[i].Split(' ');
                    //-------------INPUT DATA----------------
                    x.getData(data[0], data[1], data[2], DateTime.Parse(data[3]), data[4], data[5]);
                    //---------------------------------------
                    //Thêm phần tử vào cuối DSLK
                    list_SV.Add(x);
                }
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t_[Doc file thanh cong!]_\t");
                Console.ResetColor();
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                return;
            }
        }
        public void ReadFile_MH(string fname)
        {
            string[] line;
            //Đọc giá trị từ file
            try
            {
                line = File.ReadAllLines($"../../../{fname}.txt");
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t_[Doc file khong thanh cong!]_\t");
                Console.ResetColor();
                return;
            }
            try
            {

                for (int i = 0; i < line.Length; ++i)
                {
                    MonHoc x = new MonHoc();
                    string[] data = line[i].Split(' ');
                    //-------------INPUT DATA----------------
                    x.getMH(data[0], int.Parse(data[1]));
                    //---------------------------------------
                    //Thêm phần tử vào cuối DSLK
                    list_MH.Add(x);
                }
                //for (int i = 0; i < line.Length; i++)
                //{
                //    Console.WriteLine(line[i]);
                //}
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t_[Doc file thanh cong!]_\t");
                Console.ResetColor();
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                return;
            }
        }
        public void AutoDKMH_SV(string fname)
        {
            string[] line;
            //Đọc giá trị từ file
            try
            {
                line = File.ReadAllLines($"../../../{fname}.txt");
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t_[Doc file khong thanh cong!]_\t");
                Console.ResetColor();
                return;
            }
            try
            {

                for (int i = 0; i < line.Length; ++i)
                {
                    string[] data = line[i].Split(' ');
                    //-------------INPUT DATA----------------
                    //SinhVien x = new SinhVien();
                    for (int mh_i = 0; mh_i < data.Length; mh_i++)
                    {
                        if (data[mh_i].ToString() == "1")
                        {
                            list_SV[i].MonHocDK.Add(list_MH[mh_i]);
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Staged {0}: passed",i);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
            }
            catch (IOException e)
            {
                Console.Write(e.Message);
                return;
            }
        }
        //----------------------------------------------------------
        
        public void showListSV()
        {
            Console.WriteLine("\n\t\t\t-Danh sach sinh vien-");
            Khuon_SV();
            Console.ResetColor();
            if (list_SV.Count < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\t  [EMPTY LIST!]");
                Console.ResetColor();
                return;
            }
            for (int i = 0; i < list_SV.Count; i++)
            {
                list_SV[i].showData();
            }
        }

        public void showInfoSV(string name)
        {
            SinhVien a = new SinhVien();
            
        }
        //----------------------------------------------------------
        
        
    }

    public class Controler
    {
        public void DuongKe()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
            }
        }
        public void Khuon_SV()
        {
            Console.WriteLine("Ma SV\t\tTen SV\t\t   Gioi Tinh\tNgay Sinh\tLop\t\tKhoa");
            DuongKe();
        }
        public void Khuon_MH()
        {
            Console.Write("Ten MH\t\t\tSo tiet\n");
            DuongKe();
        }
        public void showCurrentListMH(List<MonHoc> list_MH)
        {
            Console.WriteLine("\nDanh sach mon hoc hien co trong CSDL: \n");
            Khuon_MH();
            foreach (var item in list_MH)
            {
                item.showInfoMH();
            }
        }
    }
}
