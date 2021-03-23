using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenA
{
    public class Management
    {
        private const int MAXRANG = 10;

        public static bool MagPromoveren(WerkNemer toCheck)
        {
            return (toCheck.Rang < MAXRANG);
        }

    }

    public class WerkNemer
    {
        public int Rang { get; set; }

        public bool IsPromoveerbaar()
        {
            return Management.MagPromoveren(this);
        }
    }
}
