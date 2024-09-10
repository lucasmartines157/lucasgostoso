using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucasgostoso.model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucas.mneves3\source\repos\lucasgostoso\lucasgostoso\dados\Database1.mdf;Integrated Security=True";
        }

    }
}
