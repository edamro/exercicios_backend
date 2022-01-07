using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            User user01 = new User("Eduardo", "123");
            User user02 = new User("qaz", "qwe");
            // Criar o 3º user pedindo os valores na consola

            user01.Validate(user01.UserName, user01.UserPassword);
            user02.Validate(user02.UserName, user02.UserPassword);

            Console.ReadKey();
        }
    }
}
