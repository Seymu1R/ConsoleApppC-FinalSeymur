using ConsoleApppSeymur.Enums;
using System;
using ConsoleApppSeymur.Models;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApppSeymur.Services
{
  class AcademyServices {

        List<Group> _groups = new List<Group>();
        

        public List<Group> Groups => _groups;

        public  void CreateGroup(bool online, Categories category) {
            Group group = new Group (online, category);
            Groups.Add(group);
            
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
                if (group.No.ToLower().Trim()==newGroupNo.ToLower().Trim())
                {
                    Console.WriteLine("deyeismek istediyiniz qrup sitemde var");
                    return;
                }
                if (group.No.ToLower().Trim() ==oldGroupNo.ToLower().Trim())
                {
                    group.No = newGroupNo;
                }
                
            }
        }
        public void ShowStudentListInGroup(string no) {
            foreach (Group item in Groups )
            {
                if (item.No.ToLower().Trim()==no)
                {
                    foreach (Student students in item.GeneralyStudent)
                    {
                        Console.WriteLine(students);
                    }
                }
                else
                {
                    Console.WriteLine("bele adda qrup yoxdur");
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

            Student student = new Student(fullname,groupno,entrypoint);
            foreach (var item in Groups)
            {
                if (item.GeneralyStudent.Capacity > item.limit)
                {
                    Console.WriteLine("Grup is full");
                    return; 
                }
               
                if (item.No.ToLower().Trim()==groupno)
                {
                    item.GeneralyStudent.Add(student);
                    
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
                        }
                    }
                }
                
            }
        
        }
   }
}
