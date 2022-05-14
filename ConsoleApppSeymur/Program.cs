using ConsoleApppSeymur.Enums;
using ConsoleApppSeymur.Models;
using System;
using ConsoleApppSeymur.Services;
using System.Collections.Generic;

namespace ConsoleApppSeymur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MenuServices.CreateGroupMenu();
            MenuServices.ShowGroupListMenu();
            MenuServices.CreateStudentMenu();
            MenuServices.ShowStudentListInGroupMenu();
            
        }
    }
}
