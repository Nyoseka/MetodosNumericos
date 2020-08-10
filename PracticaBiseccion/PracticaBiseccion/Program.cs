using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBiseccion
{
    class Program
    {

        static void Main(string[] args)
        {
            double xi;
            double xu;
            double xr;
            int i;
            Console.WriteLine("METODO DE BISECCION"+'\n');
            Console.Write("Ingrese un valor para xi: ");
            xi = double.Parse(Console.ReadLine());
            Console.Write("Ingrese un valor para xu: ");
            xu = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de iteraciones: ");
            i = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int count=0; count <= i-1; count++)
            {
                Console.WriteLine("Iteracion: {0}", count + 1);
                Console.WriteLine("Valor de Xi: {0}, Valor de Xu: {1}", xi,xu);
                Console.WriteLine("Valor de f(Xi): {0}, Valor en f(Xu): {1}", Funcion(xi), Funcion(xu));
                xr = PuntoMedio(xi, xu);
                Console.WriteLine("Valor de Xr: {0}", PuntoMedio(xi, xu));
                Console.WriteLine("Valor de f(Xi)*f(Xr): {0}",Funcion(xi)*Funcion(xr));
                if(Funcion(xi)*Funcion(xr) >0)
                {
                    xu = xr;
                }
                else if(Funcion(xi)*Funcion(xr)<0)
                {
                    xi = xr;
                }
                else
                {
                    Console.WriteLine("Raiz verdadera: {0}", xr);
                }
                Console.WriteLine("Error Aproximado: {0}", Error(xr));
                Console.WriteLine('\n' + "   ------    " + '\n');
                if(count+1==i)
                {
                    Console.WriteLine("La tolerancia ha sido satifacida en la iteracion {0} con un valor de {1} y un error de {2}%",count,Funcion(xr),Error(xr));
                }

            }
            Console.ReadKey();

            double Funcion(double x)
            {
                return (-0.5 * (Math.Pow(x, 2)) + (2.5 * x) + 4 - 5);
            }
            double PuntoMedio(double x1, double x2)
            {
                return (x1 + x2) / 2;
            }
            double Error(double x)
            {
                return Math.Abs((x - (x - 1) / x));
            }
        }
    }
}
