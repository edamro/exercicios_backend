using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculadoraSimples calculadorasimples = new CalculadoraSimples();
                CalculadoraCientifica calculadoracientifica = new CalculadoraCientifica();

                // iniciar calculadora simples
                Console.WriteLine("\nCALCULADORA SIMPLES\n\n");

                calculadorasimples.MostrarMenu();
                calculadorasimples.LerValor1();
                calculadorasimples.LerOperacao();
                calculadorasimples.LerValor2();


                if (calculadorasimples.ValidarOperacao())    // se for true
                {
                    calculadorasimples.RealizarOperacao();
                    calculadorasimples.EscreverResultado();
                }
                else
                {
                    Console.WriteLine("\nNão foi possível realizar a operação.\n\n");
                }

                Console.WriteLine("\nPressione uma tecla para Calculadora Científica\n\n");
                Console.ReadKey();

                // iniciar calculadora científica
                Console.WriteLine("\nCALCULADORA CIENTÍFICA\n\n");

                calculadoracientifica.MostrarMenu();
                calculadoracientifica.LerValor1();
                // se operador = raiz quadrada, só lê um valor
                if (!calculadoracientifica.LerOperacao())
                    calculadoracientifica.LerValor2();


                if (calculadoracientifica.ValidarOperacao())    // se for true
                {
                    calculadoracientifica.RealizarOperacao();
                    calculadoracientifica.EscreverResultado();
                }
                else
                {
                    Console.WriteLine("\nNão foi possível realizar a operação.\n\n");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\n\nAtenção ao argumento.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n\nAtenção ao formato do número.");
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nOcorreu um erro.");
            }

            Console.ReadKey();
        }

    }
}
