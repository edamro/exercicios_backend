using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface
{
    class Funcionario : IPessoa
    {
        #region Properties
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Morada { get; set; }
        public string Nacionalidade { get; set; }
        public string Nomecompleto { get; set; }
        public string Departamento { get; set; }
        public int Anoentrada { get; set; }
        #endregion

        #region Methods

        public string Inserir(string v1)
        {
            Nome = v1;
            return Nome;
        }

        public string Apagar(string v1)
        {
            Nome = v1;
            return Nome;
        }

        public string Alterar(string v1)
        {
            Nome = v1;
            return Nome;
        }

        public string GerarNome(string v1, string v2)
        {
            Nomecompleto = ($"{v1} {v2}");
            return Nomecompleto;
        }

        public int InformaAno(int v3)
        {
            Anoentrada = v3;
            return Anoentrada;
        }

        public string InformaDep(string v1)
        {
            Departamento = v1;
            return Departamento;
        }
        #endregion

    }
}
