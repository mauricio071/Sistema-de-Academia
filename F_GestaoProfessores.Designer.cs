namespace Academia
{
    partial class F_GestaoProfessores
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
            this.btn_excluir_professor = new System.Windows.Forms.Button();
            this.btn_salvar_professor = new System.Windows.Forms.Button();
            this.btn_novo_professor = new System.Windows.Forms.Button();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id_professor = new System.Windows.Forms.TextBox();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir_professor);
            this.panel1.Controls.Add(this.btn_salvar_professor);
            this.panel1.Controls.Add(this.btn_novo_professor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 59);
            this.panel1.TabIndex = 18;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(349, 18);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(106, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir_professor
            // 
            this.btn_excluir_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_professor.Location = new System.Drawing.Point(238, 18);
            this.btn_excluir_professor.Name = "btn_excluir_professor";
            this.btn_excluir_professor.Size = new System.Drawing.Size(105, 23);
            this.btn_excluir_professor.TabIndex = 2;
            this.btn_excluir_professor.Text = "Excluir";
            this.btn_excluir_professor.UseVisualStyleBackColor = true;
            this.btn_excluir_professor.Click += new System.EventHandler(this.btn_excluir_professor_Click);
            // 
            // btn_salvar_professor
            // 
            this.btn_salvar_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_professor.Location = new System.Drawing.Point(127, 18);
            this.btn_salvar_professor.Name = "btn_salvar_professor";
            this.btn_salvar_professor.Size = new System.Drawing.Size(105, 23);
            this.btn_salvar_professor.TabIndex = 1;
            this.btn_salvar_professor.Text = "Salvar";
            this.btn_salvar_professor.UseVisualStyleBackColor = true;
            this.btn_salvar_professor.Click += new System.EventHandler(this.btn_salvar_professor_Click);
            // 
            // btn_novo_professor
            // 
            this.btn_novo_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_professor.Location = new System.Drawing.Point(16, 18);
            this.btn_novo_professor.Name = "btn_novo_professor";
            this.btn_novo_professor.Size = new System.Drawing.Size(105, 23);
            this.btn_novo_professor.TabIndex = 0;
            this.btn_novo_professor.Text = "Novo Professor";
            this.btn_novo_professor.UseVisualStyleBackColor = true;
            this.btn_novo_professor.Click += new System.EventHandler(this.btn_novo_professor_Click);
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(16, 66);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(439, 442);
            this.dgv_professores.TabIndex = 17;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(342, 25);
            this.mtb_telefone.Mask = "(00) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(113, 20);
            this.mtb_telefone.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // tb_id_professor
            // 
            this.tb_id_professor.Location = new System.Drawing.Point(16, 25);
            this.tb_id_professor.Name = "tb_id_professor";
            this.tb_id_professor.ReadOnly = true;
            this.tb_id_professor.Size = new System.Drawing.Size(64, 20);
            this.tb_id_professor.TabIndex = 13;
            this.tb_id_professor.TabStop = false;
            // 
            // tb_professor
            // 
            this.tb_professor.Location = new System.Drawing.Point(98, 24);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(224, 20);
            this.tb_professor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Professor";
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id_professor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir_professor;
        private System.Windows.Forms.Button btn_salvar_professor;
        private System.Windows.Forms.Button btn_novo_professor;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id_professor;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.Label label3;
    }
}