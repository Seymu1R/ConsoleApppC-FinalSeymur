using ConsoleApppSeymur.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Services
{
    static class MenuServices
    {
        public static AcademyServices academyservices = new AcademyServices();
        private static object item;

        public static void CreateGroupMenu() {

            Console.WriteLine("zehmet olmasa grupun online ve ya ofline olmasin daxil edin\n 1-online\n 2-ofline");
            foreach ((var item in System.Enum.GetValues(typeof(Categories)))
                    {
                Console.WriteLine($"{(int)item}.{item}");
            }

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                   
                    
                    break;
                default:
                    break;
            }
        }

    }
}
