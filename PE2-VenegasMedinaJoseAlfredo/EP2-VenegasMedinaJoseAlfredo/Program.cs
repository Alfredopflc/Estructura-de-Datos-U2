using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0, num = 0, opc = 0;
            Recursividad R = new Recursividad();

            do
            {
                try
                {
                    Console.Clear();

                    Console.Write("Que desea hacer? \n1 = Encontrar Valor Minimo de una sucesion \n2 = Encontrar Valor Maximo de una sucesion \n3 = Invertir Sucesion \nR= ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Write("\nMINIMO:  \nIngrese cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] SucesionMin = new double[num];

                            double[] SucesionMin2 = R.Valores(SucesionMin, 0);

                            Console.WriteLine("\nLa sucesion es: ");
                            R.Imprimir(SucesionMin2, 0);

                            Console.WriteLine("\n\nEl valor Menor es: {0}", SucesionMin2.Min());

                            break;

                        case 2:
                            Console.Write("\nMAXIMO   \nIngrese cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] SucesionMax = new double[num];

                            double[] SucesionMax2 = R.Valores(SucesionMax, 0);

                            Console.WriteLine("\nLa sucesion es: ");
                            R.Imprimir(SucesionMax2, 0);

                            Console.WriteLine("\n\nEl valor Mayor es: {0}", SucesionMax2.Max());

                            break;

                        case 3:
                            Console.Write("\nINVERSO   \nIngrese cuantos valores desea la sucesion: ");
                            num = int.Parse(Console.ReadLine());

                            double[] SucesionIn = new double[num];

                            double[] SucesionIn2 = R.Valores(SucesionIn, 0);

                            Console.WriteLine("\nLa sucesion es: ");
                            R.Imprimir(SucesionIn2, 0);

                            Console.WriteLine("\nLa sucesion Inversa es: ");
                            R.Imprimir2(SucesionIn2, SucesionIn2.Length);

                            break;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.Write("\nDesea volver a Iniciar? \n1 = Si \n2 = No \nR = ");
                opc = int.Parse(Console.ReadLine());

            } while (opc == 1);
        }
    }
}
