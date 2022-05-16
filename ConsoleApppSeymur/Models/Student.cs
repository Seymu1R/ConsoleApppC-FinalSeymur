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
                Type = "Guaranteed";
            }
            else
            {
                Type = "Not guaranteed";
            }
        }
        public override string ToString()
        {
            return $" Student's Id number - {Id}\n The student's name and surname - {FullName}\n Student's Group Number - {GroupNo}\n Student is guaranteed or not - {Type }";
        }
    }
}
