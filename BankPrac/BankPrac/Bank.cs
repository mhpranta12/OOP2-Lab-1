using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPrac
{
    class Bank
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private Employee[] employee;
        private int employeecount;

        public int EmployeeCount
        {
            get { return employeecount; }
            set { employeecount = value; }
        }
        private Customer[] customer;
        private int customercount;

        public int Customer
        {
            get { return customercount; }
            set { customercount = value; }
        }
        public Bank()
        {
            employee = new Employee[100];
            customer = new Customer[100];
            customercount = 0;
            employeecount = 0;
        }
        public Bank(String name)
        {
            employee = new Employee[100];
            customer = new Customer[100];
            customercount = 0;
            employeecount = 0;
        }
        public void AddEmployee(Employee emp)
        {
            if (employeecount < 100)
            {
                employee[employeecount++] = emp;
            }
            else
            {
                Console.WriteLine("Not enough space to add employee");
            }
        }
        public void ShowEmployee()
        {
            for (int i = 0; i < employeecount; i++)
            {
                employee[i].ShowInfo();
            }
        }
        public Employee SearchEmployee(String id)
        {
            Employee e = null;
            for (int i = 0; i < employeecount; i++)
            {
                if (id.Equals(employee[i]))
                {
                    e = employee[i];
                }
                break;
            }
            return e;
        }
        public void AddCustomer(Customer cust)
        {
            if (customercount < 100)
            {
                customer[customercount++] = cust;
            }
            else
            {
                Console.WriteLine("Not enough space to add customer");
            }
        }
        public Customer SearchCustomer(String id)
        {
            Customer e = null;
            for (int i = 0; i < customercount; i++)
            {
                if (id.Equals(customer[i]))
                {
                    e = customer[i];
                }
                break;
            }
            return e;
        }
        
    }
}
