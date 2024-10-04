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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_ID_USUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOME_USUARIO").ToString();
                tb_usuario.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHA_USUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUS_USUARIO").ToString();
                nd_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVEL_USUARIO");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.N_ID_USUARIO = Convert.ToInt32(tb_id.Text);
            u.T_NOME_USUARIO = tb_nome.Text;
            u.T_USERNAME = tb_usuario.Text;
            u.T_SENHA_USUARIO = tb_senha.Text;
            u.T_STATUS_USUARIO = cb_status.Text;
            u.N_NIVEL_USUARIO = Convert.ToInt32(Math.Round(nd_nivel.Value, 0));
            Banco.AtualizarUsuario(u);
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
