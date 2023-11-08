namespace BarbanteBandeirantes
{
    partial class FormReportsMaterial
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
            this.materialReportBox = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.limparMaterial = new System.Windows.Forms.Button();
            this.relatorio_material = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // materialReportBox
            // 
            this.materialReportBox.FormattingEnabled = true;
            this.materialReportBox.Location = new System.Drawing.Point(365, 218);
            this.materialReportBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialReportBox.Name = "materialReportBox";
            this.materialReportBox.Size = new System.Drawing.Size(336, 24);
            this.materialReportBox.TabIndex = 18;
            this.materialReportBox.SelectionChangeCommitted += new System.EventHandler(this.materialReportBox_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(365, 181);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(133, 28);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Equipamento";
            // 
            // limparMaterial
            // 
            this.limparMaterial.Location = new System.Drawing.Point(365, 342);
            this.limparMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limparMaterial.Name = "limparMaterial";
            this.limparMaterial.Size = new System.Drawing.Size(337, 31);
            this.limparMaterial.TabIndex = 20;
            this.limparMaterial.Text = "Limpar";
            this.limparMaterial.UseVisualStyleBackColor = true;
            this.limparMaterial.Click += new System.EventHandler(this.limparMaterial_Click);
            // 
            // relatorio_material
            // 
            this.relatorio_material.Location = new System.Drawing.Point(365, 273);
            this.relatorio_material.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.relatorio_material.Name = "relatorio_material";
            this.relatorio_material.Size = new System.Drawing.Size(337, 62);
            this.relatorio_material.TabIndex = 19;
            this.relatorio_material.Text = "Gerar Relatorio de Equipamento";
            this.relatorio_material.UseVisualStyleBackColor = true;
            this.relatorio_material.Click += new System.EventHandler(this.relatorio_material_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(365, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 33);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Filtrar por:";
            // 
            // FormReportsMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.materialReportBox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.limparMaterial);
            this.Controls.Add(this.relatorio_material);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormReportsMaterial";
            this.Text = "FormReportsMaterial";
            this.Load += new System.EventHandler(this.FormReportsMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox materialReportBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button limparMaterial;
        private System.Windows.Forms.Button relatorio_material;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}