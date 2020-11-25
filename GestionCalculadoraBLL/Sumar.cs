using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;

namespace CalculadoraBLL
{
    public class Sumar
    {
        // constructor() {}
        public Sumar()
        {
        }

        public int Realizarsuma(OperacionVO operacion)
        {
            
            return operacion.OperandoUno + operacion.OperandoDos;
        }
    }
}
