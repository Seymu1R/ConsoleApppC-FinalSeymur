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
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.Title = "My EducationManagerAplication";
            Console.WriteLine(Console.Title);
            int selection;


            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Create Group");
                Console.WriteLine("2. Show Group list,");
                Console.WriteLine("3. Show Students list In Group");
                Console.WriteLine("4. Show Students List");
                Console.WriteLine("5. Create Student");
                Console.WriteLine("6. Delete Student");
                Console.WriteLine("0. Exit");
                selection = int.Parse(Console.ReadLine());                 
                switch (selection)
                {
                    case 1:
                        MenuServices.CreateGroupMenu();
                        break;

                    case 2:
                        MenuServices.ShowGroupListMenu();
                        break;

                    case 3:
                        MenuServices.ShowStudentListInGroupMenu();
                        break;
                    case 4:
                        MenuServices.ShowAllStudentsMenu();
                        break;

                    case 5:
                        MenuServices.CreateStudentMenu();
                        break;

                    case 6:
                        MenuServices.DeleteStudentMenu();
                        break;

                    default:
                        break;
                }
            } while (selection != 0);
            
            


        }
    }
}
