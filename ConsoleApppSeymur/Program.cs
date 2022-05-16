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
            Console.SetCursorPosition(20, 2);            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;            
            Console.Title = "Student Management System";
            Console.WriteLine(Console.Title);
            int selection;
            goup:
            try
            {
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("1. Create Group");
                    Console.WriteLine("2. Show Group list,");
                    Console.WriteLine("3. Edit Group list");
                    Console.WriteLine("4. Show Students list In Group");
                    Console.WriteLine("5. Show All Students List");
                    Console.WriteLine("6. Create Student");
                    Console.WriteLine("7. Delete Student");
                    Console.WriteLine("0. Exit");

                    
                    selection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateGroupMenu();
                            break;

                        case 2:
                            MenuServices.ShowGroupListMenu();
                            break;
                        case 3:
                            MenuServices.EditGroupMenu();
                            break;

                        case 4:
                            MenuServices.ShowStudentListInGroupMenu();
                            break;
                        case 5:
                            MenuServices.ShowAllStudentsMenu();
                            break;

                        case 6:
                            MenuServices.CreateStudentMenu();
                            break;

                        case 7:
                            MenuServices.DeleteStudentMenu();
                            break;

                        default:
                            break;
                    }
                } while (selection != 0);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter number");
                goto goup;
            }
           
            
            


        }
    }
}
