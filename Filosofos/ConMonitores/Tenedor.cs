using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filosofos.ConMonitores
{
    class Tenedor
    {
        bool[] tenedores = new bool[5];
        public void Pedir(int izq, int der)
        {
            lock (this)
            {
                while (tenedores[izq] || tenedores[der]) Monitor.Wait(this);

                tenedores[izq] = true;
                tenedores[der] = true;
            }
        }
        public void Devolver(int izq, int der)
        {
            lock (this)
            {
                tenedores[izq] = false; tenedores[der] = false;
                Monitor.PulseAll(this);
            }
        }
    }
}
