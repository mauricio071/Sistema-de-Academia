namespace Academia
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_id_horario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_descHorario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir_horario = new System.Windows.Forms.Button();
            this.btn_salvar_horario = new System.Windows.Forms.Button();
            this.btn_novo_horario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_id_horario
            // 
            this.tb_id_horario.Location = new System.Drawing.Point(16, 29);
            this.tb_id_horario.Name = "tb_id_horario";
            this.tb_id_horario.ReadOnly = true;
            this.tb_id_horario.Size = new System.Drawing.Size(64, 20);
            this.tb_id_horario.TabIndex = 0;
            this.tb_id_horario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário";
            // 
            // mtb_descHorario
            // 
            this.mtb_descHorario.Location = new System.Drawing.Point(93, 28);
            this.mtb_descHorario.Mask = "99:99 \\até 99:99";
            this.mtb_descHorario.Name = "mtb_descHorario";
            this.mtb_descHorario.Size = new System.Drawing.Size(100, 20);
            this.mtb_descHorario.TabIndex = 4;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(16, 65);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(439, 442);
            this.dgv_horarios.TabIndex = 5;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir_horario);
            this.panel1.Controls.Add(this.btn_salvar_horario);
            this.panel1.Controls.Add(this.btn_novo_horario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 59);
            this.panel1.TabIndex = 6;
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
            // btn_excluir_horario
            // 
            this.btn_excluir_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir_horario.Location = new System.Drawing.Point(238, 18);
            this.btn_excluir_horario.Name = "btn_excluir_horario";
            this.btn_excluir_horario.Size = new System.Drawing.Size(105, 23);
            this.btn_excluir_horario.TabIndex = 2;
            this.btn_excluir_horario.Text = "Excluir Horário";
            this.btn_excluir_horario.UseVisualStyleBackColor = true;
            this.btn_excluir_horario.Click += new System.EventHandler(this.btn_excluir_horario_Click);
            // 
            // btn_salvar_horario
            // 
            this.btn_salvar_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar_horario.Location = new System.Drawing.Point(127, 18);
            this.btn_salvar_horario.Name = "btn_salvar_horario";
            this.btn_salvar_horario.Size = new System.Drawing.Size(105, 23);
            this.btn_salvar_horario.TabIndex = 1;
            this.btn_salvar_horario.Text = "Salvar Horário";
            this.btn_salvar_horario.UseVisualStyleBackColor = true;
            this.btn_salvar_horario.Click += new System.EventHandler(this.btn_salvar_horario_Click);
            // 
            // btn_novo_horario
            // 
            this.btn_novo_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_horario.Location = new System.Drawing.Point(16, 18);
            this.btn_novo_horario.Name = "btn_novo_horario";
            this.btn_novo_horario.Size = new System.Drawing.Size(105, 23);
            this.btn_novo_horario.TabIndex = 0;
            this.btn_novo_horario.Text = "Novo Horário";
            this.btn_novo_horario.UseVisualStyleBackColor = true;
            this.btn_novo_horario.Click += new System.EventHandler(this.btn_novo_horario_Click);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.mtb_descHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id_horario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id_horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_descHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir_horario;
        private System.Windows.Forms.Button btn_salvar_horario;
        private System.Windows.Forms.Button btn_novo_horario;
    }
}