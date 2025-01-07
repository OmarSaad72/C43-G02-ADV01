using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Advanced_C_
{
    internal struct Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"ID = {ID} , Name = {Name} , Salary = {Salary}";
        }
        public static bool operator ==(Employee left, Employee right)
        {
            return (left.ID == right.ID) && (left.Name == right.Name) && (left.Salary == left.Salary);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return (left.ID != right.ID) || (left.Name != right.Name) || (left.Salary != left.Salary);
        }
    }
}
