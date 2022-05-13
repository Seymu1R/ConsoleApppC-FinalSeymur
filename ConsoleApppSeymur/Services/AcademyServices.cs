using ConsoleApppSeymur.Enums;
using System;
using ConsoleApppSeymur.Models;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApppSeymur.Services
{
  class AcademyServices {

        public  List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public  void CreateGroup(bool online, Categories category) {
            Group group = new Group (online, category);
            _groups.Add(group);
            
        }
        public  void ShowGroupList() {
            if (Groups.Count > 0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }

        }
        public void EditGroup(string oldNo, string newNo) {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() ==oldNo.ToLower().Trim())
                {

                }
                
            }
        }
   }
}
