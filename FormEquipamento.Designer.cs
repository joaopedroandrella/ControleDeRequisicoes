namespace BarbanteBandeirantes
{
    partial class FormEquipamento
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
            this.descricaoMaterial = new System.Windows.Forms.TextBox();
            this.observacaoMaterial = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gravarMaterial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pesquisarMaterial = new System.Windows.Forms.TextBox();
            this.listarMaterial = new System.Windows.Forms.DataGridView();
            this.deletarbtn = new System.Windows.Forms.Button();
            this.limparbtn = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listarMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoMaterial
            // 
            this.descricaoMaterial.Location = new System.Drawing.Point(73, 54);
            this.descricaoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoMaterial.Name = "descricaoMaterial";
            this.descricaoMaterial.Size = new System.Drawing.Size(423, 22);
            this.descricaoMaterial.TabIndex = 1;
            // 
            // observacaoMaterial
            // 
            this.observacaoMaterial.Location = new System.Drawing.Point(73, 104);
            this.observacaoMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.observacaoMaterial.Name = "observacaoMaterial";
            this.observacaoMaterial.Size = new System.Drawing.Size(423, 22);
            this.observacaoMaterial.TabIndex = 2;
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(69, 30);
            this.descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(86, 20);
            this.descricao.TabIndex = 6;
            this.descricao.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Observação";
            // 
            // gravarMaterial
            // 
            this.gravarMaterial.Location = new System.Drawing.Point(73, 134);
            this.gravarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gravarMaterial.Name = "gravarMaterial";
            this.gravarMaterial.Size = new System.Drawing.Size(423, 42);
            this.gravarMaterial.TabIndex = 8;
            this.gravarMaterial.Text = "Salvar/Atualizar";
            this.gravarMaterial.UseVisualStyleBackColor = true;
            this.gravarMaterial.Click += new System.EventHandler(this.gravarMaterial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pesquisar";
            // 
            // pesquisarMaterial
            // 
            this.pesquisarMaterial.Location = new System.Drawing.Point(506, 54);
            this.pesquisarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisarMaterial.Name = "pesquisarMaterial";
            this.pesquisarMaterial.Size = new System.Drawing.Size(567, 22);
            this.pesquisarMaterial.TabIndex = 14;
            this.pesquisarMaterial.TextChanged += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // listarMaterial
            // 
            this.listarMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarMaterial.Location = new System.Drawing.Point(506, 94);
            this.listarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.listarMaterial.Name = "listarMaterial";
            this.listarMaterial.RowHeadersWidth = 51;
            this.listarMaterial.Size = new System.Drawing.Size(722, 283);
            this.listarMaterial.TabIndex = 13;
            this.listarMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listarMaterial_CellContentClick);
            this.listarMaterial.SelectionChanged += new System.EventHandler(this.listarMaterial_SelectionChanged);
            // 
            // deletarbtn
            // 
            this.deletarbtn.Location = new System.Drawing.Point(73, 234);
            this.deletarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletarbtn.Name = "deletarbtn";
            this.deletarbtn.Size = new System.Drawing.Size(423, 42);
            this.deletarbtn.TabIndex = 17;
            this.deletarbtn.Text = "Deletar";
            this.deletarbtn.UseVisualStyleBackColor = true;
            this.deletarbtn.Click += new System.EventHandler(this.deletarbtn_Click);
            // 
            // limparbtn
            // 
            this.limparbtn.Location = new System.Drawing.Point(73, 184);
            this.limparbtn.Margin = new System.Windows.Forms.Padding(4);
            this.limparbtn.Name = "limparbtn";
            this.limparbtn.Size = new System.Drawing.Size(423, 42);
            this.limparbtn.TabIndex = 18;
            this.limparbtn.Text = "Limpar Campos";
            this.limparbtn.UseVisualStyleBackColor = true;
            this.limparbtn.Click += new System.EventHandler(this.limparbtn_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(1081, 54);
            this.btnPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(147, 25);
            this.btnPesquisarFuncionario.TabIndex = 19;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click_1);
            // 
            // FormMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 763);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.limparbtn);
            this.Controls.Add(this.deletarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pesquisarMaterial);
            this.Controls.Add(this.listarMaterial);
            this.Controls.Add(this.gravarMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.observacaoMaterial);
            this.Controls.Add(this.descricaoMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMaterial";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.FormMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descricaoMaterial;
        private System.Windows.Forms.TextBox observacaoMaterial;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gravarMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pesquisarMaterial;
        private System.Windows.Forms.DataGridView listarMaterial;
        private System.Windows.Forms.Button deletarbtn;
        private System.Windows.Forms.Button limparbtn;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
    }
}