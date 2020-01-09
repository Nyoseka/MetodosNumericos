using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussJordan
{
    class Program
    {
        static void Main(string[] args)
        {
            double termino;
            double[,] matriz = new double[3, 4];
            double[] resultado = new double[3];
            Console.WriteLine("MÉTODO DE GAUSS-JORDAN");
            Console.Write("Ingrese valores a la matriz" + '\n');
            for (int c = 0; c <= 2; c++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.Write("Valor: ");
                    termino = double.Parse(Console.ReadLine());
                    matriz[c, i] = termino;
                }
            }
            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("SOLUCIÓN" + '\n');
            ImprimirMatriz();
            Console.WriteLine('\n');
            if (GaussJordan(matriz, resultado) == true)
            {
                ImprimirResultado(resultado);
            }
            else
            {
                Console.WriteLine("No es un sistema de ecuaciones lineales");
            }
            Console.WriteLine('\n');
            Console.Write("Ingrese cualquier tecla para continuar");
            Console.ReadKey();

            void ImprimirMatriz()
            {
                for (int c = 0; c <= 2; c++)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.Write(matriz[c, i]+", ");
                    }
                }
            }
            void ImprimirResultado (double[] r)
            {
                Console.WriteLine("Solucion por Eliminacion Gaussiana\n");
                for (int i = 0; i <= r.GetUpperBound(0); i++)
                {
                    Console.Write(string.Format("X({0}) = {1} \n", i + 1, r[i]));
                }
                Console.WriteLine("\n");
            }

            bool GaussJordan(double[,] a, double[] r)
        {
            double t, s;
            int i, l, j, k, m, n;

            try
            {
                n = r.Length - 1;
                m = n + 1;
                for (l = 0; l <= n - 1; l++)
                {
                    j = l;
                    for (k = l + 1; k <= n; k++)
                    {
                        if (!(Math.Abs(a[j, l]) >= Math.Abs(a[k, l]))) j = k;
                    }
                    if (!(j == l))
                    {
                        for (i = 0; i <= m; i++)
                        {
                            t = a[l, i];
                            a[l, i] = a[j, i];
                            a[j, i] = t;
                        }
                    }
                    for (j = l + 1; j <= n; j++)
                    {
                        t = (a[j, l] / a[l, l]);
                        for (i = 0; i <= m; i++) a[j, i] -= t * a[l, i];
                    }
                }
                r[n] = a[n, m] / a[n, n];
                for (i = 0; i <= n - 1; i++)
                {
                    j = n - i - 1;
                    s = 0;
                    for (l = 0; l <= i; l++)
                    {
                        k = j + l + 1;
                        s += a[j, k] * r[k];
                    }
                    r[j] = ((a[j, m] - s) / a[j, j]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }
}