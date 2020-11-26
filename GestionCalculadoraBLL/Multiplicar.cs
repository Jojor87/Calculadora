using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;
namespace CalculadoraBLL
{
    class Multiplicar
    {
        // constructor() {
        public Multiplicar() 
        { 
        
        }

        public double RealizarMultiplicacion(OperacionVO operacion)
        {

            return operacion.OperandoUno * operacion.OperandoDos;
        }
    }
}
