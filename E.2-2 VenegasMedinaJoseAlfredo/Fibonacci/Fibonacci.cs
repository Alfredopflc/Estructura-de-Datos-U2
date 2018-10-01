using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibonacci
{
    class Fiboracci
    {
        public Fiboracci() { }

        public int FibRec(int n)
        {         
            if (n < 2)
                return n;

            else
                return FibRec(n - 1) + FibRec(n - 2);           
        }

        public void FibFor(int x)
        {
            int resultado = 0, val = 1, temp = 0;


            if (x < 2)
                Console.WriteLine(x);

            else
            {
                Console.WriteLine("0");
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(val);
                    resultado = val + temp;
                    temp = val;
                    val = resultado;
                }
            }
        }
        public void Time()
        {
            Stopwatch timeEjecucion = Stopwatch.StartNew();
            Console.WriteLine("\nTiempo de Ejecusion: {0} ", timeEjecucion.Elapsed);
        }
    }
}
