using System;

namespace ClassObject
{

    class Employee
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work: " + work);

        }
    }

    class EmployeeDrive
    {
        static void Main(string[] args)
        {

             
            Employee e1 = new Employee();

            Console.WriteLine("Employee 1");

            
            e1.name = "Gloria";
            Console.WriteLine("Name: " + e1.name);


            e1.work("Coding");

            Console.ReadLine();

        }
    }
}