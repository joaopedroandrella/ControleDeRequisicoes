namespace BarbanteBandeirantes
{
    partial class FormReports
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
            this.dataInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.relatorio_movimento = new System.Windows.Forms.Button();
            this.limparMovimento = new System.Windows.Forms.Button();
            this.materialMovimento = new System.Windows.Forms.ComboBox();
            this.funcionarioMovimento = new System.Windows.Forms.ComboBox();
            this.dataFinalOR = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalOR.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInicial
            // 
            this.dataInicial.EditValue = null;
            this.dataInicial.Location = new System.Drawing.Point(353, 335);
            this.dataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataInicial.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataInicial.Size = new System.Drawing.Size(155, 22);
            this.dataInicial.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(353, 136);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 24);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Funcionario";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(353, 217);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 24);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Material";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(355, 298);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Datas";
            // 
            // relatorio_movimento
            // 
            this.relatorio_movimento.Location = new System.Drawing.Point(355, 384);
            this.relatorio_movimento.Margin = new System.Windows.Forms.Padding(4);
            this.relatorio_movimento.Name = "relatorio_movimento";
            this.relatorio_movimento.Size = new System.Drawing.Size(337, 62);
            this.relatorio_movimento.TabIndex = 6;
            this.relatorio_movimento.Text = "Gerar Relatorio de Requisições";
            this.relatorio_movimento.UseVisualStyleBackColor = true;
            this.relatorio_movimento.Click += new System.EventHandler(this.relatorio_movimento_Click);
            // 
            // limparMovimento
            // 
            this.limparMovimento.Location = new System.Drawing.Point(355, 453);
            this.limparMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.limparMovimento.Name = "limparMovimento";
            this.limparMovimento.Size = new System.Drawing.Size(337, 31);
            this.limparMovimento.TabIndex = 7;
            this.limparMovimento.Text = "Limpar";
            this.limparMovimento.UseVisualStyleBackColor = true;
            this.limparMovimento.Click += new System.EventHandler(this.limparMovimento_Click);
            // 
            // materialMovimento
            // 
            this.materialMovimento.FormattingEnabled = true;
            this.materialMovimento.Location = new System.Drawing.Point(355, 254);
            this.materialMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.materialMovimento.Name = "materialMovimento";
            this.materialMovimento.Size = new System.Drawing.Size(336, 24);
            this.materialMovimento.TabIndex = 3;
            this.materialMovimento.SelectionChangeCommitted += new System.EventHandler(this.materialBox_SelectedIndexChanged);
            // 
            // funcionarioMovimento
            // 
            this.funcionarioMovimento.FormattingEnabled = true;
            this.funcionarioMovimento.Location = new System.Drawing.Point(355, 169);
            this.funcionarioMovimento.Margin = new System.Windows.Forms.Padding(4);
            this.funcionarioMovimento.Name = "funcionarioMovimento";
            this.funcionarioMovimento.Size = new System.Drawing.Size(336, 24);
            this.funcionarioMovimento.TabIndex = 2;
            this.funcionarioMovimento.SelectionChangeCommitted += new System.EventHandler(this.funcionarioBox_SelectedIndexChanged);
            // 
            // dataFinalOR
            // 
            this.dataFinalOR.EditValue = null;
            this.dataFinalOR.Location = new System.Drawing.Point(517, 335);
            this.dataFinalOR.Margin = new System.Windows.Forms.Padding(4);
            this.dataFinalOR.Name = "dataFinalOR";
            this.dataFinalOR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataFinalOR.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.dataFinalOR.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataFinalOR.Size = new System.Drawing.Size(155, 22);
            this.dataFinalOR.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(353, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 33);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Filtrar por:";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 715);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dataFinalOR);
            this.Controls.Add(this.funcionarioMovimento);
            this.Controls.Add(this.materialMovimento);
            this.Controls.Add(this.limparMovimento);
            this.Controls.Add(this.relatorio_movimento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReports";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalOR.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFinalOR.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button relatorio_movimento;
        private System.Windows.Forms.Button limparMovimento;
        private System.Windows.Forms.ComboBox materialMovimento;
        private System.Windows.Forms.ComboBox funcionarioMovimento;
        private DevExpress.XtraEditors.DateEdit dataFinalOR;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}