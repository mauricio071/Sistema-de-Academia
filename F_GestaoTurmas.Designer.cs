namespace Academia
{
    partial class F_GestaoTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimir_turma = new System.Windows.Forms.Button();
            this.btn_excluir_turma = new System.Windows.Forms.Button();
            this.btn_salvar_turma = new System.Windows.Forms.Button();
            this.btn_nova_turma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nd_maximo = new System.Windows.Forms.NumericUpDown();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_imprimir_turma);
            this.panel1.Controls.Add(this.btn_excluir_turma);
            this.panel1.Controls.Add(this.btn_salvar_turma);
            this.panel1.Controls.Add(this.btn_nova_turma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 59);
            this.panel1.TabIndex = 32;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(592, 18);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(138, 23);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir_turma
            // 
            this.btn_imprimir_turma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir_turma.Location = new System.Drawing.Point(448, 18);
            this.btn_imprimir_turma.Name = "btn_imprimir_turma";
            this.btn_imprimir_turma.Size = new System.Drawing.Size(138, 23);
            this.btn_imprimir_turma.TabIndex = 3;
            this.btn_imprimir_turma.Text = "Imprimir Turma";
            this.btn_imprimir_turma.UseVisualStyleBackColor = true;
            this.btn_imprimir_turma.Click += new System.EventHandler(this.btn_imprimir_turma_Click);
            // 
            // btn_excluir_turma
            // 
            this.btn_excluir_turma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_turma.Location = new System.Drawing.Point(304, 18);
            this.btn_excluir_turma.Name = "btn_excluir_turma";
            this.btn_excluir_turma.Size = new System.Drawing.Size(138, 23);
            this.btn_excluir_turma.TabIndex = 2;
            this.btn_excluir_turma.Text = "Excluir Turma";
            this.btn_excluir_turma.UseVisualStyleBackColor = true;
            this.btn_excluir_turma.Click += new System.EventHandler(this.btn_excluir_turma_Click);
            // 
            // btn_salvar_turma
            // 
            this.btn_salvar_turma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_turma.Location = new System.Drawing.Point(160, 18);
            this.btn_salvar_turma.Name = "btn_salvar_turma";
            this.btn_salvar_turma.Size = new System.Drawing.Size(138, 23);
            this.btn_salvar_turma.TabIndex = 1;
            this.btn_salvar_turma.Text = "Salvar Turma";
            this.btn_salvar_turma.UseVisualStyleBackColor = true;
            this.btn_salvar_turma.Click += new System.EventHandler(this.btn_salvar_turma_Click);
            // 
            // btn_nova_turma
            // 
            this.btn_nova_turma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nova_turma.Location = new System.Drawing.Point(16, 18);
            this.btn_nova_turma.Name = "btn_nova_turma";
            this.btn_nova_turma.Size = new System.Drawing.Size(138, 23);
            this.btn_nova_turma.TabIndex = 0;
            this.btn_nova_turma.Text = "Nova Turma";
            this.btn_nova_turma.UseVisualStyleBackColor = true;
            this.btn_nova_turma.Click += new System.EventHandler(this.btn_nova_turma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Máximo Alunos";
            // 
            // nd_maximo
            // 
            this.nd_maximo.Location = new System.Drawing.Point(473, 133);
            this.nd_maximo.Name = "nd_maximo";
            this.nd_maximo.Size = new System.Drawing.Size(120, 20);
            this.nd_maximo.TabIndex = 3;
            this.nd_maximo.ValueChanged += new System.EventHandler(this.nd_maximo_ValueChanged);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(16, 6);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(439, 433);
            this.dgv_turmas.TabIndex = 31;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Professor";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(610, 131);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 4;
            this.cb_status.TextChanged += new System.EventHandler(this.cb_status_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Horário";
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(473, 191);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(258, 21);
            this.cb_horario.TabIndex = 5;
            this.cb_horario.TextChanged += new System.EventHandler(this.cb_horario_TextChanged);
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(473, 73);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(258, 21);
            this.cb_professor.TabIndex = 2;
            this.cb_professor.TextChanged += new System.EventHandler(this.cb_professor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nome da Turma";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(473, 25);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(258, 20);
            this.tb_descricao.TabIndex = 1;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Vagas";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(473, 246);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(120, 20);
            this.tb_vagas.TabIndex = 44;
            this.tb_vagas.TabStop = false;
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 509);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nd_maximo);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nd_maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimir_turma;
        private System.Windows.Forms.Button btn_excluir_turma;
        private System.Windows.Forms.Button btn_salvar_turma;
        private System.Windows.Forms.Button btn_nova_turma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nd_maximo;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vagas;
    }
}