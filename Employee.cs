using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal struct Employee

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

        public override bool Equals(object? obj) // obj = new Employee()
        {

            // 1. is operator
            ///  if (obj is Employee )
            ///  {
            ///      other = (Employee?)obj;
            ///  }
            ///  

            // 2. as operator
           /// Employee? other = obj as Employee; // no exceptions will be thrown
           /// if (other == null) return false;
           ///  return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;



            // Employee? other;
            ///  Employee? other; // unsafe Casting : Compiler Cant Enforce type safety
            ///  if (other == null) return false;
            ///  return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }


    }
