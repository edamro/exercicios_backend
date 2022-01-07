using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    abstract class Calculadora
    {
        #region Properties
        public abstract double Valor1 { get; set; }
        public abstract double Valor2 { get; set; }
        public abstract string Operacao { get; set; }
        public abstract double Resultado { get; set; }
        #endregion


        #region Methods
        public abstract void MostrarMenu();

        public abstract void LerValor1();

        public abstract void LerValor2();

        public abstract bool LerOperacao();

        public abstract bool ValidarOperacao();

        public abstract void RealizarOperacao(); 

        public abstract void Somar();

        public abstract void Subtrair();

        public abstract void Multiplicar();

        public abstract void Dividir();

        public abstract void CalcularRaizQuadrada();

        public abstract void EscreverResultado();
        #endregion

    }
}
