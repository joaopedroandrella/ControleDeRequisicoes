using BarbanteBandeirantes.Relatorio;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormReportsMaterial : Form
    {
        MySqlConnection Conexao;
        private string conector = "server=mysql.ispac.com.br;port=3306;database=ispac33;uid=ispac33;password=isp7515";

        string IdMaterial;
        string IdFuncionario;
        int materialId;
        int funcionarioId;
        int funcionarioReportId;
        int cargoReportId;
        int materialReportId;
        string funcionarioText;
        string materialText;
        string funcionarioReportText;
        string cargoReportText;
        string materialReportText;

        public FormReportsMaterial()
        {
            InitializeComponent();
        }

        private void FormReportsMaterial_Load(object sender, EventArgs e)
        {
            DataTable dadosMaterialReport = new DataTable();
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();

                    string sql = "SELECT id, descricao " +
                                 "FROM Material ORDER BY Descricao DESC";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        try
                        {
                            dadosMaterialReport.Load(comando.ExecuteReader());
                        }
                        catch (SqlException ex)
                        {
                            // Do some logging or something. 
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }
                    materialReportBox.DataSource = dadosMaterialReport;
                    materialReportBox.ValueMember = "Id";
                    materialReportBox.DisplayMember = "Descricao";
                }
                materialReportId = (int)materialReportBox.SelectedValue;
                materialReportBox.SelectedValue = -1;
                materialReportId = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void relatorio_material_Click(object sender, EventArgs e)
        {
            materialReportText = this.materialReportBox.GetItemText(materialReportBox.SelectedItem);
            //RelatorioMaterial teste = new RelatorioMaterial();
            ReportEquipamento testeMovimento = new ReportEquipamento();

            testeMovimento.Parameters["descricaoParametro"].Visible = false;

            testeMovimento.Parameters["descricaoParametro"].Value = materialReportText;

            testeMovimento.ShowRibbonPreviewDialog();
            testeMovimento.Dispose();
        }

        private void materialReportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialReportId = (int)materialReportBox.SelectedValue;
            materialReportText = this.materialReportBox.GetItemText(materialReportBox.SelectedItem);
        }

        private void limparMaterial_Click(object sender, EventArgs e)
        {
            materialReportBox.SelectedIndex = -1;
            materialReportText = this.materialReportBox.GetItemText(materialReportBox.SelectedItem);
        }
    }
}
