using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Academia
{
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT 
                    N_ID_ALUNO as 'ID',
                    T_NOME_ALUNO as 'Aluno'
                FROM
                    tb_alunos
            ";
            dgv_alunos.DataSource = Banco.Dql(vqueryDGV);
            dgv_alunos.Columns[0].Width = 40;
            dgv_alunos.Columns[1].Width = 120;

            tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();

            //Popular ComboBox turmas
            string vqueryTurmas = @"
                SELECT
                    N_ID_TURMA,
                    ('Vagas: '|| (
                                    (N_MAX_ALUNOS)-(
                                                     SELECT
                                                         count(tba.N_ID_ALUNO)
                                                     FROM
                                                         tb_alunos as tba
                                                     WHERE
                                                          tba.T_STATUS = 'A' and tba.N_ID_TURMA = N_ID_TURMA
                                                    )
                                  ) || ' /Turma: ' || T_DESCRICAO_TURMA
                    ) as 'Turma'    
                FROM
                   tb_turmas
                ORDER BY
                   N_ID_TURMA
            ";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.Dql(vqueryTurmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_ID_TURMA";

            //Popular ComboBox Status (Ativo=A, Bloqueado=B, Cancelado=C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas.Text;
            turmaAtual = cb_turmas.Text;
            idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {    
            turma = cb_turmas.Text;
            string[] t = turma.Split(' ');
            int vagas = int.Parse(t[1]);
            if (vagas < 1)
            {
                MessageBox.Show("Não há vagas na turma selecionada, selecione outra turma");
                cb_turmas.Focus();
                return;
            }
            linha = dgv_alunos.SelectedRows[0].Index;
            string queryAtualizarAluno = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOME_ALUNO='{0}',
                        T_TELEFONE='{1}',
                        T_STATUS='{2}',
                        N_ID_TURMA='{3}',
                        T_FOTO='{4}'
                    WHERE
                        N_ID_ALUNO={5}
                ", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, pb_foto.ImageLocation, idSelecionado);
            Banco.Dml(queryAtualizarAluno);
            dgv_alunos[1, linha].Value = tb_nome.Text;
            MessageBox.Show("Alteração salva");
        }

        private void btn_excluir_aluno_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(File.Exists(pb_foto.ImageLocation))
                {
                    File.Delete(pb_foto.ImageLocation);
                }

                string vqueryExcluirALuno = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_ID_ALUNO={0}
                ", idSelecionado);
                Banco.Dml(vqueryExcluirALuno);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0) {
                idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();
                tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();    
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = String.Format(@"
                    SELECT
                        N_ID_ALUNO,
                        T_NOME_ALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_ID_TURMA,
                        T_FOTO
                    FROM
                        tb_alunos
                    WHERE
                        N_ID_ALUNO={0}
                ", idSelecionado);
                DataTable dt = Banco.Dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOME_ALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_TURMA");
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                turmaAtual = cb_turmas.Text;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\carterinha.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.B6);
            PdfWriter escritoPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
            logo.ScaleToFit(40f, 20f);
            logo.Alignment = Element.ALIGN_LEFT;
            
            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Carterinha\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Bold));

            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("\n© Maurício Naoki");

            iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(pb_foto.ImageLocation);
            foto.ScaleToFit(60f, 88f);

            Paragraph info = new Paragraph("", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            info.Alignment = Element.ALIGN_LEFT;
            info.Add("Nome: " + tb_nome.Text + "\n\n");
            info.Add("Telefone: " + mtb_telefone.Text + "\n\n");
            info.Add("Status: " + cb_status.SelectedValue + "\n\n");
            info.Add("Turmas: " + cb_turmas.SelectedValue + "\n\n");

            PdfPTable tabela = new PdfPTable(2);
            tabela.WidthPercentage = 80;
            tabela.HorizontalAlignment = Element.ALIGN_CENTER;
            tabela.SetWidths(new float[] { 1, 2 });

            PdfPCell celulaFoto = new PdfPCell(foto);
            celulaFoto.Border = PdfPCell.NO_BORDER;
            celulaFoto.VerticalAlignment = Element.ALIGN_MIDDLE;

            PdfPCell celulaTexto = new PdfPCell(info);
            celulaTexto.Border = PdfPCell.NO_BORDER;
            celulaTexto.VerticalAlignment = Element.ALIGN_MIDDLE;

            tabela.AddCell(celulaFoto);
            tabela.AddCell(celulaTexto);

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir a carterinha?", "Carterinha", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\carterinha.pdf");
            }
        }

        private void pb_foto_DoubleClick(object sender, EventArgs e)
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = Globais.caminhoFoto;
            string destinoCompleto = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog.FileName;
                foto = openFileDialog.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            
            pb_foto.ImageLocation = origemCompleto;
        }
    }
}