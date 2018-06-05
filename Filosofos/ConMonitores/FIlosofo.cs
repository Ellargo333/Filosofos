using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filosofos.ConMonitores
{
    class Filosofo
    {
        private int _numero;
        private string _nombre;
        private int _tiempoPensar;
        private int _tiempoComer;
        private int _tenedorIzq, _tenedorDer;
        private Tenedor _tenedor;
        public Filosofo(int n, string nombre, int tiempoPensar, int tiempoComer, Tenedor tenedor)
        {
            _numero = n;
            _nombre = nombre;
            _tiempoPensar = tiempoPensar;
            _tiempoComer = tiempoComer;
            _tenedor = tenedor;
            _tenedorIzq = n;
            _tenedorDer = (_tenedorIzq + 1) % 5;
            new Thread(new ThreadStart(Run)).Start();
        }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(_numero + " - " + _nombre + " esta pensando...");
                    Thread.Sleep(_tiempoPensar);
                    Console.WriteLine(_numero + " - " + _nombre + " tiene hambre...");
                    _tenedor.Pedir(_tenedorIzq, _tenedorDer);
                    Console.WriteLine(_numero + " - " + _nombre + " está comiendo con tenedores - " + _tenedorIzq + " - " + _tenedorDer);
                    Thread.Sleep(_tiempoComer);
                    _tenedor.Devolver(_tenedorIzq, _tenedorDer);
                    Console.WriteLine(_numero + " - " + _nombre + " se retira del comedor...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(_numero + " - " + _nombre + " se va a dormir...");
        }

    }
}
