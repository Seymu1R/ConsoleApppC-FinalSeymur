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
        

        public List<Group> Groups => _groups;

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
                Console.WriteLine("Qruplar bosdur");
            }

        }
        public void EditGroup(string oldGroupNo, string newGroupNo) {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim()==oldGroupNo.ToLower().Trim())
                {
                    foreach (var groups in Groups)
                    {
                        if (groups.No.ToLower().Trim() != newGroupNo.ToLower().Trim())
                        {
                            group.No = newGroupNo;
                            Console.WriteLine("Qrupun adi deyisdirildi");
                            break;
                        }
                        else if(groups.No.ToLower().Trim() == newGroupNo.ToLower().Trim())
                        {                            
                            Console.WriteLine("daxil etmek istediyiniz qrup artiq sitemde var");
                            break;
                        }
                        

                    }

                    break;
                    
                }
                
                
            }
        }
        public void ShowStudentListInGroup(string no) {
            foreach (Group item in Groups )
            {
                if (item.No.ToLower().Trim() == no) 
                {
                    if (item.GeneralyStudent.Count==0)
                    {
                        Console.WriteLine("Qrupda telebe yoxdu");
                        break;

                    }
                    foreach (Student students in item.GeneralyStudent)
                    {                     
                                                
                       Console.WriteLine(students);                       
                        
                    }
                }
                else
                {
                    Console.WriteLine("bele adda qrup yoxdur");
                    break;
                }
            }

        }
        public void ShowAllStudents() {
            foreach (Group groups in Groups)
            {
                foreach (Student students in groups.GeneralyStudent)
                {
                    Console.WriteLine(students);

                }

            }
        }
        public void CreateStudent( string fullname, string groupno, int entrypoint) {
            Student student; 
            foreach (var item in Groups)
            {
                if (item.No.ToLower().Trim() != groupno)
                {
                    Console.WriteLine("daxil etdiyiniz adda qrup yoxdur");

                }
                if (item.GeneralyStudent.Count >= item.limit)
                {
                    Console.WriteLine("Grup is full");
                    return; 
                }
               
                if (item.No.ToLower().Trim()==groupno)
                {
                    item.GeneralyStudent.Add(student = new Student(fullname, groupno, entrypoint));
                    
                }
                
            }
                      
            
        }
        public void DeleteStudent(string groupNo, int studentNo) {
            foreach (var item in Groups)
            {
                if (item.No.ToLower().Trim() == groupNo.ToLower().Trim())
                {
                    foreach (var students in item.GeneralyStudent)
                    {
                        if (students.Id==studentNo)
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
                
            }
        
        }
   }
}
