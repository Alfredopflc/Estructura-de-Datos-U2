using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Fibonacci
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
                    Fiboracci F = new Fiboracci();

                    Console.Write("\n1 = for \n2 = Recursividad \nR= ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            int  n = 0;
                            
                            Console.Write("\nIngrese Numero de la sucesion: ");
                            n = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nLa secuencia es: ");
                            F.FibFor(n);
                            F.Time();
                            
                            break;

                        case 2:
                            int num = 0, nu = 0;

                            Console.Write("\nIngrese Numero de la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nLa secuencia es: ");

                            while (nu < num)
                            {
                                Console.WriteLine(F.FibRec(nu));
                                nu++;
                            }

                            F.Time();
                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.Write("\nDesea volver a iniciar el programa? \n1 = Si \n2 = No \nR= ");
                op = int.Parse(Console.ReadLine());

            } while (op == 1);
        }
    }


    //class Fiboracci
    //{
    //    public Fiboracci() { }

    //    public int FibRec(int n)
    //    {
    //        if (n < 2)
    //            return n;

    //        else
    //            return FibRec(n - 1) + FibRec(n - 2);
    //    }


    //    public void FibWhile(int x)
    //    {
    //        int resultado = 0, val = 1, temp = 0;


    //        if (x < 2)
    //            Console.WriteLine(x);

    //        else
    //        {
    //            Console.WriteLine("0");
    //            for (int i = 0; i < x; i++)
    //            {
    //                Console.WriteLine(val);
    //                resultado = val + temp;
    //                temp = val;
    //                val = resultado;
    //            }
    //        }
    //    }
    //}
}
