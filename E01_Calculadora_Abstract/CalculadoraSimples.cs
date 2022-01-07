using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    class CalculadoraSimples : Calculadora
    {

        #region Properties
        public override double Valor1 { get; set; }
        public override double Valor2 { get; set; }
        public override string Operacao { get; set; }
        public override double Resultado { get; set; }
        #endregion

        #region Methods
        public override void MostrarMenu()
        {

            // Adaptar para array (vetor) + foreach
            string[] menu = new string[]
            {
                "[+]",
                "[-]",
                "[/]",
                "[*]"
            };

            Console.WriteLine("Operações\n");

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

        }

        public override void LerValor1()
        {

            Console.Write("\nValor 1: ");
            Valor1 = Convert.ToDouble(Console.ReadLine());

        }

        public override void LerValor2()
        {

            Console.Write("\nValor 2: ");
            Valor2 = Convert.ToDouble(Console.ReadLine());

        }

        public override bool LerOperacao()
        {
            bool raiz = false;
            Console.Write("\nOperação: ");
            Operacao = Console.ReadLine();
            if (Operacao == "sqr")
                raiz = true;
            return raiz;
        }

        public override bool ValidarOperacao()
        {

            // Ver se a operação está dentro duma das hipóteses do menu com switch
            // Se sim, atribuir a uma variável boolean o valor true,
            // caso contrário, atribuir false

            bool validado;

            switch (Operacao)
            {

                case "+":
                    validado = true;
                    break;
                case "-":
                    validado = true;
                    break;
                case "*":
                    validado = true;
                    break;
                case "/":
                    validado = true;
                    break;
                default:
                    validado = false;
                    break;

            }

            return validado;

        }

        public override void RealizarOperacao()
        {

            switch (Operacao)
            {
                case "+":
                    Somar();
                    break;
                case "-":
                    Subtrair();
                    break;
                case "*":
                    Multiplicar();
                    break;
                case "/":
                    Dividir();
                    break;
            }

        }

        public override void Somar()
        {

            Resultado = Valor1 + Valor2;

        }

        public override void Subtrair()
        {

            Resultado = Valor1 - Valor2;

        }

        public override void Multiplicar()
        {

            Resultado = Valor1 * Valor2;

        }

        public override void Dividir()
        {

            // Ainda temos de verificar o 2º operando!!!
            if (Valor2 == 0)    // "0" == 0 --> true; "0" === 0 --> false
            {
                Resultado = 0;
            }
            else
            {
                Resultado = Valor1 / Valor2;
            }

        }

        public override void CalcularRaizQuadrada()
        {  
        }
        
        public override void EscreverResultado()
        {

            Console.WriteLine("\n\nResultado: " + Resultado.ToString());

        }
        #endregion

    }
}
