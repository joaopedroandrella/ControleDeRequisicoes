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
using static DevExpress.Data.Mask.Internal.RegExMaskMath.CloudOfInts;

namespace BarbanteBandeirantes
{
    public partial class FormReportsFuncionario : Form
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

        public FormReportsFuncionario()
        {
            InitializeComponent();
        }

        private void FormReportsFuncionario_Load(object sender, EventArgs e)
        {
            DataTable dadosFuncionarioReport = new DataTable();
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();

                    string sql = "SELECT id, nome " +
                                 "FROM Funcionario ORDER BY Nome DESC";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        try
                        {
                            dadosFuncionarioReport.Load(comando.ExecuteReader());
                        }
                        catch (SqlException ex)
                        {
                            // Do some logging or something. 
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }

                    funcionarioReportBox.DataSource = dadosFuncionarioReport;
                    funcionarioReportBox.ValueMember = "Id";
                    funcionarioReportBox.DisplayMember = "Nome";
                }

                funcionarioReportId = (int)funcionarioReportBox.SelectedValue;
                funcionarioReportBox.SelectedValue = -1;
                funcionarioReportId = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            DataTable dadosFuncionarioCargoReport = new DataTable();
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();

                    string sql = "SELECT id, cargo " +
                                 "FROM Funcionario ORDER BY Nome DESC";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        try
                        {
                            dadosFuncionarioCargoReport.Load(comando.ExecuteReader());
                        }
                        catch (SqlException ex)
                        {
                            // Do some logging or something. 
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }
                    cargoReportBox.DataSource = dadosFuncionarioCargoReport;
                    cargoReportBox.ValueMember = "Id";
                    cargoReportBox.DisplayMember = "Cargo";
                }
                cargoReportId = (int)cargoReportBox.SelectedValue;
                cargoReportBox.SelectedValue = -1;
                cargoReportId = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void relatorio_funcionario_Click(object sender, EventArgs e)
        {
            funcionarioReportText = this.funcionarioReportBox.GetItemText(funcionarioReportBox.SelectedItem);
            cargoReportText = this.cargoReportBox.GetItemText(cargoReportBox.SelectedItem);
            //RelatorioFuncionario teste = new RelatorioFuncionario();
            ReportFuncionario testeFuncionario = new ReportFuncionario();

            testeFuncionario.Parameters["funcionarioParametro"].Visible = false;
            testeFuncionario.Parameters["cargoParametro"].Visible = false;

            testeFuncionario.Parameters["funcionarioParametro"].Value = funcionarioReportText;
            testeFuncionario.Parameters["cargoParametro"].Value = cargoReportText;

            testeFuncionario.ShowRibbonPreviewDialog();
            testeFuncionario.Dispose();
        }

        private void funcionarioReportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionarioReportId = (int)funcionarioReportBox.SelectedValue;
            //pega o valor do escrita no comboBox
            funcionarioReportText = this.funcionarioReportBox.GetItemText(funcionarioReportBox.SelectedItem);
        }

        private void funcionarioReportCargoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargoReportId = (int)cargoReportBox.SelectedValue;
            //pega o valor do escrita no comboBox
            cargoReportText = this.cargoReportBox.GetItemText(cargoReportBox.SelectedItem);
        }

        private void limparFuncionario_Click(object sender, EventArgs e)
        {
            funcionarioReportBox.SelectedIndex = -1;
            funcionarioReportText = this.funcionarioReportBox.GetItemText(funcionarioReportBox.SelectedItem);
            cargoReportBox.SelectedIndex = -1;
            cargoReportText = this.cargoReportBox.GetItemText(cargoReportBox.SelectedItem);
        }
    }
}
