﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrande
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int mes;
            Console.WriteLine("Ingresa el numero del que quieres conocer el mes:");
            mes = Convert.ToByte(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                case 0:
                    Console.WriteLine("Ingresa un valor del 1 al 12");
                    Console.WriteLine("Ingresa un valor del 1 al 12");
                    break;
            }

            Console.WriteLine("El numero corresponde al mes: {0}", mes);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
    }

