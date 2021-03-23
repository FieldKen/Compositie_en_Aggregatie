using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenA
{
    class Computer
    {

        private HardeSchijf hardeSchijf = new HardeSchijf();

        public HardeSchijf HardeSchijf
        {
            get { return hardeSchijf; }
            set { hardeSchijf = value; }
        }

        public RAM[] RamGeheugens = new RAM[4];

        private List<USB> usbPoorten { get; } = new List<USB>();

        public Computer()
        {
            RamGeheugens[0] = new RAM() { GeheugenInGig = 8 };
            RamGeheugens[1] = new RAM(8);
            RamGeheugens[2] = new RAM() { GeheugenInGig = 16 };
            RamGeheugens[3] = new RAM(16);
        }

        public void GeefSchijven()
        {
            foreach (var item in RamGeheugens)
            {
                Console.WriteLine($"Geheugen: {item.GeheugenInGig}");
            }
        }

        public void GeefPoorten()
        {
            foreach (var item in usbPoorten)
            {
                Console.WriteLine($"Poort type: {item.Type}");
            }
        }

        public void InsertUsbPoort(USB usb)
        {
            usbPoorten.Add(usb);
        }
    }
}
