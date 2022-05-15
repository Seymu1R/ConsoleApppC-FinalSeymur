using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Models
{
    class Student
    {
        public  int Id=0;
        public static int Count;
        public string FullName;
        public string GroupNo;
        public string Type;
        public int EntryPoint;
       
        public Student(string fullname,string groupno, int entrypoint)
        {
            Id =++Count;
            FullName = fullname;
            GroupNo = groupno;
            EntryPoint = entrypoint;
            if (EntryPoint>=90)
            {
                Type = "Zemanetli";
            }
            else
            {
                Type = "Zemanetsiz";
            }
        }
        public override string ToString()
        {
            return $" Telebenin Id nomresi - {Id}\n Telebenin ad ve soyadi - {FullName}\n Telebenin Grup nomresi - {GroupNo}\n Telebenin zemaneli ve ya zemanetsiz olmasi - {Type}";
        }
    }
}
