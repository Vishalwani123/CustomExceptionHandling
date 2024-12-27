using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Handling
{
    internal class Lists1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
    internal class Class2
    {
        List<Lists1> l1 = new List<Lists1>();

        public void Add1()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the number of records");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the First Name : ");
                string firstname = Console.ReadLine();

                Console.WriteLine("Enter the Second Name : ");
                string secondname = Console.ReadLine();

                Console.WriteLine("Enter the Age : ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Department : ");
                string department = Console.ReadLine();



                l1.Add(new Lists1 { FirstName = firstname, LastName = secondname, Age = age, Department = department });

            }

        }
        public void Sol()
        {
            
            try
            {
                //var n1 = l1.Where(x => x.Age>=18);
                //Console.WriteLine(n1);
                //throw new CustExp1("Under Age.");

                Lists1 l4 = l1.FirstOrDefault(x => x.FirstName == "Vishal");




                if (l4 == null)
                {
                    throw new CustExp1("Name not Found");

                }
                else
                {
                    Console.WriteLine("Value of List are : ");
                    l1.ForEach(x => Console.WriteLine("Name : {0} {1}, Age : {2}, Department : {3}", x.FirstName, x.LastName, x.Age, x.Department));


                }
            }
            catch (CustExp1 e)
            {
                Console.WriteLine();
                Console.WriteLine("Exception Occurs ");

                Console.WriteLine($"Custom Exception : {e.ToString()}");
            }
            



        }
    }
}
