using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Advanced_C_
{
    internal struct Employee : IComparable
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"ID = {ID} , Name = {Name} , Salary = {Salary}";
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee? employee = (Employee?)obj;
        //    return (ID == employee?.ID) && (Name == employee?.Name) && (Salary == employee?.Salary);
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(ID, Name, Salary);
        //    //return ID.GetHashCode() + Salary.GetHashCode() + Name?.GetHashCode()??0;
        //}
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Equals(right);
            //return (left.ID == right.ID) && (left.Name == right.Name) && (left.Salary == left.Salary);

        }
        public static bool operator !=(Employee left, Employee right)
        {
            return !left.Equals(right);
            //return (left.ID != right.ID) || (left.Name != right.Name) || (left.Salary != left.Salary);
        }
        public int CompareTo(object? obj)
        {
            //Employee? employee = (Employee?)obj;
            //if (obj is Employee employee)
            //{
            //    return this.Salary.CompareTo(employee?.Salary);
            //}
            //return 1;
            Employee? employee = obj as Employee;
            return this.Salary.CompareTo(employee?.Salary);
        }
    }
}
