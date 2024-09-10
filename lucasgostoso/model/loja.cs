using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lucasgostoso.view;

namespace lucasgostoso
{
    internal static class Loja
    {
        private static int codigo;
        private static string nome;
        private static string cpf;
        private static string idade;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Idade { get => idade; set => idade = value; }
    }
}