using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucasgostoso.view
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loja.nome = tbx_nome.Text;
            loja.cpf = tbx_cpf.Text;
            loja.idade = cbx_idade.Text;




        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
