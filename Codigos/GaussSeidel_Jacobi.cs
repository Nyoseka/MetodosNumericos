using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussSeidel_Jacobi
{
    class Program
    {
        static void Main(string[] args)
        {
            double ec;
            double[,] matriz = new double[3, 4];
            double[] vInicial = new double[3];
            int op;
            int iteraciones;
            Menu();
            void Menu()
            {
                Console.WriteLine("PRACTICA #3" + '\n');
                Console.WriteLine("Métodos a realizar");
                Console.WriteLine("1. Método Gauss-Seidel");
                Console.WriteLine("2. Método Jacobi");
                Console.Write('\n' + "Elija un método para continuar: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        op = 1;
                        {

                            Console.Clear();
                            Console.WriteLine("Ingrese los valores que desee a la matriz: ");
                            for (int c = 0; c <= 2; c++)
                            {
                                for (int i = 0; i <= 3; i++)
                                {
                                    Console.Write("Valor: ");
                                    ec = double.Parse(Console.ReadLine());
                                    matriz[c, i] = ec;
                                }
                            }
                            Console.Write("Ingrese el número de iteraciones: ");
                            iteraciones = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los valores iniciales: ");
                            for (int c = 0; c <= 2; c++)
                            {
                                vInicial[c] = double.Parse(Console.ReadLine());
                            }
                            GaussSeidel(matriz, 3, 4);
                            ImprimirMatriz();
                            Console.WriteLine("¿Desea continuar? ");
                            Console.WriteLine("a) Sí" + '\n' + "b) No");
                            char o;
                            o = char.Parse(Console.ReadLine());
                            if (o == 'a')
                            {
                                Console.Clear();
                                Menu();
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 2:
                        op = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese los valores que desee a la matriz: ");
                            for (int c = 0; c <= 2; c++)
                            {
                                for (int i = 0; i <= 3; i++)
                                {
                                    Console.Write("Valor: ");
                                    ec = double.Parse(Console.ReadLine());
                                    matriz[c, i] = ec;
                                }
                            }
                            Console.Write("Ingrese el número de iteraciones: ");
                            iteraciones = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los valores iniciales: ");
                            for(int c = 0; c <= 2; c++)
                            {
                                vInicial[c] = double.Parse(Console.ReadLine());
                            }
                            Jacobi(matriz,3,4);
                            ImprimirMatriz();
                            Console.WriteLine("¿Desea salir? ");
                            Console.WriteLine("a) Sí" + '\n' + "b) No");
                            char o;
                            o = char.Parse(Console.ReadLine());
                            if (o == 'a')
                            {
                                Console.Clear();
                                Console.Write("Pulse cualquier tecla para salir");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Menu();
                            }
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.Write("OPCIÓN INVÁLIDA");
                            break;
                        }
                }
            }

            void ImprimirMatriz()
            {
                Console.WriteLine("Matriz Utilizada" + '\n');
                for (int c = 0; c <= 2; c++)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.Write(matriz[c, i] + ", ");
                    }
                }
            }
            void Jacobi(double[,] mat, int fila, int columna)
            {
                double temp=0;
                for (int c = 0; c <= 2; c++)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        temp += mat[c, i] * vInicial[i];
                        temp = (mat[i, columna - 1] - temp) / matriz[i, i];
                        vInicial[i] = temp;
                    }
                    Console.WriteLine("Solución: {0}",vInicial[c]);
                }
            }

            void GaussSeidel(double[,] matrix, int filas, int columnas)
            {
                double temp=0;
                for(int c=0; c<=2; c++)
                {
                    for(int i = 0; i <= 2; i++)
                    {
                        temp += matrix[c, i] * vInicial[i];
                        temp = (matrix[c, columnas - 1]) / matrix[i, i];
                        vInicial[i] = temp;
                    }
                    Console.WriteLine("Solución: {0}",vInicial[c]);
                }
            }
        }
    }
}