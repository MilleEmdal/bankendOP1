using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHandInBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer guy = new Customer();
            Customer otherguy = new Customer("Hanne",30, 2300, "Hund");

            Console.WriteLine(guy.ToString());
            Console.WriteLine(otherguy.ToString());

            Console.WriteLine(guy.CompareAges(guy,otherguy));
            Console.ReadKey();


        }
    }
}
