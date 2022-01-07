using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario est = new Estagiario();
            Funcionario func = new Funcionario();
            Cliente cli = new Cliente();

            Console.WriteLine($"Foi inserido a estagiária: {est.Inserir("Maria")}");
            Console.WriteLine($"O nome foi apagado: {est.Apagar(" ")}");
            Console.WriteLine($"O nome foi alterado para: { est.Alterar("Pedro")}");
            Console.WriteLine($"O nome completo é: {est.GerarNome("Eduardo", "Rodrigues")}");
            Console.WriteLine($"Nome da universidade: {est.InserirUniv("FCUP")}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Foi inserido o funcionário: {func.Inserir("Eduardo")}");
            Console.WriteLine($"O nome foi apagado: {func.Apagar(" ")}");
            Console.WriteLine($"O nome foi alterado para: {func.Alterar("Ana")}");
            Console.WriteLine($"O nome completo é: {func.GerarNome("Lucas", "Rodrigues")}");
            Console.WriteLine($"O ano de admissão é: {func.InformaAno(2010)}");
            Console.WriteLine($"Departamento: {func.InformaDep("Financeiro")}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Foi inserido o cliente: {cli.Inserir("Claudia")}");
            Console.WriteLine($"O nome foi apagado: {cli.Apagar(" ")}");
            Console.WriteLine($"O nome foi alterado para: {cli.Alterar("Pedro")}");
            Console.WriteLine($"O nome completo é: {cli.GerarNome("Eduardo", "Amarante")}");
            Console.WriteLine($"Cidade: {cli.InformaCidade("Porto")}");

            Console.ReadKey();
        }
    }
}
