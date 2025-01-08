using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : ICloneable,IComparable
    {
        //ican use copy constructor instread of  Iclonable
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,//string here is special case 
                Salary = this.Salary,
            };
        }

        public int CompareTo(object? obj)
        {
            Employee? other =(Employee?) obj;
            //if (other == null) return 1;
            //if (this.Salary > other.Salary) return 1;

            //else if (this.Salary < other.Salary) return -1;

            //return 0;
            return this.Salary.CompareTo(other?.Salary);
        }

        public override string ToString()
        {
            return $" id = {Id}, name = {Name}, Salary ={Salary}";
        }
    }
}
