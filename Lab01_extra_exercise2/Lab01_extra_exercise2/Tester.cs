using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra
{
    class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            
            DSSV = NhapSV();

            XuatSV(DSSV);
                
            Console.ReadLine();
        }

        public static Student[] NhapSV() {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n --- NHAP DS SINH VIEN --- ");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.WriteLine("\n- Sinh vien {0}", i + 1);
                Console.Write(" MaSV: ");
                DSSV[i].SID = int.Parse(Console.ReadLine());
                Console.Write(" Ho ten SV: ");
                DSSV[i].TenSV = Console.ReadLine();
                Console.Write(" Khoa: ");
                DSSV[i].Khoa = Console.ReadLine();
                Console.Write(" Diem TB: ");
                DSSV[i].DiemTB = float.Parse(Console.ReadLine());
                Console.WriteLine("\n ---------------------------------------- ");
            }
            return DSSV;
        }

        public static void XuatSV(Student[] DSSV) {
            //Xuat DS Sinh vien
            Console.WriteLine("\n --- XUAT DS SINH VIEN ---");
            foreach (Student sv in DSSV)
            {
                sv.Show();
                Console.WriteLine("\n ---------------------------------------- ");
            }
        }

    }
}
