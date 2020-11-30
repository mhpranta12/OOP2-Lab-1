using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BankPrac
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string  id;

        public string  Id
        {
            get { return id; }
            set { id = value; }
        }

         private string  address;

        public string  Address
        {
            get { return address; }
            set { address = value; }
        }



        public void ShowInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);

            Console.WriteLine(address);

        }

    }
}
