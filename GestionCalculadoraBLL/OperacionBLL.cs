using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;

namespace CalculadoraBLL
{
    public class OperacionBLL
    {
        // constructor() {}
        public OperacionBLL() {
        }
        // método realizar operacion(OperacionVO operacion);
        public double RealizarOperacion(OperacionVO operacion) {
            // atributos
            double resultado;
            Sumar suma = new Sumar();
            Restar resta = new Restar();
            Multiplicar multiplicacion = new Multiplicar();
            Dividir division = new Dividir();
            RaizCuadrada raizC = new RaizCuadrada();
            Potencia potencia = new Potencia();

            if (operacion.Operador.Equals("+"))
                // Console.WriteLine("sumar")  
                resultado = suma.RealizarSuma(operacion);
            else if (operacion.Operador.Equals("-"))
                // Console.WriteLine("restar")
                resultado = resta.RealizarResta(operacion);
            else if (operacion.Operador.Equals("*"))
                // Console.WriteLine("multiplicar")
                resultado = multiplicacion.RealizarMultiplicacion(operacion);
            else if (operacion.Operador.Equals("/"))
                // Console.WriteLine("dividir")
                resultado = division.RealizarDivision(operacion);
            else if (operacion.Operador.Equals("V"))
                // Console.WriteLine("raiz cuadrada")
                resultado = raizC.RealizarRaizC(operacion);
            else if (operacion.Operador.Equals("P"))
                // Console.WriteLine("potencia")
                resultado = potencia.RealizarPotencia(operacion);
            else 
                resultado = 7;

            return resultado;
            
        }
    }
}
