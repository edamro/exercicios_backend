using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11_Calculadora_Abstract
{
    abstract class Calculadora
    {

        #region Properties
        public abstract double Valor1 { get; set; }
        public abstract double Valor2 { get; set; }
        public abstract double Resultado { get; set; }
        #endregion

        #region Methods
        public abstract double Somar(double v1, double v2);

        public abstract double Subtrair(double v1, double v2);

        public abstract double Multiplicar(double v1, double v2);

        public abstract double Dividir(double v1, double v2);
        #endregion
    }
}
