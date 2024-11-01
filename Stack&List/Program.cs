// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StackManager stackManager = new StackManager();
            stackManager.Run();
            //using a while loop

            //int elementsLeft = employeeStack.Count;
            //Console.WriteLine("Items left: " + elementsLeft);
            //while (employeeStack.Count > 0)
            //{
            //    Employee employee = employeeStack.Pop();
            //    employee.DisplayInfo();
            //    Console.WriteLine("Items left: " + elementsLeft);
            //}

            //Console.WriteLine("");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("");


            // Ett sätt att lägga tillbaka alla object igen genom att använda Push() metoden.
            /*
            employeeStack.Push(new Employee(01, "Joanne", "Female", 50000));
            employeeStack.Push(new Employee(02, "Axel", "Male", 46000));
            employeeStack.Push(new Employee(03, "Charlie", "Non-Binary", 5000));
            employeeStack.Push(new Employee(04, "Bob", "Male", 50000));
            employeeStack.Push(new Employee(05, "Eve", "Male", 49000));
            */

            //Det är dock 


            //int toppEmployee = employeeStack.Count;
            //if (employeeStack.Count > 0)
            //{
            //    Employee topEmployee = employeeStack.Pop();
            //    topEmployee.DisplayInfo();
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty");
            //}

        }

    }


}