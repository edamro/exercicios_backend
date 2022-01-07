using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{
    interface ICalculadora
    {

        #region Properties
        double Valor1 { get; }
        double Valor2 { get; }
        string Operacao { get; }
        double Resultado { get; }
        #endregion


        #region Methods
        void MostrarMenu();

        void LerValor1();

        void LerValor2();

        bool LerOperacao();

        bool ValidarOperacao();

        void RealizarOperacao();

        void Somar();

        void Subtrair();

        void Multiplicar();

        void Dividir();

        void CalcularRaizQuadrada();

        void EscreverResultado();
        #endregion
    }
}
