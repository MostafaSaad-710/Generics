using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class EmployeeIComparableSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    class EmployeeEqualityComparerName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    internal class Employee : IComparable<Employee>, IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //Overloading == becouse struct has't ==
        public static bool operator ==(Employee l , Employee r)
        {
            return l.Id == r.Id && l.Name == r.Name && l.Age == r.Age && l.Salary == r.Salary; 
        }

        public static bool operator !=(Employee l, Employee r)
        {
            return l.Id != r.Id || l.Name != r.Name || l.Age != r.Age || l.Salary != r.Salary;
        }

        //override on Equal becouse make class Compare data no refranse
        //public override bool Equals(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return this == E;
        //}

        public bool Equals(Employee? other)
        {
            if (other is not null) return false;
            return this == other;
        }

        //public int CompareTo(object? obj)
        //{
        //    Employee E = (Employee)obj;
        //    return Age.CompareTo(E.Age);
        //}

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;
            return Age.CompareTo(other.Age);
        }


        public override string ToString()
        {
            return $"Id: {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}";
        }

        
    }
}
