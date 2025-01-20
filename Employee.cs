using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{

    internal class EmployeeEqualityComparer : IEqualityComparer<Employee> , IComparable , IComparable<Employee>
    {
        public int CompareTo(object? obj)
        {
            if(other == null) return 1;
            return this.Salary.CompareTo(other.Salary);
          
            
            
            // if(this.Salary > other.Salary)
          //      else if (this.Salary < other.Salary)
          //      return -1;
        }
        #region Object Methods
        public override string ToString()
        {
            return $"ID= {this.ID} , Name = {this.Name} , Salary = {this.Salary} ");
        }

        public bool Equals(Employee? x, Employee? y)
        {
            if (other == null) return false;
            return this.ID.Equals(other.ID) && this.Name!.Equals(other.Name) && this.Salary.Equals(other.Salary);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    internal class Employee : IEquatable<Employee>

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        //  public static bool operator ==(Employee Left, Employee Right)
        //  {
        //
        //      return Left.Equals(Right);
        //      //return (Left.ID == Right.ID && Left.Name == Right.Name && Left.Salary == Right.Salary);
        //  }
        //  public static bool operator !=(Employee Left, Employee Right)
        //  {
        //      return (Left.ID != Right.ID && Left.Name != Right.Name && Left.Salary != Right.Salary);
        //  }

       // public override bool Equals(object? obj) // obj = new Employee()
       
            // 1. is operator
            ///  if (obj is Employee )
          /// {
          ///     return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;
          /// }
          /// return false;



            // 2. as operator
           /// Employee? other = obj as Employee; // no exceptions will be thrown
           /// if (other == null) return false;
           ///  return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;



            // Employee? other;
            ///  Employee? other; // unsafe Casting : Compiler Cant Enforce type safety
            ///  if (other == null) return false;
            ///  return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;

        
public bool Equals(Employee other)
        {
            if (other == null) return false;
            return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;
        }

    }


    }
