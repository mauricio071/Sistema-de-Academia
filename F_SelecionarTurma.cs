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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno formNovoAluno;

        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            formNovoAluno = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = String.Format(@"
                SELECT
                    tbt.N_ID_TURMA as 'ID',
                    tbt.T_DESCRICAO_TURMA as 'Turma',
                    tbh.T_DESCRICAO_HORARIO as 'Horário',
                    tbp.T_NOME_PROFESSOR as 'Professor',
                    tbt.N_MAX_ALUNOS as 'Máx. ALunos',
                    (   SELECT
                            count(N_ID_ALUNO)
                        FROM
                            tb_alunos as tba
                        WHERE
                            tba.N_ID_TURMA = tbt.N_ID_TURMA and T_STATUS = 'A'
                    ) as 'Qtde. Alunos' 
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_ID_PROFESSOR = tbt.N_ID_PROFESSOR
                INNER JOIN
                    tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ");
            dgv_turmas.DataSource = Banco.Dql(queryTurma);
        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAluno = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAluno = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if(qtdeAluno >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
            } else
            {
                formNovoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formNovoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
