using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_usuario.Clear();
            tb_senha.Clear();
            cb_status.Text = "";
            nd_nivel.Value = 0;
            tb_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.T_NOME_USUARIO = tb_nome.Text;
            usuario.T_USERNAME = tb_usuario.Text;
            usuario.T_SENHA_USUARIO = tb_senha.Text;
            usuario.T_STATUS_USUARIO = cb_status.Text;
            usuario.N_NIVEL_USUARIO = Convert.ToInt32(Math.Round(nd_nivel.Value, 0));

            Banco.NovoUsuario(usuario);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
