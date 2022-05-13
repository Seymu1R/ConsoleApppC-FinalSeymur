using ConsoleApppSeymur.Enums;
using ConsoleApppSeymur.Models;
using System;
using ConsoleApppSeymur.Services;

namespace ConsoleApppSeymur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Group group1 = new Group(true,Categories.Design);

            Console.WriteLine(group1.GeneralyStudent.Capacity);
        }
    }
}
