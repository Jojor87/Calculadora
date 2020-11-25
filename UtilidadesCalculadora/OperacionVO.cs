using System;
using System.Collections.Generic;
using System.Text;

namespace UtilidadesCalculadora
{
    public class OperacionVO
    {
        // atributos
        private int operandoUno;
        private int operandoDos;
        private string operador;
    
    // constructor
    public OperacionVO(int num1, int num2, string operador) {
            this.operandoUno = num1;
            this.operandoDos = num2;
            this.operador = operador;
        }

        // geters y seters
        public int OperandoUno { get => operandoUno; set => operandoUno = value; }
        public int OperandoDos { get => operandoDos; set => operandoDos = value; }
        public string Operador { get => operador; set => operador = value; }

        
    }
}
