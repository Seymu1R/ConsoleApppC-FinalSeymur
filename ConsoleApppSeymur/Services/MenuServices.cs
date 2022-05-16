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
            Console.WriteLine("Zehmet olmasa grupun online ve ya ofline olmasin daxil edin \n 1-online \n 2-offline");
            goup:
            try
            {
                selection = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("xais olunur reqem daxil edin");
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
                Console.WriteLine("Zehmet olmasa 1 ve ya 2 daxil edin");
                goto goup;
            }
            Console.WriteLine("Zehmet olmasa yaratmaq istediyiniz qrupun  kateqoriyasini daxil edin");
            goup1:
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine((int)item + " - " + item.ToString());
            }            
            
           categoryResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out selectioncategory);
            if ((int)selectioncategory<1||(int)selectioncategory>3)
            {
                Console.WriteLine("Zehmet olmasa ekrandaki reqemleri secin");
                goto goup1;

            }            
            
            if (categoryResult)
            {
                academyservices.CreateGroup(selectionresult, (Categories)selectioncategory); 
            }
            else
            {
                Console.WriteLine(" Qrup yarana bilmedi buna sebeb yalnis katagoriya secimi ola biler");
            }


        }
        public static void ShowGroupListMenu() {
            academyservices.ShowGroupList();
        }
        public static void EditGroupMenu() {
            Console.WriteLine("zehmet olmasa deyisiklik etmek  istediyiniz qrupun nomresini daxil edin");
            string oldgroupno = Console.ReadLine();
            Console.WriteLine("zehmet olmasa yeni qrupu daxil edin ");
            string newgroupno = Console.ReadLine();
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
