using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenA
{
    class Program
    {
        static void Main(string[] args)
        {
            WerkNemer gawein = new WerkNemer() { Rang = 10 };

            if(gawein.IsPromoveerbaar())
            {
                Console.WriteLine("Joepie Gawein mag promoveren!");
            }
            else
            {
                Console.WriteLine("Gawein mag niet promoveren.");
            }

            Console.ReadLine();

            Computer computer = new Computer();
            computer.HardeSchijf.Formateer();
            computer.GeefSchijven();
            //computer.UsbPoorten.Add(new USB("2.0"));
            //computer.UsbPoorten.Add(new USB("2.1"));
            //computer.UsbPoorten.Add(new USB("3.0"));
            //computer.UsbPoorten.Add(new USB("3.1"));

            computer.InsertUsbPoort(new USB("2.0"));
            computer.InsertUsbPoort(new USB("2.1"));
            computer.InsertUsbPoort(new USB("3.0"));
            computer.InsertUsbPoort(new USB("3.1"));

            computer.GeefPoorten();
            Console.ReadLine();
        }
    }
}
