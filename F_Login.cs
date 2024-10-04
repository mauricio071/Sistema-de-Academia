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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string usuario = tb_nome.Text;
            string senha = tb_senha.Text;

            if(usuario == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
                tb_nome.Focus();
                return;  
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_NOME_USUARIO='" + usuario + "' AND T_SENHA_USUARIO='" + senha + "'";
            dt = Banco.Dql(sql);
            if(dt.Rows.Count == 1)
            {
                //Primeira forma para acessar o dado do banco de dados
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();

                //Segunda forma para acessar o dado do banco de dados
                form1.lb_usuario.Text = dt.Rows[0].Field<string>("T_NOME_USUARIO");

                form1.pb_ledLogado.Image = Properties.Resources.led_verde;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVEL_USUARIO").ToString());
                Globais.logado = true;
                this.Close();
            } else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
