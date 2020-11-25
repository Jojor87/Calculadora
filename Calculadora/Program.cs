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
            int num1, num2;
            string operador;

            Console.WriteLine("los operadores son: +, -, *, /, V para raiz cuadrada y P para potencia \n");
            // introduce números y operación
            Console.WriteLine("Introduce el primer número:");             
            num1 = int.Parse(Console.ReadLine()); //El metodo int.Parse convierte una cadena en número de la línea leida

            Console.WriteLine("Introduce el operador:");
            operador = Console.ReadLine();

            Console.WriteLine("Introduce el segundo número:");
            num2 = int.Parse(Console.ReadLine());

            // Se crea objeto OperacionVO(num1, num2, operador)
            OperacionVO operacionVO = new OperacionVO(num1, num2, operador);

            OperacionBLL resultado = new OperacionBLL();
            // int resultado = OperacionBLL.operacion(operacionVO);
            Console.WriteLine(resultado.RealizarOperacion(operacionVO));

        }
    }
}
