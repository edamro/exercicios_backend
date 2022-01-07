using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface
{
    class Cliente : IPessoa
    {
        #region Properties
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Morada { get; set; }
        public string Nacionalidade { get; set; }
        public string Nomecompleto { get; set; }
        public string Cidade { get; set; }
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

        public string InformaCidade(string v1)
        {
            Cidade = v1;
            return Cidade;
        }
        #endregion
    }
}
