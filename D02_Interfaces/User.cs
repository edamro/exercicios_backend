using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class User : IAuthentication
    {
        #region Variables
        // é uma variável porque não é uma característica da classe
        string message;
        #endregion

        #region Properties
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        #endregion

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }
        #endregion

        #region Methods
        public void Exit()
        {
            message = "A sair.";
            Message(message, "\n\n");
        }

        public void Message(string message, string startLine = "", string endLine = "")
        {
            Console.Write($"{startLine}{message}{endLine}");
        }

        public bool Validate(string userName, string userPassword)
        {
            {
                if (userName == "Eduardo" && userPassword == "123")
                {
                    message = "OK";
                    Message(message, "", "\n");
                    return true;
                }
                else
                {
                    message = "NOK";
                    Message(message, "\n\n");
                    return false;
                }

            }
            #endregion
        }
    }
}
