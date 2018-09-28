using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace E2._1_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, opc = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Factorial F = new Factorial();

                    Console.Write("\n1 = for \n2 = Recursividad \nR= ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            int N = 1, n = 0;
                            Stopwatch timeEjecucion = Stopwatch.StartNew();

                            Console.Write("\nIngrese Numero entero mayor a 0: ");
                            n = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nEl factorial de {0} es: {1} \nTiempo de ejecucion: {2} ", n, F.For(n), timeEjecucion.Elapsed);
                            break;

                        case 2:
                            int num = 0;
                            Stopwatch TE = Stopwatch.StartNew();

                            Console.Write("\nIngrese Numero entero Mayor que 0: ");
                            num = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nEl Factorial de {0} numero es: {1}", num, F.Fact(num));


                            Console.WriteLine("\nTiempo de ejecucion: {0}", TE.Elapsed);
                            break;
                    }                    
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.Write("\nDesea volver a iniciar el programa? \n1 = Si \n2 = No \nR= ");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);
        }
    }


    class Factorial
    {
        public Factorial() { }

        public int Fact(int n)
        {
            if (n == 0)
                return 1;

            else
                return n * Fact(n - 1);
        }


        public int For (int x)
        {
            int N = 1;

            if (x == 0)
            {
                return 1;
            }

            else
            {
                for (int i = 1; i <= x; i++)
                {
                    N = N * i;
                }

                return N;
            }
        }
    }
}

