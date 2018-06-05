using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filosofos.ConMonitores
{
    using System;
    using System.Threading;

    public class Monitores
    {
        public static void Main()
        {
            var fechaComienzo = DateTime.Now;
            Random rnd = new Random();
            Tenedor tenedor = new Tenedor();
            new Filosofo(0, "Aristotle", rnd.Next(0, 300), rnd.Next(0, 500), tenedor);
            new Filosofo(1, "Kant", rnd.Next(0, 200), rnd.Next(0, 100), tenedor);
            new Filosofo(2, "Spinoza", rnd.Next(0, 500), rnd.Next(0, 200), tenedor);
            new Filosofo(3, "Marx", rnd.Next(0, 100), rnd.Next(0, 400), tenedor);
            new Filosofo(4, "Russel", rnd.Next(0, 400), rnd.Next(0, 300), tenedor);
            Console.ReadLine();

        }
    }
}
