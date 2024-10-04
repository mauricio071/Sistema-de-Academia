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
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT 
                    N_ID_PROFESSOR as 'ID',
                    T_NOME_PROFESSOR as 'Professor',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    N_ID_PROFESSOR
            ";
            dgv_professores.DataSource = Banco.Dql(vquery);
            dgv_professores.Columns[0].Width = 60;
            dgv_professores.Columns[1].Width = 170;
            dgv_professores.Columns[2].Width = 100;
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT 
                        *
                    FROM
                        tb_professores
                    WHERE
                        N_ID_PROFESSOR=" + vid;
                dt = Banco.Dql(vquery);
                tb_id_professor.Text = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                tb_professor.Text = dt.Rows[0].Field<string>("T_NOME_PROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }

        private void btn_novo_professor_Click(object sender, EventArgs e)
        {
            tb_id_professor.Clear();
            tb_professor.Clear();
            mtb_telefone.Clear();
            tb_professor.Focus();
        }

        private void btn_salvar_professor_Click(object sender, EventArgs e)
        {
            String vquery;
            if (tb_id_professor.Text == "")
            {
                vquery = "INSERT INTO tb_professores (T_NOME_PROFESSOR, T_TELEFONE) VALUES ('" + tb_professor.Text + "','" + mtb_telefone.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOME_PROFESSOR='" + tb_professor.Text + "', T_TELEFONE='" + mtb_telefone.Text + "' WHERE N_ID_PROFESSOR=" + tb_id_professor.Text;
            }

            Banco.Dml(vquery);
            vquery = @"
                SELECT 
                    N_ID_PROFESSOR as 'ID',
                    T_NOME_PROFESSOR as 'Professor',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    N_ID_PROFESSOR
            ";
            dgv_professores.DataSource = Banco.Dql(vquery);
        }

        private void btn_excluir_professor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_ID_PROFESSOR=" + tb_id_professor.Text;
                Banco.Dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
