using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havimany.VIEW.US_USUARIO_
{
    public partial class US_Usuario : PADRAO.SmallForm
    {
        public US_Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnClickLogin(object sender, EventArgs e)
        {
            
        }

        private void InserirUsuario(object sender, EventArgs e)
        {
            DAL.Connection conexao = new DAL.Connection();
            conexao.Conectar();

            if (textBoxPassWord.Text == "" || textBoxUsuario.Text == "")
            {
                MessageBox.Show("É necessário informar usuário ou senha para registrar.");
            }
            else
            {
                conexao.AdicionarNovoUsuario(textBoxUsuario.Text, textBoxPassWord.Text);
            }

        }
    }
}
