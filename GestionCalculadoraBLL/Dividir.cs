using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;
namespace CalculadoraBLL
{
    class Dividir
    {
        // constructor() {}
        public Dividir() 
        {
        }

        public double RealizarDivision(OperacionVO operacion)
        {

            return operacion.OperandoUno / operacion.OperandoDos;
        }
    }
}
