using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl.Services
{
    internal class Validation
    {
        public static void PrintErrorMessage(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }
    }
}
