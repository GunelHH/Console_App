using System;
using System.Collections.Generic;
using My_Console_Application.Enums;
using My_Console_Application.Interface;
using My_Console_Application.Models;

namespace My_Console_Application.Services
{
    class TeachingServices : ITeachingServices
    {
        private List<Group> _groups= new List<Group>();

        public List<Group> Groups => _groups;

        public string CreateGroup(string  no,int limit, Categories category)
        {
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i] <= 0)
                {
                    Console.WriteLine("Please choose valid Group no");
                }
            } 
            
  
            Group group = new Group(no,limit,category);

            _groups.Add(group);
            return group.No;
        }

        public void CreateStudent(string fullname,string groupno)
        {
           
        }

        public void ListOfAllStudents()
        {
            throw new NotImplementedException();
        }

        public void ListOfGroup()
        {
            throw new NotImplementedException();
        }

        public void ListofStudentsInGroup()
        {
            throw new NotImplementedException();
        }

        public void EditGroups()
        {
            throw new NotImplementedException();
        }
    }
}
