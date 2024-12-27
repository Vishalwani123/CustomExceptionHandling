using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zero Not Allowed 
            //Class1 c1 = new Class1();
            //Console.WriteLine("Enter the number to get SquareRoot of it. ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //c1.Sqrt1(n1);

            // Name Not Found Exception
            Class2 c2 = new Class2();
            c2.Add1();
            c2.Sol();


        }
    }
}
