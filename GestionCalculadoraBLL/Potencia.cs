using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;

namespace CalculadoraBLL
{
    class Potencia
    {
        public Potencia() 
        { 
        }
        public double RealizarPotencia(OperacionVO operacion)
        {

            return Math.Pow(operacion.OperandoUno, operacion.OperandoDos);
        }
    }
}
