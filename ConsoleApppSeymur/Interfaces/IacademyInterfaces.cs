using ConsoleApppSeymur.Enums;
using ConsoleApppSeymur.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApppSeymur.Iacademyservices
{
    interface IacademyInterfaces
    {
        public List<Group> Groups { get; }
        public void CreateGroup(bool online, Categories category);
        public void ShowGroupList();
        public void EditGroup(string oldGroupNo, string newGroupNo);
        public void ShowStudentListInGroup(string no);
        public void ShowAllStudents();
        public void CreateStudent(string fullname, string groupno, int entrypoint);
        public void DeleteStudent(string groupNo, int studentNo);


    }
}
