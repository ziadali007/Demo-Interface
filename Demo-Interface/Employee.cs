using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{

    internal class EmployeeComparerSalary(): IComparer
    {
        public int Compare(object x, object y)
        {
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
            if (e1.salary > e2.salary)
            {
                return 1;
            }
            else if (e1.salary < e2.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Employee : IComparable, ICloneable
    {
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public double salary { get; set; }

        public Employee()
        {
           
        }

        public Employee(Employee employee)
        {
            id=employee.id;
            name = employee.name;
            age = employee.age;
            salary = employee.salary;
        }
        public object Clone()
        {
            return new Employee (this);
        }

        public int CompareTo(object? obj)
        {
            Employee e=(Employee)obj;

            if(this.age> e.age)
            {
                return 1;
            }
            else if (this.age < e.age)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            //return this.age.CompareTo(e.age);
        }

        override public string ToString()
        {
            return "ID: " + id + " Name: " + name + " Age: " + age + " Salary: " + salary;
        }
    }
}
