using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string input = "shivam";

        try
        {
            int result = int.Parse(input);
            Console.WriteLine("Parsed value: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Program continues...");
    }
}
