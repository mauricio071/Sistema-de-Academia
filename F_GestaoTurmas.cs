using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0=Padrão 1=Edição 3=Inserção
        string vqueryDGV;
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            //Popular professores
            vqueryDGV = @"
                SELECT 
                    tbt.N_ID_TURMA as 'ID',
                    tbt.T_DESCRICAO_TURMA as 'Turma',
                    tbh.T_DESCRICAO_HORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ";
            dgv_turmas.DataSource = Banco.Dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;

            string vqueryProfessores = @"
                SELECT
                    N_ID_PROFESSOR,
                    T_NOME_PROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_ID_PROFESSOR
            ";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.Dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOME_PROFESSOR";
            cb_professor.ValueMember = "N_ID_PROFESSOR";

            //Popular Status (Ativa=A, Paralisada=P, Cancelada=C)
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular Horários
            string vqueryHorarios = @"
                SELECT 
                    *
                FROM
                    tb_horarios
                ORDER BY
                    N_ID_HORARIO
            ";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.Dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DESCRICAO_HORARIO";
            cb_horario.ValueMember = "N_ID_HORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                modo = 0;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vquerCampos = @"
                    SELECT
                        T_DESCRICAO_TURMA,
                        N_ID_PROFESSOR,
                        N_ID_HORARIO,
                        N_MAX_ALUNOS,
                        T_STATUS
                    FROM    
                        tb_turmas
                    WHERE   
                        N_ID_TURMA= " + idSelecionado;
                DataTable dt = Banco.Dql(vquerCampos);
                tb_descricao.Text = dt.Rows[0].Field<string>("T_DESCRICAO_TURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                nd_maximo.Value = dt.Rows[0].Field<Int64>("N_MAX_ALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_HORARIO");
                CalcVagas(); 
            }
        }

        private void CalcVagas()
        {
            //Cálculo de Vagas
            string queryVagas = String.Format(@"
                    SELECT 
                        count(N_ID_ALUNO) as 'contVagas'
                    FROM 
                        tb_alunos
                    WHERE
                        T_STATUS = 'A' and N_ID_TURMA={0}", idSelecionado
            );
            DataTable dt = Banco.Dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(nd_maximo.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            tb_vagas.Text = vagas.ToString();
        }

        private void btn_nova_turma_Click(object sender, EventArgs e)
        {
            tb_descricao.Clear();
            cb_professor.SelectedIndex = -1;
            nd_maximo.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_vagas.Text = "0";
            tb_descricao.Focus();
            modo = 2;
        }

        private void btn_salvar_turma_Click(object sender, EventArgs e)
        {
            if(modo != 0)
            {
                string queryTurma = "";
                string msg = "";

                if(modo == 1)
                {
                    msg = "Dados alterados";
                    queryTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DESCRICAO_TURMA='{0}',
                        N_ID_PROFESSOR = {1},
                        N_ID_HORARIO = {2},
                        N_MAX_ALUNOS = {3},
                        T_STATUS = '{4}'
                    WHERE
                        N_ID_TURMA={5}", tb_descricao.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nd_maximo.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado
                    );
                } 
                else
                {
                    msg = "Nova turma inserida";
                    queryTurma = String.Format(@"
                    INSERT INTO tb_turmas
                        (T_DESCRICAO_TURMA, N_ID_PROFESSOR, N_ID_HORARIO, N_MAX_ALUNOS, T_STATUS)
                        VALUES('{0}', {1}, {2}, {3}, '{4}')", tb_descricao.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nd_maximo.Value, 0).ToString()), cb_status.SelectedValue);
                }
                int linha = dgv_turmas.SelectedRows[0].Index;

                Banco.Dml(queryTurma);
                if(modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_descricao.Text;
                    dgv_turmas[2, linha].Value = cb_horario.Text;
                    CalcVagas();
                } else
                {
                    dgv_turmas.DataSource = Banco.Dql(vqueryDGV);
                }
                
                MessageBox.Show(msg);
            } 
        }
           
        private void btn_excluir_turma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_ID_TURMA={0}", idSelecionado
                );
                Banco.Dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                modo = 1;
            }  
        }

        private void cb_professor_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nd_maximo_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void btn_imprimir_turma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritoPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Relatório de Turmas\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));

            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("\n© Maurício Naoki");

            PdfPTable tabela = new PdfPTable(3);
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.Dql(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horário"));
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
