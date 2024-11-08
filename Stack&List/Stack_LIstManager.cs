using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_List
{
    internal class Stack_ListHandler
    {
        public void RunProgram()
        {
            Console.WriteLine("--Part 1 Stack--- ");
            //Creating new objects to Employee class
            Employee employee1 = new Employee(01, "Joanne", "Female", 50000);
            Employee employee2 = new Employee(02, "Axel", "Male", 46000);
            Employee employee3 = new Employee(03, "Charlie", "Non-Binary", 5000);
            Employee employee4 = new Employee(04, "Bob", "Male", 50000);
            Employee employee5 = new Employee(05, "Adam", "Male", 49000);

            //Creating a stack to hold Employee objects
            Stack<Employee> employeeStack = new Stack<Employee>();


            //Pushing to add objects to stack
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);


            // Using a foreach loop to iterate and show employee information
            foreach (Employee employee in employeeStack)
            {
                DisplayEmployeeInfo(employee);
                DisplayObjectsInStack(employeeStack.Count);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\nUsing Pop method to retrieve");

          //Using Pop method to retrieve and display employee infromation until stack is empty
            while (employeeStack.Count > 0)
            {

                DisplayEmployeeInfo(employeeStack.Pop());
                DisplayObjectsInStack(employeeStack.Count);
            }

            //Pushing back objects to stack after Pop method removed them
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\nUsing Peek method to retrieve");

            //Using Peek method to retrieve and display the top object in the stack
            for (int i = 0; i < 2; i++)
            {
                //Peeking at the top object in stack and show info
                DisplayEmployeeInfo(employeeStack.Peek());
                //Shows information of objects left in stack
                DisplayObjectsInStack(employeeStack.Count);
            }

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("--Part 2 List--");
            Console.WriteLine("");
            
            //Creating a list to hold Employee objects
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            //Using Contain method as instructed
            //Checking if employee2 exist in the list 
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("Employee2 exist in the list");
            }
            else
            {
                Console.WriteLine("Employee2 doesn´t exist in the list");
            }
            Console.WriteLine();

            // Finding first male employee, using Find method
            Employee firstMaleObject = employeeList.Find((employee) => employee.Gender == "Male");
            //Printing object in new list with employee information
            DisplayEmployeeInfo(firstMaleObject); 
            Console.WriteLine();

            //Finding all make employees , using FindAll method
            List<Employee> maleList = employeeList.FindAll((employee) => employee.Gender == "Male");
            foreach (Employee maleEmployees in maleList)
            {
                DisplayEmployeeInfo(maleEmployees);
            }

        }
        public void DisplayEmployeeInfo(Employee employee)
        {
            Console.WriteLine($"ID: {employee.ID},Name: {employee.Name} ,Gender: {employee.Gender},Salary: {employee.Salary}");

        }

        public void DisplayObjectsInStack(int leftInStack)
        {
            Console.WriteLine($"Objects left in the stack {leftInStack}");
        }

        
    }
}
