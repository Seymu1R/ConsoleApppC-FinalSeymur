using ConsoleApppSeymur.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Services
{
    static class MenuServices
    {
        public static AcademyServices academyservices = new AcademyServices();
        public static bool selectionresult;
        public static int selection;
        public static bool categoryResult;
        public static object selectioncategory;

        public static void CreateGroupMenu() {
            Console.WriteLine("Please enter the group online or offline \n 1-online \n 2-offline");
            goup:
            try
            {
                selection = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the number");
                goto goup;
            }
            
            if (selection==1)
            {                
                selectionresult = true;                
            }
            else if (selection==2)
            {
                selectionresult = false;
            }
            else
            { 
                Console.WriteLine("Please enter 1 or 2");
                goto goup;
            }
            Console.WriteLine("Please enter the category of the group you want to create");
            goup1:
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine((int)item + " - " + item.ToString());
            }            
            
           categoryResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out selectioncategory);
            if (categoryResult==false)
            {
                Console.WriteLine("Please select the numbers on the screen");
                goto goup1;
            }
            if ((int)selectioncategory<1||(int)selectioncategory>3)
            {
                Console.WriteLine("Please select the numbers on the screen");
                goto goup1;

            }            
            
            if (categoryResult)
            {
                academyservices.CreateGroup(selectionresult, (Categories)selectioncategory); 
            }
            else
            {
                Console.WriteLine(" The group could not be created the reason may be the wrong category selection");
            }


        }
        public static void ShowGroupListMenu() {
            academyservices.ShowGroupList();
        }
        public static void EditGroupMenu() {
            Console.WriteLine("Please enter the number of the group you want to change");
            string oldgroupno = Console.ReadLine();
            Console.WriteLine("Please enter a new group");
            string newgroupno = Console.ReadLine();
            academyservices.EditGroup(oldgroupno, newgroupno);

        }
        public static void ShowStudentListInGroupMenu() {
            Console.WriteLine("Please include which group you want to look at");
            string grupno = Console.ReadLine();           
            
            academyservices.ShowStudentListInGroup(grupno);
        }
        public static void ShowAllStudentsMenu() {
            academyservices.ShowAllStudents();
        }
        public static void CreateStudentMenu() {
            Console.WriteLine("Please enter the group number you want to add students");
            string groupno= Console.ReadLine();
            Console.WriteLine("Please enter the name and surname of the student");
            string fullname=Console.ReadLine();
            Console.WriteLine("Please enter the student's entrypoint");
            int entrypoint = int.Parse(Console.ReadLine());
            academyservices.CreateStudent(fullname, groupno, entrypoint);
        }
        public static void DeleteStudentMenu() {
            Console.WriteLine("Please enter the group from which you will delete the student");
            string groupno = Console.ReadLine();
            Console.WriteLine("Please enter the ID of the student you want to delete");
            int id = int.Parse(Console.ReadLine());
            academyservices.DeleteStudent(groupno, id);
        }

    }
}
