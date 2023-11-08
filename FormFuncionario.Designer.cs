namespace BarbanteBandeirantes
{
    partial class FormFuncionario
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
            this.nomeFuncionario = new System.Windows.Forms.TextBox();
            this.cargoFuncionario = new System.Windows.Forms.TextBox();
            this.cpfFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gravarbtn = new System.Windows.Forms.Button();
            this.listarFuncionario = new System.Windows.Forms.DataGridView();
            this.pesquisarFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deletar = new System.Windows.Forms.Button();
            this.limparbtn = new System.Windows.Forms.Button();
            this.gravar_digital = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.listarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Location = new System.Drawing.Point(13, 54);
            this.nomeFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.Size = new System.Drawing.Size(519, 22);
            this.nomeFuncionario.TabIndex = 1;
            // 
            // cargoFuncionario
            // 
            this.cargoFuncionario.Location = new System.Drawing.Point(13, 103);
            this.cargoFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cargoFuncionario.Name = "cargoFuncionario";
            this.cargoFuncionario.Size = new System.Drawing.Size(519, 22);
            this.cargoFuncionario.TabIndex = 2;
            // 
            // cpfFuncionario
            // 
            this.cpfFuncionario.Location = new System.Drawing.Point(13, 154);
            this.cpfFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cpfFuncionario.Name = "cpfFuncionario";
            this.cpfFuncionario.Size = new System.Drawing.Size(519, 22);
            this.cpfFuncionario.TabIndex = 3;
            this.cpfFuncionario.TextChanged += new System.EventHandler(this.cpf_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF/CNPJ";
            // 
            // gravarbtn
            // 
            this.gravarbtn.Location = new System.Drawing.Point(13, 185);
            this.gravarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.gravarbtn.Name = "gravarbtn";
            this.gravarbtn.Size = new System.Drawing.Size(523, 46);
            this.gravarbtn.TabIndex = 8;
            this.gravarbtn.Text = "Gravar/Atualizar";
            this.gravarbtn.UseVisualStyleBackColor = true;
            this.gravarbtn.Click += new System.EventHandler(this.gravar_Click);
            // 
            // listarFuncionario
            // 
            this.listarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listarFuncionario.Location = new System.Drawing.Point(557, 92);
            this.listarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.listarFuncionario.Name = "listarFuncionario";
            this.listarFuncionario.RowHeadersWidth = 51;
            this.listarFuncionario.Size = new System.Drawing.Size(806, 316);
            this.listarFuncionario.TabIndex = 9;
            this.listarFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listarFuncionario_CellContentClick);
            this.listarFuncionario.SelectionChanged += new System.EventHandler(this.listarFuncionario_SelectionChanged);
            // 
            // pesquisarFuncionario
            // 
            this.pesquisarFuncionario.Location = new System.Drawing.Point(557, 53);
            this.pesquisarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.pesquisarFuncionario.Name = "pesquisarFuncionario";
            this.pesquisarFuncionario.Size = new System.Drawing.Size(607, 22);
            this.pesquisarFuncionario.TabIndex = 10;
            this.pesquisarFuncionario.TextChanged += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(1172, 54);
            this.btnPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(191, 25);
            this.btnPesquisarFuncionario.TabIndex = 11;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pesquisar";
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(13, 288);
            this.deletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(519, 46);
            this.deletar.TabIndex = 13;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // limparbtn
            // 
            this.limparbtn.Location = new System.Drawing.Point(13, 238);
            this.limparbtn.Margin = new System.Windows.Forms.Padding(4);
            this.limparbtn.Name = "limparbtn";
            this.limparbtn.Size = new System.Drawing.Size(519, 46);
            this.limparbtn.TabIndex = 15;
            this.limparbtn.Text = "Limpar Campos";
            this.limparbtn.UseVisualStyleBackColor = true;
            this.limparbtn.Click += new System.EventHandler(this.limparbtn_Click);
            // 
            // gravar_digital
            // 
            this.gravar_digital.Location = new System.Drawing.Point(13, 361);
            this.gravar_digital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gravar_digital.Name = "gravar_digital";
            this.gravar_digital.Size = new System.Drawing.Size(520, 47);
            this.gravar_digital.TabIndex = 16;
            this.gravar_digital.Text = "Cadastrar Digital";
            this.gravar_digital.UseVisualStyleBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 340);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(436, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Obs: Funcionário já deve estar Cadastrado, e Deve Ser Selecionado";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 763);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gravar_digital);
            this.Controls.Add(this.limparbtn);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.pesquisarFuncionario);
            this.Controls.Add(this.listarFuncionario);
            this.Controls.Add(this.gravarbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpfFuncionario);
            this.Controls.Add(this.cargoFuncionario);
            this.Controls.Add(this.nomeFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFuncionario";
            this.Text = "Cadastro Funcionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeFuncionario;
        private System.Windows.Forms.TextBox cargoFuncionario;
        private System.Windows.Forms.TextBox cpfFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gravarbtn;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView listarFuncionario;
        private System.Windows.Forms.TextBox pesquisarFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button limparbtn;
        private System.Windows.Forms.Button gravar_digital;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}