namespace C__Adv_Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SWAP Example

            ///  int A = 3, B = 5; // Boxing
            ///  Console.WriteLine($"A = {A}");
            ///  Console.WriteLine($"B = {B}");
            ///  Helper.SWAP<int>(ref A,ref B );
            ///  Console.WriteLine($"A={A}");
            ///  Console.WriteLine($"B={B}");


            /// double K = 3.3, L = 4.4;
            /// Console.WriteLine($"K = {K}");
            /// Console.WriteLine($"L = {L}");
            ///  Helper.SWAP(ref K,ref L );
            ///  Console.WriteLine($"k = {K}");
            ///  Console.WriteLine($"L={L}");


            /// Point p01 = new Point(10, 20);
            /// Point p02 = new Point(60, 50);
            /// Console.WriteLine($"P01 = {p01}");
            /// Console.WriteLine($"P02 = {p02}");
            ///
            /// Helper.SWAP(ref p01, ref p02);
            ///
            /// Console.WriteLine($"P01 = {p01}");
            /// Console.WriteLine($"P02 = {p02}");  


            #endregion

            #region LiearSearch Example


            ///  Employee[] employees =
            ///      {
            ///      new Employee() { ID = 10 , Name = "Ahmed" , Salary = 8_000},
            ///       new Employee() { ID = 20 , Name = "Omar" , Salary = 7_000},
            ///        new Employee() { ID = 30 , Name = "Bassem" , Salary = 4_000},
            ///         new Employee() { ID = 40 , Name = "hamda" , Salary = 5_000},
            ///         };
            ///  int index = Helper<Employee>.LinarSearch(employees, new Employee() { ID = 30, Name = "Bassem", Salary = 4_000 , new EmployeeEqualityComparer() });


            //    int index = Helper<Employee>.LinarSearch(employees , new Employee() {  ID = 40 , Name = "Omnia"} , delegate(Employee X ,Employee Y) { return X == Y; });
            //
            //    index = Helper<Employee>.LinarSearch(employees, new Employee() { ID = 40, Name = "Omnia" }, delegate ( X,  Y) => X.Name == Y.Name);


            ///
            ///   Console.WriteLine($" Index ={retsult}");
            ///   
            //    Employee E01 = new Employee() { ID = 10, Name = "Ahmed", Salary = 5_000 };
            //    Employee E02 = new Employee() { ID = 20, Name = "Omnia", Salary = 3_000 };
            //
            //
            //    if(E01.Equals(E02))
            //   // if (E01 == E02)
            //
            //        Console.WriteLine("EQUALS");
            //    else
            //        Console.WriteLine($"!EQUALS");
            //         


            #endregion

            #region BubbleSort

        //    Employee[] employees =
           //  {
           // new Employee() { ID = 10, Name = "Ahmed", Salary = 8_000 },
           // new Employee() { ID = 20, Name = "Omar", Salary = 7_000 },
           // new Employee() { ID = 30, Name = "Bassem", Salary = 4_000 },
           // new Employee() { ID = 40, Name = "hamda", Salary = 5_000 },
           //  };
        //
        //   Helper<Employee>.BubbleSort(employees);

        // Helper<Employee>.BubbleSort(employees, new EmployeeComparerByName () )

        //   foreach (var employee in employees)
        //   
        //       Console.WriteLine(employee);
        //   

            #endregion

        }
    }
}
