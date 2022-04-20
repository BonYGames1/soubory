using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace soubory
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader cteni = new StreamReader("input.txt");


            string radek;

            while ((radek = cteni.ReadLine()) != null)
            {
                Console.WriteLine(radek);
            }

            cteni.Close();

            StreamWriter zapis = new StreamWriter("output.txt",true);

            zapis.WriteLine("amogus neventoval");

            zapis.Close();

            Console.ReadKey();
        }
    }
}
