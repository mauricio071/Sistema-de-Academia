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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void abrirForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }

            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");
            }
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();    
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_usuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abreForm(2, f_NovoUsuario);
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abrirForm(1, f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            abrirForm(1, f_GestaoUsuarios);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abrirForm(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abrirForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abrirForm(2, f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abrirForm(2, f_GestaoTurmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            abrirForm(2, f_GestaoAlunos);
        }
        
        private void btn_gestao_alunos_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            abrirForm(2, f_GestaoAlunos);
        }

        private void btn_gestao_usuarios_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            abrirForm(1, f_GestaoUsuarios);
        }

        private void btn_horarios_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abrirForm(2, f_Horarios);
        }

        private void btn_professores_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abrirForm(2, f_GestaoProfessores);
        }

        private void btn_turmas_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abrirForm(2, f_GestaoTurmas);
        }
    }
}
