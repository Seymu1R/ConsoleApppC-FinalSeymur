using ConsoleApppSeymur.Enums;
using System;
using ConsoleApppSeymur.Models;
using System.Collections.Generic;
using System.Text;
using ConsoleApppSeymur.Iacademyservices;



namespace ConsoleApppSeymur.Services
{
  class AcademyServices : IacademyInterfaces
    {
        List<Group> _groups = new List<Group>();
        int a = 0;
        public List<Group> Groups => _groups;
        bool result;
        bool result1;
        public  void CreateGroup(bool online, Categories category) {
            Group group = new Group (online, category);            
            Groups.Add(group);
            Console.WriteLine(group+ "\nQrup yaradildi qrupun limiti - "+ group.limit);
            
        }
        public  void ShowGroupList() {
            if (Groups.Count > 0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("Gosterilecek qrup yoxdur");
            }

        }
        public void EditGroup(string oldGroupNo, string newGroupNo) {
            
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() != oldGroupNo.ToLower().Trim())
                {
                    ++a;
                    if (Groups.Count==a)
                    {
                        a = 0;
                        Console.WriteLine("Deyisiklik etmek istediyiniz qrup sistemde yoxdur");
                        break;
                    }
                    
                    
                }
                if (group.No.ToLower().Trim()==newGroupNo.ToLower().Trim())
                {
                    Console.WriteLine("daxil etmek istediyiniz qrup sistemde var");
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }                                                           
                
            }
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == oldGroupNo.ToLower().Trim())
                {
                    result1 = true;
                    break;
                }
                else
                {
                    result1 = false;
                }         

            }
            if (result==true && result1==true)
            {
                foreach (var item in Groups)
                {
                    if (item.No.ToLower().Trim() == oldGroupNo.ToLower().Trim())
                    {
                        item.No = newGroupNo;
                        Console.WriteLine("Qrup muveffeqiyyetle deyisdi");
                    }
                }

            }
        }
        public void ShowStudentListInGroup(string no) {
            if (Groups.Count == 0)
            {
                Console.WriteLine("Academiyada qrup ve telebe yoxdur");

            }
            foreach (Group item in Groups )
            {
                                
                    if (item.No.ToLower().Trim() == no.ToLower().Trim())
                    {
                        if (item.GeneralyStudent.Count == 0)
                        {
                            Console.WriteLine("Daxil etdiyiniz qrupda telebe yoxdur");
                            break;

                        }
                        foreach (Student students in item.GeneralyStudent)
                        {

                            Console.WriteLine(students);

                        }

                    }
                else
                {
                    ++a;
                    if (a==Groups.Count)
                    {
                        a = 0;
                        Console.WriteLine("Daxil etdiyiniz qrup yoxdur");
                    }
                    
                }
                
                    

                
            }

        }
        public void ShowAllStudents() {
            if (Groups.Count == 0)
            {
                Console.WriteLine("Academiyada qrup ve telebe yoxdur");

            }
            foreach (Group groups in Groups)
            {
                if (groups.GeneralyStudent.Count!=0)
                {
                    foreach (Student students in groups.GeneralyStudent)
                    {
                        Console.WriteLine(students);
                    }
                }
                else
                {
                    a++;
                    if (a==Groups.Count)
                    {
                        a = 0;
                        Console.WriteLine("academiyada telebe yoxdur");
                    }
                }

            }
        }
        public void CreateStudent( string fullname, string groupno, int entrypoint) {
            Student student;
            if (Groups.Count == 0)
            {
                Console.WriteLine("Academiyada qrup yoxdur və tələbə daxil edilmedi");
                
            }
            foreach (var item in Groups)
            {

                if (item.No.ToLower().Trim() == groupno.ToLower().Trim())
                {
                    if (item.GeneralyStudent.Count <= item.limit)
                    {
                        item.GeneralyStudent.Add(student = new Student(fullname, groupno, entrypoint));
                        Console.WriteLine("Daxil etdiyiniz qrupa telebe elave edildi");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Grup is full");
                        break;
                    }
                }
                else
                {
                    a++;
                    if (a == Groups.Count)
                    {
                        a = 0;
                        Console.WriteLine("Daxil etdiyiniz qrup sistemde yoxdur");
                        break;
                    }
                }                           
               
               
                
                
            }
                      
            
        }
        public void DeleteStudent(string groupNo, int studentNo)
        {
            foreach (var item in Groups)
            {
                if (Groups.Count == 0)
                {
                    Console.WriteLine("Academiyada qrup ve telebe yoxdur");
                }
                if (item.No.ToLower().Trim() == groupNo.ToLower().Trim())
                {
                    if (item.GeneralyStudent.Count==0)
                    {
                        Console.WriteLine("Qrup bosdur silinecek telebe yoxdur");
                    }
                    foreach (var students in item.GeneralyStudent)
                    {
                        if (students.Id == studentNo)
                        {
                            item.GeneralyStudent.Remove(students);
                            Console.WriteLine("Telebe muveffeqiyyetle silindi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("daxil etmek istediyiniz telebeye uygun Id yoxdur");
                            break;
                        }
                    }
                }
                else
                {
                    a++;
                    if (a == Groups.Count)
                    {
                        a = 0;
                        Console.WriteLine("Daxil etdiyiniz qrup sistemde yoxdur");
                        break;
                    }

                }

            }
        }
   }
}
