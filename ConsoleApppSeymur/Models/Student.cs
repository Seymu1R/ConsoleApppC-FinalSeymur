using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Models
{
    class Student
    {
        public static int Id=0;
        public static int Count;
        public string FullName;
        public string GroupNo;
        public bool Type;
        public int EntryPoint;
       
        public Student(string fullname,string groupno, int entrypoint)
        {
            Id =++Count;
            FullName = fullname;
            GroupNo = groupno;
            EntryPoint = entrypoint;
            if (EntryPoint>90)
            {
                Type = true;
            }
            else
            {
                Type = false;
            }
        }
    }
}
