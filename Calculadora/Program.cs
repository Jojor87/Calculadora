using System;
using UtilidadesCalculadora;
using CalculadoraBLL;

namespace CalculadoraUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // atributos
            double num1, num2;
            string operador;

            Console.WriteLine("los operadores son: +, -, *, /, V para raiz cuadrada y P para potencia \n");
            // introduce números y operación
            Console.WriteLine("Introduce el primer número:");             
            num1 = double.Parse(Console.ReadLine()); //El metodo int.Parse convierte una cadena en número de la línea leida

            Console.WriteLine("Introduce el operador:");
            operador = Console.ReadLine();

            // si es raiz cuadrada solo pide 1 numero
            if (operador.Equals("V")) { 
                num2 = 0;
            }
            else { 
                Console.WriteLine("Introduce el segundo número:");
                num2 = double.Parse(Console.ReadLine());
            }

            // Se crea objeto OperacionVO(num1, num2, operador)
            OperacionVO operacionVO = new OperacionVO(num1, num2, operador);

            OperacionBLL resultado = new OperacionBLL();
            //Se imprime solo 2 decimales
            double num = (Math.Truncate(resultado.RealizarOperacion(operacionVO) * 100) / 100);
            Console.WriteLine("el resultado es: " + num);

        }
    }
}
