using BarbanteBandeirantes.Relatorio;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormReports : Form
    {
        MySqlConnection Conexao;
        private string conector = "server=mysql.ispac.com.br;port=3306;database=ispac33;uid=ispac33;password=isp7515";

        string IdMaterial;
        string IdFuncionario;
        int materialId;
        int funcionarioId;
        string funcionarioText;
        string materialText;

        public FormReports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dadosMaterial = new DataTable();

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
                            dadosMaterial.Load(comando.ExecuteReader());
                        }
                        catch (SqlException ex)
                        {
                            // Do some logging or something. 
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }
                    materialMovimento.DataSource = dadosMaterial;
                    materialMovimento.ValueMember = "Id";
                    materialMovimento.DisplayMember = "Descricao";
                }
                materialId = (int)materialMovimento.SelectedValue;
                materialMovimento.SelectedValue = -1;
                materialId = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable dadosFuncionario = new DataTable();
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
                            dadosFuncionario.Load(comando.ExecuteReader());
                        }
                        catch (SqlException ex)
                        {
                            // Do some logging or something. 
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }

                    funcionarioMovimento.DataSource = dadosFuncionario;
                    funcionarioMovimento.ValueMember = "Id";
                    funcionarioMovimento.DisplayMember = "Nome";
                }
                funcionarioId = (int)funcionarioMovimento.SelectedValue;
                funcionarioMovimento.SelectedValue = -1;
                funcionarioId = -1;
                //MessageBox.Show(funcionarioID.ValueMember);
                //MessageBox.Show(funcionarioID.DisplayMember);
                //MessageBox.Show(funcionarioId.ToString());


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void relatorio_movimento_Click(object sender, EventArgs e)
        {
            funcionarioText = this.funcionarioMovimento.GetItemText(funcionarioMovimento.SelectedItem);
            materialText = this.materialMovimento.GetItemText(materialMovimento.SelectedItem);

            //RelatorioFuncionarioMaterial teste = new RelatorioFuncionarioMaterial();
            ReportEquipamentoFuncionario teste = new ReportEquipamentoFuncionario();

            //Deixa o parametro escondido
            teste.Parameters["nomeParametro"].Visible = false;
            teste.Parameters["materialParametro"].Visible = false;
            teste.Parameters["parametroDataInicial"].Visible = false;
            teste.Parameters["parametroDataFinal"].Visible = false;

                //Passa o valor do parametro para o filtro
                //Define o parametro(que vai ser usado para fazer o filtro)
                teste.Parameters["nomeParametro"].Value = funcionarioText;

                teste.Parameters["materialParametro"].Value = materialText;

                teste.Parameters["parametroDataInicial"].Value = dataInicial.EditValue;
                teste.Parameters["parametroDataFinal"].Value = dataFinalOR.EditValue;
            
            teste.ShowRibbonPreviewDialog();
            teste.Dispose();
        }

        private void funcionarioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionarioId = (int)funcionarioMovimento.SelectedValue;
            //pega o valor do escrita no comboBox
            funcionarioText = this.funcionarioMovimento.GetItemText(funcionarioMovimento.SelectedItem);
        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialId = (int)materialMovimento.SelectedValue;
            materialText = this.materialMovimento.GetItemText(materialMovimento.SelectedItem);
        }

        private void limparMovimento_Click(object sender, EventArgs e)
        {
            //materialId = -1;
            //funcionarioId = -1;
            materialMovimento.SelectedIndex = -1;
            materialText = this.materialMovimento.GetItemText(materialMovimento.SelectedItem);
            funcionarioMovimento.SelectedIndex = -1;
            funcionarioText = this.funcionarioMovimento.GetItemText(funcionarioMovimento.SelectedItem);
            dataInicial.Clear();
            dataFinalOR.Clear(); 
        }
    }
    
}
