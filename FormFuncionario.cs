using BarbanteBandeirantes.Relatorio;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormFuncionario : Form
    {
        MySqlConnection Conexao;
        private string conector = "Conexão";
        private int? id_Funcionario_Selecionado = null;

        public FormFuncionario()
        {
            InitializeComponent();

            listarFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            listarFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            listarFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listarFuncionario.MultiSelect = false;
            listarFuncionario.ReadOnly = true;

            listarFuncionario.ColumnHeadersVisible = true;
            listarFuncionario.RowHeadersVisible = false;
            listarFuncionario.AllowUserToAddRows = false;

            listarFuncionario.Columns.Add("Id", "Id");
            listarFuncionario.Columns.Add("Nome", "Nome");
            listarFuncionario.Columns.Add("Cargo", "Cargo");
            listarFuncionario.Columns.Add("CNPJ_CPF", "CPF");
            listarFuncionario.Columns.Add("BiometriaCadastrada", "Biometria Cadastrada");

            listarFuncionario.Columns["Id"].Visible = false;
            listarFuncionario.Columns["Nome"].Width = 170;
            listarFuncionario.Columns["Cargo"].Width = 170;
            listarFuncionario.Columns["CNPJ_CPF"].Width = 130;
            listarFuncionario.Columns["BiometriaCadastrada"].Width = 130;

            carregar_daddos();
        }

        private void cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string pesquisa = "%" + pesquisarFuncionario.Text + "%";

                    string sql = "SELECT * " +
                                 "FROM Funcionario " +
                                 "WHERE nome LIKE @nome";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", pesquisa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            listarFuncionario.Rows.Clear();
                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                };
                                listarFuncionario.Rows.Add(row);
                            };
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregar_daddos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM Funcionario ORDER BY id DESC ";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            listarFuncionario.Rows.Clear();
                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetString(5),
                                };
                                listarFuncionario.Rows.Add(row);
                                listarFuncionario.ClearSelection();
                            }
                        }
                    }
                    conexao.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection itensSelecionados = listarFuncionario.SelectedRows;
            foreach (DataGridViewRow linha in itensSelecionados)
            {
                id_Funcionario_Selecionado = Convert.ToInt32(linha.Cells[0].Value.ToString());
                nomeFuncionario.Text = linha.Cells[1].Value.ToString();
                cargoFuncionario.Text = linha.Cells[2].Value.ToString();
                cpfFuncionario.Text = linha.Cells[3].Value.ToString();
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(conector))
                    {
                        conexao.Open();

                        string checkRequisicoesSql = "DELETE FROM Funcionario WHERE Id = @id";
                        MySqlCommand checkRequisicoesCmd = new MySqlCommand(checkRequisicoesSql, conexao);
                        checkRequisicoesCmd.Parameters.AddWithValue("@id", id_Funcionario_Selecionado);
                        int numRequisicoes = Convert.ToInt32(checkRequisicoesCmd.ExecuteScalar());

                        if (numRequisicoes > 0)
                        {
                            MessageBox.Show("Este Funcionário está relacionado a Requisições de Equipamentos. Não é possível excluir.");
                        }
                        else
                        {
                            string deleteFuncionarioSql = "DELETE FROM Funcionario WHERE Id = @id";
                            MySqlCommand deleteFuncionarioCmd = new MySqlCommand(deleteFuncionarioSql, conexao);
                            deleteFuncionarioCmd.Parameters.AddWithValue("@id", id_Funcionario_Selecionado);
                            deleteFuncionarioCmd.ExecuteNonQuery();

                            MessageBox.Show("Funcionário excluído com sucesso");
                            carregar_daddos();
                            limparbtn_Click(this, new EventArgs());
                        }

                        conexao.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao excluir Funcionário: " + ex.Message);
                }
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            listarFuncionario.ClearSelection();
            id_Funcionario_Selecionado = null;
            nomeFuncionario.Clear();
            cargoFuncionario.Clear();
            cpfFuncionario.Clear();
        }

        private void limparbtn_Click(object sender, EventArgs e)
        {
            listarFuncionario.ClearSelection();
            id_Funcionario_Selecionado = null;
            nomeFuncionario.Clear();
            cargoFuncionario.Clear();
            cpfFuncionario.Clear();
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = nomeFuncionario.Text;
                string cargo = cargoFuncionario.Text;
                string cnpjcpf = cpfFuncionario.Text;
                string biometriaCadastrada = "Nao";

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    if (id_Funcionario_Selecionado == null)
                    {
                        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cnpjcpf))
                        {
                            MessageBox.Show("O Campo Nome e o CPF/CNPJ são campos obrigatórios. Preencha os valores corretamente.");
                        }
                        else
                        {
                            string sql = "INSERT INTO Funcionario (nome, cargo, cnpj_cpf, biometriaCadastrada) VALUE (@nome, @cargo, @cnpjcpf, @biometriaCadastrada)";
                            MySqlCommand comando = new MySqlCommand(sql, conexao);
                            comando.Parameters.AddWithValue("@nome", nome);
                            comando.Parameters.AddWithValue("@cargo", cargo);
                            comando.Parameters.AddWithValue("@cnpjcpf", cnpjcpf);
                            comando.Parameters.AddWithValue("@biometriaCadastrada", biometriaCadastrada);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Gravado com sucesso");
                        }
                    }
                    else
                    {
                        string sql = "UPDATE Funcionario SET nome=@nome, cargo=@cargo, cnpj_cpf=@cnpjcpf " +
                            "WHERE id=@id";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@id", id_Funcionario_Selecionado);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@cargo", cargo);
                        comando.Parameters.AddWithValue("@cnpjcpf", cnpjcpf);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Atualizado com sucesso");
                    }
                    carregar_daddos();
                    conexao.Close();
                    limparbtn_Click(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RelatorioFuncionario relatorio = new RelatorioFuncionario();
            ReportFuncionario relatorio = new ReportFuncionario();

            // Crie uma instância do visualizador de relatório DevExpress
            ReportPrintTool printTool = new ReportPrintTool(relatorio);

            // Abra o visualizador de relatórios para imprimir
            printTool.ShowRibbonPreviewDialog();
        }
    }
}
