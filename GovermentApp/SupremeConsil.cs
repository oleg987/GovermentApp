using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovermentApp
{
    class SupremeConsil
    {
        private static SupremeConsil consil;
        
        private SupremeConsil() { }

        public static SupremeConsil GetConsil()
        {
            if (consil == null)
            {
                consil = new SupremeConsil();
            }
            return consil;
        }

        public bool Vote()
        {
            Random r = new Random();
            int votes = r.Next(290, 401);
            Console.WriteLine($"Results: {votes} supported, {400 - votes} in opposite");
            return votes >= 320;
        }
    }
}
