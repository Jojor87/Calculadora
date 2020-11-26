using System;
using System.Collections.Generic;
using System.Text;
using UtilidadesCalculadora;

namespace CalculadoraBLL
{
    public class Restar
    {
        // constructor() {
        public Restar() 
        { 
        }
        public double RealizarResta(OperacionVO operacion)
        {

            return operacion.OperandoUno - operacion.OperandoDos;
        }
    }
}
