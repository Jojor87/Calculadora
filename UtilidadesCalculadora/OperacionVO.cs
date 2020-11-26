using System;
using System.Collections.Generic;
using System.Text;

namespace UtilidadesCalculadora
{
    public class OperacionVO
    {
        // atributos
        private double operandoUno;
        private double operandoDos;
        private string operador;
    
    // constructor
    public OperacionVO(double num1, double num2, string operador) {
            this.operandoUno = num1;
            this.operandoDos = num2;
            this.operador = operador;
        }

        // geters y seters
        public double OperandoUno { get => operandoUno; set => operandoUno = value; }
        public double OperandoDos { get => operandoDos; set => operandoDos = value; }
        public string Operador { get => operador; set => operador = value; }

        
    }
}
