using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 2019;

            // Boxing means converting the value type into object type 
            object o = val;

           

            Console.WriteLine("Value type of val is {0}", val);
            Console.WriteLine("Object type of val is {0}", o);

            int j = (int)o; // unboxing means changing object type into value type

            Console.WriteLine("Object type into val type is{0}", j);
        }
    }
}
