using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP2_VenegasMedinaJoseAlfredo
{
    class Recursividad
    {
        public Recursividad() { }

        public double[] Valores(double[] Su, int cont)
        {
            if (cont <= Su.Length - 1)
            {
                Console.Write("Ingresa numero: ");
                Su[cont] = double.Parse(Console.ReadLine());
                return Valores(Su, cont + 1);
            }            
            return Su;
        }

        public void Imprimir(double[] Su, int cont)
        {
            if (cont < Su.Length)
            {
                Console.Write(Su[cont] + "  ");
                Imprimir(Su, cont + 1);
            }
        }

        public void Imprimir2(double[] Su, int cont)
        {
            if (cont > 0)
            {
                Console.Write(Su[cont-1] + "  ");
                Imprimir2(Su, cont - 1);
            }
        }
    }
}
