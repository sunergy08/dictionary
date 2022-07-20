using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> name = new Dictionary<string, int>();
            name.Add("Golden", 1);
            name.Add("Patricia", 2);
            name.Add("Damilola", 1);
            name.Add("Effiong", 2);
            name.Add("Ajayi", 1);

            // Dictionary elements
            Console.WriteLine("Dictionary elements: " + name.Count);
          
        }
    }
}
