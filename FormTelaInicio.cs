using System;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormTelaInicio : Form
    {
        FormFuncionario cadastroFuncionario;
        FormEquipamento cadastroMaterial;
        FormFuncionarioMaterial sub6;
        FormReports sub1;
        FormReportsFuncionario reportsFuncionario;
        FormReportsMaterial reportsMaterial;

        public FormTelaInicio()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controlBox1_Click(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 150)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            } 
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 50)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void cadastro_Click(object sender, EventArgs e )
        { 
            menuTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 335)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void motou_Click(object sender, EventArgs e)
        {
            sub6 = new FormFuncionarioMaterial();
            sub6.FormClosed += Sub6_FormClosed;
            sub6.MdiParent = this;
            sub6.Dock = DockStyle.Fill;
            sub6.Show();
        }

        private void Sub6_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub6.FormClosed-= Sub6_FormClosed;
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            if (cadastroFuncionario == null)
            {
                cadastroFuncionario = new FormFuncionario();
                cadastroFuncionario.FormClosed += Sub2_FormClosed;
                cadastroFuncionario.MdiParent = this;
                cadastroFuncionario.Dock = DockStyle.Fill;
                cadastroFuncionario.Show();
            }
            else
            {
                cadastroFuncionario.Activate();
            }
        }

        private void Sub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            cadastroFuncionario.FormClosed -= Sub2_FormClosed;
        }

        private void materialBtn_Click(object sender, EventArgs e)
        {
            if (cadastroMaterial == null)
            {
                cadastroMaterial = new FormEquipamento();
                cadastroMaterial.FormClosed += Sub3_FormClosed;
                cadastroMaterial.MdiParent = this;
                cadastroMaterial.Dock = DockStyle.Fill;
                cadastroMaterial.Show();
            }
            else
            {
                cadastroMaterial.Activate();
            }
        }

        private void Sub3_FormClosed(object sender, FormClosedEventArgs e)
        {
            cadastroMaterial.FormClosed -= Sub3_FormClosed;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {
            menuReportTransition.Start();
        }

        bool menuReportExpand = false;
        private void menuReportTransition_Tick(object sender, EventArgs e)
        {
            if (menuReportExpand == false)
            {
                painelRelatorio.Height += 10;
                if (painelRelatorio.Height >= 200)
                {
                    menuReportTransition.Stop();
                    menuReportExpand = true;
                }
            }
            else
            {
                painelRelatorio.Height -= 10;
                if (painelRelatorio.Height <= 50)
                {
                    menuReportTransition.Stop();
                    menuReportExpand = false;
                }
            }
        }
        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1.FormClosed -= Sub1_FormClosed;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movimentoRelatorio_Click(object sender, EventArgs e)
        {
            
                sub1 = new FormReports();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();
            
        }

        private void equipamentoRelatorio_Click(object sender, EventArgs e)
        {
            reportsMaterial = new FormReportsMaterial();
            reportsMaterial.FormClosed += ReportsMaterial_FormClosed;
            reportsMaterial.MdiParent = this;
            reportsMaterial.Dock = DockStyle.Fill;
            reportsMaterial.Show();
        }

        private void ReportsMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportsMaterial.FormClosed -= ReportsMaterial_FormClosed;
        }

        private void funcionarioRelatorio_Click(object sender, EventArgs e)
        {
            reportsFuncionario = new FormReportsFuncionario();
            reportsFuncionario.FormClosed += ReportsFuncionario_FormClosed;
            reportsFuncionario.MdiParent = this;
            reportsFuncionario.Dock = DockStyle.Fill;
            reportsFuncionario.Show();
        }

        private void ReportsFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportsFuncionario.FormClosed -= ReportsFuncionario_FormClosed;
        }
    }
}
