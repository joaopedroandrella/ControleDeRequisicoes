namespace BarbanteBandeirantes
{
    partial class FormFuncionarioMaterial
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
            this.quantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.materialID = new System.Windows.Forms.ComboBox();
            this.enviarbtn = new System.Windows.Forms.Button();
            this.observacaoEmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.limparbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.funcionarioListado = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textFiltrarFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioListado)).BeginInit();
            this.SuspendLayout();
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.Location = new System.Drawing.Point(589, 306);
            this.quantidadeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Size = new System.Drawing.Size(227, 22);
            this.quantidadeProduto.TabIndex = 67;
            // 
            // materialID
            // 
            this.materialID.FormattingEnabled = true;
            this.materialID.Location = new System.Drawing.Point(153, 305);
            this.materialID.Margin = new System.Windows.Forms.Padding(4);
            this.materialID.Name = "materialID";
            this.materialID.Size = new System.Drawing.Size(428, 24);
            this.materialID.TabIndex = 66;
            this.materialID.SelectionChangeCommitted += new System.EventHandler(this.materialID_SelectedIndexChanged);
            // 
            // enviarbtn
            // 
            this.enviarbtn.Location = new System.Drawing.Point(918, 450);
            this.enviarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.enviarbtn.Name = "enviarbtn";
            this.enviarbtn.Size = new System.Drawing.Size(200, 46);
            this.enviarbtn.TabIndex = 71;
            this.enviarbtn.Text = "Salvar";
            this.enviarbtn.UseVisualStyleBackColor = true;
            this.enviarbtn.Click += new System.EventHandler(this.enviarbtn_Click);
            // 
            // observacaoEmp
            // 
            this.observacaoEmp.Location = new System.Drawing.Point(153, 373);
            this.observacaoEmp.Margin = new System.Windows.Forms.Padding(4);
            this.observacaoEmp.Multiline = true;
            this.observacaoEmp.Name = "observacaoEmp";
            this.observacaoEmp.Size = new System.Drawing.Size(965, 70);
            this.observacaoEmp.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Observação:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(584, 277);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(820, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Equipamento:";
            // 
            // limparbtn
            // 
            this.limparbtn.Location = new System.Drawing.Point(918, 505);
            this.limparbtn.Margin = new System.Windows.Forms.Padding(4);
            this.limparbtn.Name = "limparbtn";
            this.limparbtn.Size = new System.Drawing.Size(200, 46);
            this.limparbtn.TabIndex = 72;
            this.limparbtn.Text = "Limpar Campos";
            this.limparbtn.UseVisualStyleBackColor = true;
            this.limparbtn.Click += new System.EventHandler(this.limparbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(824, 306);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 22);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // funcionarioListado
            // 
            this.funcionarioListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioListado.Location = new System.Drawing.Point(153, 99);
            this.funcionarioListado.Margin = new System.Windows.Forms.Padding(4);
            this.funcionarioListado.Name = "funcionarioListado";
            this.funcionarioListado.RowHeadersWidth = 51;
            this.funcionarioListado.Size = new System.Drawing.Size(720, 150);
            this.funcionarioListado.TabIndex = 74;
            this.funcionarioListado.SelectionChanged += new System.EventHandler(this.funcionario_Selecionado);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 76;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFiltrarFuncionario
            // 
            this.textFiltrarFuncionario.Location = new System.Drawing.Point(153, 64);
            this.textFiltrarFuncionario.Name = "textFiltrarFuncionario";
            this.textFiltrarFuncionario.Size = new System.Drawing.Size(551, 22);
            this.textFiltrarFuncionario.TabIndex = 1;
            this.textFiltrarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrarFuncionarioKeyPress);
            // 
            // FormFuncionarioMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 625);
            this.Controls.Add(this.textFiltrarFuncionario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.funcionarioListado);
            this.Controls.Add(this.limparbtn);
            this.Controls.Add(this.quantidadeProduto);
            this.Controls.Add(this.materialID);
            this.Controls.Add(this.enviarbtn);
            this.Controls.Add(this.observacaoEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFuncionarioMaterial";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown quantidadeProduto;
        private System.Windows.Forms.ComboBox materialID;
        private System.Windows.Forms.Button enviarbtn;
        private System.Windows.Forms.TextBox observacaoEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button limparbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView funcionarioListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textFiltrarFuncionario;
    }
}