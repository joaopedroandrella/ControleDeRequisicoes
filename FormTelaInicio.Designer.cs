using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    partial class FormTelaInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.funcionarioBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.motou = new System.Windows.Forms.Button();
            this.painelRelatorio = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.report = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.movimentoRelatorio = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.funcionarioRelatorio = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.equipamentoRelatorio = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.menuReportTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.painelRelatorio.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.White;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(4, 4);
            this.btnHam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(49, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 2;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.painelRelatorio);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 37);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(447, 713);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Location = new System.Drawing.Point(0, 37);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(447, 62);
            this.menuContainer.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.cadastro);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 62);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cadastro.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.cadastro.ForeColor = System.Drawing.Color.White;
            this.cadastro.Image = ((System.Drawing.Image)(resources.GetObject("cadastro.Image")));
            this.cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastro.Location = new System.Drawing.Point(-8, -6);
            this.cadastro.Margin = new System.Windows.Forms.Padding(0);
            this.cadastro.Name = "cadastro";
            this.cadastro.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cadastro.Size = new System.Drawing.Size(467, 78);
            this.cadastro.TabIndex = 3;
            this.cadastro.Text = "       Cadastro";
            this.cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.funcionarioBtn);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 62);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // funcionarioBtn
            // 
            this.funcionarioBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.funcionarioBtn.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.funcionarioBtn.ForeColor = System.Drawing.Color.White;
            this.funcionarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBtn.Image")));
            this.funcionarioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionarioBtn.Location = new System.Drawing.Point(-5, -11);
            this.funcionarioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.funcionarioBtn.Name = "funcionarioBtn";
            this.funcionarioBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.funcionarioBtn.Size = new System.Drawing.Size(463, 81);
            this.funcionarioBtn.TabIndex = 3;
            this.funcionarioBtn.Text = "    Funcionario";
            this.funcionarioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionarioBtn.UseVisualStyleBackColor = false;
            this.funcionarioBtn.Click += new System.EventHandler(this.funcionarioBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.materialBtn);
            this.panel5.Location = new System.Drawing.Point(0, 124);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 62);
            this.panel5.TabIndex = 4;
            // 
            // materialBtn
            // 
            this.materialBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.materialBtn.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.materialBtn.ForeColor = System.Drawing.Color.White;
            this.materialBtn.Image = ((System.Drawing.Image)(resources.GetObject("materialBtn.Image")));
            this.materialBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialBtn.Location = new System.Drawing.Point(-5, -5);
            this.materialBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialBtn.Name = "materialBtn";
            this.materialBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.materialBtn.Size = new System.Drawing.Size(464, 71);
            this.materialBtn.TabIndex = 3;
            this.materialBtn.Text = "    Equipamento";
            this.materialBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialBtn.UseVisualStyleBackColor = false;
            this.materialBtn.Click += new System.EventHandler(this.materialBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.motou);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 57);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // motou
            // 
            this.motou.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.motou.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.motou.ForeColor = System.Drawing.Color.White;
            this.motou.Image = ((System.Drawing.Image)(resources.GetObject("motou.Image")));
            this.motou.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motou.Location = new System.Drawing.Point(-8, -6);
            this.motou.Margin = new System.Windows.Forms.Padding(0);
            this.motou.Name = "motou";
            this.motou.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.motou.Size = new System.Drawing.Size(467, 69);
            this.motou.TabIndex = 3;
            this.motou.Text = "      Requisição de Equipamento";
            this.motou.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motou.UseVisualStyleBackColor = false;
            this.motou.Click += new System.EventHandler(this.motou_Click);
            // 
            // painelRelatorio
            // 
            this.painelRelatorio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelRelatorio.Controls.Add(this.panel7);
            this.painelRelatorio.Controls.Add(this.panel10);
            this.painelRelatorio.Controls.Add(this.panel8);
            this.painelRelatorio.Controls.Add(this.panel9);
            this.painelRelatorio.Location = new System.Drawing.Point(0, 156);
            this.painelRelatorio.Margin = new System.Windows.Forms.Padding(0);
            this.painelRelatorio.Name = "painelRelatorio";
            this.painelRelatorio.Size = new System.Drawing.Size(447, 53);
            this.painelRelatorio.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Controls.Add(this.report);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 62);
            this.panel7.TabIndex = 6;
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.report.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Image = ((System.Drawing.Image)(resources.GetObject("report.Image")));
            this.report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report.Location = new System.Drawing.Point(-5, -5);
            this.report.Margin = new System.Windows.Forms.Padding(0);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.report.Size = new System.Drawing.Size(463, 73);
            this.report.TabIndex = 5;
            this.report.Text = "       Relatórios";
            this.report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SkyBlue;
            this.panel10.Controls.Add(this.movimentoRelatorio);
            this.panel10.Location = new System.Drawing.Point(0, 62);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(461, 62);
            this.panel10.TabIndex = 5;
            // 
            // movimentoRelatorio
            // 
            this.movimentoRelatorio.BackColor = System.Drawing.Color.SkyBlue;
            this.movimentoRelatorio.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.movimentoRelatorio.ForeColor = System.Drawing.Color.White;
            this.movimentoRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("movimentoRelatorio.Image")));
            this.movimentoRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimentoRelatorio.Location = new System.Drawing.Point(-5, -5);
            this.movimentoRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movimentoRelatorio.Name = "movimentoRelatorio";
            this.movimentoRelatorio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.movimentoRelatorio.Size = new System.Drawing.Size(463, 71);
            this.movimentoRelatorio.TabIndex = 3;
            this.movimentoRelatorio.Text = "    Requisições";
            this.movimentoRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimentoRelatorio.UseVisualStyleBackColor = false;
            this.movimentoRelatorio.Click += new System.EventHandler(this.movimentoRelatorio_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel8.Controls.Add(this.funcionarioRelatorio);
            this.panel8.Location = new System.Drawing.Point(0, 124);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(457, 62);
            this.panel8.TabIndex = 2;
            // 
            // funcionarioRelatorio
            // 
            this.funcionarioRelatorio.BackColor = System.Drawing.Color.SkyBlue;
            this.funcionarioRelatorio.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.funcionarioRelatorio.ForeColor = System.Drawing.Color.White;
            this.funcionarioRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioRelatorio.Image")));
            this.funcionarioRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionarioRelatorio.Location = new System.Drawing.Point(-5, -11);
            this.funcionarioRelatorio.Margin = new System.Windows.Forms.Padding(0);
            this.funcionarioRelatorio.Name = "funcionarioRelatorio";
            this.funcionarioRelatorio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.funcionarioRelatorio.Size = new System.Drawing.Size(467, 81);
            this.funcionarioRelatorio.TabIndex = 3;
            this.funcionarioRelatorio.Text = "    Funcionario";
            this.funcionarioRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionarioRelatorio.UseVisualStyleBackColor = false;
            this.funcionarioRelatorio.Click += new System.EventHandler(this.funcionarioRelatorio_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SkyBlue;
            this.panel9.Controls.Add(this.equipamentoRelatorio);
            this.panel9.Location = new System.Drawing.Point(0, 186);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(461, 62);
            this.panel9.TabIndex = 4;
            // 
            // equipamentoRelatorio
            // 
            this.equipamentoRelatorio.BackColor = System.Drawing.Color.SkyBlue;
            this.equipamentoRelatorio.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.equipamentoRelatorio.ForeColor = System.Drawing.Color.White;
            this.equipamentoRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("equipamentoRelatorio.Image")));
            this.equipamentoRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipamentoRelatorio.Location = new System.Drawing.Point(-5, -5);
            this.equipamentoRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equipamentoRelatorio.Name = "equipamentoRelatorio";
            this.equipamentoRelatorio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.equipamentoRelatorio.Size = new System.Drawing.Size(467, 71);
            this.equipamentoRelatorio.TabIndex = 3;
            this.equipamentoRelatorio.Text = "    Equipamento";
            this.equipamentoRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipamentoRelatorio.UseVisualStyleBackColor = false;
            this.equipamentoRelatorio.Click += new System.EventHandler(this.equipamentoRelatorio_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // menuReportTransition
            // 
            this.menuReportTransition.Interval = 10;
            this.menuReportTransition.Tick += new System.EventHandler(this.menuReportTransition_Tick);
            // 
            // FormTelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTelaInicio";
            this.Text = "Requisição de Equipamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.painelRelatorio.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button funcionarioBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button materialBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button motou;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button report;
        private FlowLayoutPanel painelRelatorio;
        private Panel panel8;
        private Button funcionarioRelatorio;
        private Panel panel9;
        private Button equipamentoRelatorio;
        private Panel panel10;
        private Button movimentoRelatorio;
        private Timer menuReportTransition;
    }
}

