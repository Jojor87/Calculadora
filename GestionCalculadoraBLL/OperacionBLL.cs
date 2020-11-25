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
        public int RealizarOperacion(OperacionVO operacion) {
            int resultado = 0;
            Sumar suma = new Sumar();

            if (operacion.Operador.Equals("+"))
                // Console.WriteLine("sumar")
                
                resultado = suma.Realizarsuma(operacion);
            else if (operacion.Operador.Equals("-"))
                // Console.WriteLine("restar")
                resultado = 2;
            else if (operacion.Operador.Equals("*"))
                // Console.WriteLine("multiplicar")
                resultado = 3;
            else if (operacion.Operador.Equals("/"))
                // Console.WriteLine("multiplicar")
                resultado = 4;
            else if (operacion.Operador.Equals("V"))
                // Console.WriteLine("multiplicar")
                resultado = 5;
            else if (operacion.Operador.Equals("P"))
                // Console.WriteLine("multiplicar")
                resultado = 6;
            else 
                resultado = 7;

            return resultado;
            
        }
    }
}
