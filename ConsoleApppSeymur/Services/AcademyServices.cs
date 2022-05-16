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
            Console.WriteLine(group+ "\n Group created and group limit - " + group.limit);
            
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
                Console.WriteLine("There is no group to be displayed in the database");
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
                        Console.WriteLine("The group you want to change does not exist in the system");
                        break;
                    }
                    
                    
                }
                if (group.No.ToLower().Trim()==newGroupNo.ToLower().Trim())
                {
                    Console.WriteLine("The group you want to include exsist in the system");
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
                        Console.WriteLine("The group has changed successfully");
                    }
                }

            }
        }
        public void ShowStudentListInGroup(string no) {
            if (Groups.Count == 0)
            {
                Console.WriteLine("There is no group or student in the system");

            }
            foreach (Group item in Groups )
            {
                                
                    if (item.No.ToLower().Trim() == no.ToLower().Trim())
                    {
                        if (item.GeneralyStudent.Count == 0)
                        {
                            Console.WriteLine("There is no student in the group you entered");
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
                        Console.WriteLine("There is no group you entered");
                    }
                    
                }
                
                    

                
            }

        }
        public void ShowAllStudents() {
            if (Groups.Count == 0)
            {
                Console.WriteLine("There is no group or student in the system");

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
                        Console.WriteLine("There is no student in the system");
                    }
                }

            }
        }
        public void CreateStudent( string fullname, string groupno, int entrypoint) {
            Student student;
            if (Groups.Count == 0)
            {
                Console.WriteLine("There is no group in the system and  students not  included");
                
            }
            foreach (var item in Groups)
            {

                if (item.No.ToLower().Trim() == groupno.ToLower().Trim())
                {
                    if (item.GeneralyStudent.Count <= item.limit)
                    {
                        item.GeneralyStudent.Add(student = new Student(fullname, groupno, entrypoint));
                        Console.WriteLine("Student was added to the group you entered");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Grup is full and student was not added to the group");
                        break;
                    }
                }
                else
                {
                    a++;
                    if (a == Groups.Count)
                    {
                        a = 0;
                        Console.WriteLine("The group you entered is not in the system");
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
                    Console.WriteLine("There is no group or student in the system");
                }
                if (item.No.ToLower().Trim() == groupNo.ToLower().Trim())
                {
                    if (item.GeneralyStudent.Count==0)
                    {
                        Console.WriteLine("The group is empty and there are no students to delete");
                    }
                    foreach (var students in item.GeneralyStudent)
                    {
                        if (students.Id == studentNo)
                        {
                            item.GeneralyStudent.Remove(students);
                            Console.WriteLine("Student was successfully deleted");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("There is no Id suitable for the student you want to delete");
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
                        Console.WriteLine("The included group does not exist in the system");
                        break;
                    }

                }

            }
        }
   }
}
