using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Task1
{
    class Department
    {
        string Name;
        string Id;
        ArrayList faculty;

        public Department()
        {
            faculty = new ArrayList();

        }
        public Department(string name,string id)
        {
            Name = name;
            Id = id;
        }
        public void AddFaculty (params Faculty[] faculty)
        {
            foreach (Faculty f in faculty)
            {
                this.faculty.Add(f);
               
            }
        }
    }
}
