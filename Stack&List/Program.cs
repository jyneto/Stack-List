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
            // Executing Stack_ListHandler by using RunProgram method
            //This method will handle all stack and list operations
            Stack_ListHandler stack_listHandler = new Stack_ListHandler();
            stack_listHandler.RunProgram();

        }

    }


}