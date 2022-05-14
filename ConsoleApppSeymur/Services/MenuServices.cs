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

        public static void CreateGroupMenu() {
            Console.WriteLine("Zehmet olmasa grupun online ve ya ofline olmasin daxil edin \n 1-online \n 2-offline");
            goup:
            int selection=int.Parse(Console.ReadLine());
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
                Console.WriteLine("Zehmet olmasa 1 ve ya 2 daxil edin");
                goto goup;
            }
            Console.WriteLine("Zehmet olmasa yaratmaq istediyiniz qrupun  kateqoriyasini daxil edin");
            object selectioncategory;
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine((int)item + " - " + item.ToString());
            }
            bool categoryResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out selectioncategory);
            if (categoryResult)
            {
                academyservices.CreateGroup(selectionresult, (Categories)selectioncategory); 
            }
            else
            {
                Console.WriteLine("nese yalnis getdi");
            }


        }
        public static void ShowGroupListMenu() {
            academyservices.ShowGroupList();
        }
        public static void EditGroupMenu() {
            Console.WriteLine("zehmet olmasa deyisiklik etmek  istediyiniz qrupun nomresini daxil edin");
            string newgroupno = Console.ReadLine();
            Console.WriteLine("zehmet olmasa yeni qrupu daxil edin ");
            string oldgroupno = Console.ReadLine();
            academyservices.EditGroup(oldgroupno, newgroupno);

        }
        public static void ShowStudentListInGroupMenu() {
            Console.WriteLine("zehmet olmasa hansi qrupa baxmaq istediyinizi qeyd edin");
            string grupno = Console.ReadLine();
            academyservices.ShowStudentListInGroup(grupno);
        }
        public static void ShowAllStudentsMenu() {
            academyservices.ShowAllStudents();
        }
        public static void CreateStudentMenu() {
            Console.WriteLine("Zehmet olmasa telebeni elave etmek istediyiniz grupun nomresini daxil edin");
            string groupno= Console.ReadLine();
            Console.WriteLine("Zehmet olmasa telebenin adini soyadini daxil edin");
            string fullname=Console.ReadLine();
            Console.WriteLine("Zehmet olmasa telebenin giris balini daxil edin");
            int entrypoint = int.Parse(Console.ReadLine());
            academyservices.CreateStudent(fullname, groupno, entrypoint);
        }
        public static void DeleteStudentMenu() {
            Console.WriteLine("Zehmet olmasa telebeni hansi grupdan sececeyinizi daxil edin");
            string groupno = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa silmek istediyiniz telebenin Id sini daxil edin");
            int id = int.Parse(Console.ReadLine());
            academyservices.DeleteStudent(groupno, id);
        }

    }
}
