using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoa_Interface
{
    interface IPessoa
    {
        #region Properties
        string Nome { get; }
        string Sobrenome { get; }
        string Morada { get; }
        string Nacionalidade { get; }
        string Nomecompleto { get; }
        #endregion


        #region Methods

        string Inserir(string v1);

        string Apagar(string v1);

        string Alterar(string v1);

        string GerarNome(string v1, string v2);

        #endregion

    }
}
