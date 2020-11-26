using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;

namespace CalculadoraBLL
{
    class RaizCuadrada
    {
        // constructor() {}
        public RaizCuadrada() 
        { 
        }

        public double RealizarRaizC(OperacionVO operacion)
        {

            return Math.Sqrt(operacion.OperandoUno);  
        }
    }
}
