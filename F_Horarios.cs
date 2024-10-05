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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT 
                    N_ID_HORARIO as 'ID',
                    T_DESCRICAO_HORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DESCRICAO_HORARIO
            ";
            dgv_horarios.DataSource = Banco.Dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 170;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT 
                        *
                    FROM
                        tb_horarios
                    WHERE
                        N_ID_HORARIO=" + vid;
                dt = Banco.Dql(vquery);
                tb_id_horario.Text = dt.Rows[0].Field<Int64>("N_ID_HORARIO").ToString();
                mtb_descHorario.Text = dt.Rows[0].Field<string>("T_DESCRICAO_HORARIO");
            }
        }

        private void LimparCampos()
        {
            tb_id_horario.Clear();
            mtb_descHorario.Clear();
            mtb_descHorario.Focus();
        }

        private void btn_novo_horario_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_salvar_horario_Click(object sender, EventArgs e)
        {
            String vquery;
            if(tb_id_horario.Text == "")
            {
                vquery = "INSERT INTO tb_horarios (T_DESCRICAO_HORARIO) VALUES ('" + mtb_descHorario.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DESCRICAO_HORARIO='" + mtb_descHorario.Text + "'WHERE N_ID_HORARIO=" + tb_id_horario.Text;
            }

            Banco.Dml(vquery);
            vquery = @"
                SELECT 
                    N_ID_HORARIO as 'ID',
                    T_DESCRICAO_HORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DESCRICAO_HORARIO
            ";
            dgv_horarios.DataSource = Banco.Dql(vquery);
            MessageBox.Show("Alteração salva");
        }

        private void btn_excluir_horario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                string vquery = "DELETE FROM tb_horarios WHERE N_ID_HORARIO=" + tb_id_horario.Text; 
                Banco.Dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
                LimparCampos();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
