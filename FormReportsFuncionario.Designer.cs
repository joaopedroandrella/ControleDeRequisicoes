namespace BarbanteBandeirantes
{
    partial class FormReportsFuncionario
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
            this.funcionarioReportBox = new System.Windows.Forms.ComboBox();
            this.cargoReportBox = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.limparFuncionario = new System.Windows.Forms.Button();
            this.relatorio_funcionario = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // funcionarioReportBox
            // 
            this.funcionarioReportBox.FormattingEnabled = true;
            this.funcionarioReportBox.Location = new System.Drawing.Point(365, 181);
            this.funcionarioReportBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.funcionarioReportBox.Name = "funcionarioReportBox";
            this.funcionarioReportBox.Size = new System.Drawing.Size(336, 24);
            this.funcionarioReportBox.TabIndex = 16;
            this.funcionarioReportBox.SelectionChangeCommitted += new System.EventHandler(this.funcionarioReportBox_SelectedIndexChanged);
            // 
            // cargoReportBox
            // 
            this.cargoReportBox.FormattingEnabled = true;
            this.cargoReportBox.Location = new System.Drawing.Point(365, 256);
            this.cargoReportBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cargoReportBox.Name = "cargoReportBox";
            this.cargoReportBox.Size = new System.Drawing.Size(336, 24);
            this.cargoReportBox.TabIndex = 17;
            this.cargoReportBox.SelectionChangeCommitted += new System.EventHandler(this.funcionarioReportCargoBox_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(365, 219);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 28);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Cargo";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(365, 144);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 28);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Funcionario";
            // 
            // limparFuncionario
            // 
            this.limparFuncionario.Location = new System.Drawing.Point(365, 380);
            this.limparFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limparFuncionario.Name = "limparFuncionario";
            this.limparFuncionario.Size = new System.Drawing.Size(337, 31);
            this.limparFuncionario.TabIndex = 19;
            this.limparFuncionario.Text = "Limpar";
            this.limparFuncionario.UseVisualStyleBackColor = true;
            this.limparFuncionario.Click += new System.EventHandler(this.limparFuncionario_Click);
            // 
            // relatorio_funcionario
            // 
            this.relatorio_funcionario.Location = new System.Drawing.Point(365, 311);
            this.relatorio_funcionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relatorio_funcionario.Name = "relatorio_funcionario";
            this.relatorio_funcionario.Size = new System.Drawing.Size(337, 62);
            this.relatorio_funcionario.TabIndex = 18;
            this.relatorio_funcionario.Text = "Gerar Relatorio de Funcionário";
            this.relatorio_funcionario.UseVisualStyleBackColor = true;
            this.relatorio_funcionario.Click += new System.EventHandler(this.relatorio_funcionario_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(365, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 33);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Filtrar por:";
            // 
            // FormReportsFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.funcionarioReportBox);
            this.Controls.Add(this.cargoReportBox);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.limparFuncionario);
            this.Controls.Add(this.relatorio_funcionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReportsFuncionario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormReportsFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionarioReportBox;
        private System.Windows.Forms.ComboBox cargoReportBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button limparFuncionario;
        private System.Windows.Forms.Button relatorio_funcionario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}