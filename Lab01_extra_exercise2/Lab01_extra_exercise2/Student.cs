using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra
{
    class Student
    {
        private int sID;
        private String tenSV;
        private String khoa;
        private float diemTB;
        public Student()
        {
            SID = 1;
            TenSV = "Trinh Quang Hien";
            Khoa = "CNTT";
            DiemTB = 8;
        }
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public string TenSV { get => tenSV; set => tenSV = value; }
        public int SID { get => sID; set => sID = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }

        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
            Console.WriteLine("Diem TB:{0}", this.DiemTB);
        }

    }
}
