using ConsoleApppSeymur.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Models
{
    class Group
    {
        public string No;
        Categories Category;
        bool _Isonline;
        int _limit;
        public static int Count;
        private List<Student> _generalyStudent;
        public List<Student> GeneralyStudent { get { return _generalyStudent;}  }
        public int limit { get { return _limit; } }

        public bool Isonline
        {
            get { return _Isonline; }
            set {
                _Isonline = value;
                if (value == true)
                {
                    _limit = 15;

                }
                else
                {
                    _limit = 10;
                }
            }
        }
        static Group() {
            Count = 100;
        }
        public Group(bool online, Categories category)
        {
            
            Isonline = online;

            if (Isonline==true)
            {
                _generalyStudent = new List<Student>(15);
            }
            else
            {
                _generalyStudent = new List<Student>(10);
            }
            switch (category)
            {
                 case Categories.Programming:
                    No= $"P" + Count;
                    break;
                case Categories.Design:
                    No = $"D" + Count;
                    break;
                case Categories.System_Admistrator:
                    No = $"S" + Count;
                    break;
                default:
                    break;
            }
            Category = category;
            Count++;
        }
        
    }
}
