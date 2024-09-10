using lucasgostoso.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucasgostoso.controller
{
    internal class controllercadastro
    {
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("" cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            
                try

                {

                    cmd.Parameters.AddWithValue("@nome", Loja.Nome);
                    cmd.Parameters.AddWithValue("@cpf", Loja.Cpf);
                    cmd.Parameters.AddWithValue("@idade", Loja.Idade);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados inseridos com sucesso");
                }
                catch (Exception)
                {
                    throw;
                }

            
        }
    }
}
