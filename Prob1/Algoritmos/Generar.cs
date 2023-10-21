using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Algoritmos
{
    internal class Generar
    {
        public List<List<double>> Montecarlo_Exponencial(double a, double b, double n)
        {
            List<List<double>> tabla = new List<List<double>>();
            Random random = new Random();
            double Tam_base = (b - a) / n;

            for (int i=0; i < n; i++)
            {
                List<double> fila = new List<double>();
                double X_aleatorio = 0;
                double potencia = 0;
                double altura = 0;
                double area = 0;
                int aa = Convert.ToInt32(a);
                int bb = Convert.ToInt32(b);

                X_aleatorio = random.Next(aa,bb+1);
                potencia = b * X_aleatorio;
                altura = Math.Pow(a, potencia);
                area = altura * Tam_base;

                fila.Add(X_aleatorio);
                fila.Add(altura);
                fila.Add(area);

                tabla.Add(fila);
            }
            return tabla;
        }

    }
}
