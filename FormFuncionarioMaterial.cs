using MySql.Data.MySqlClient;
using NITGEN.SDK.NBioBSP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormFuncionarioMaterial : Form
    {
        MySqlConnection Conexao;
        private string conector = "Conexão";

        int materialId;
        int funcionarioId;

        public FormFuncionarioMaterial()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LimparFormulario();
            textFiltrarFuncionario.Focus();

            funcionarioListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            funcionarioListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            funcionarioListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            funcionarioListado.MultiSelect = false;
            funcionarioListado.ReadOnly = true;

            funcionarioListado.ColumnHeadersVisible = true;
            funcionarioListado.RowHeadersVisible = false;
            funcionarioListado.AllowUserToAddRows = false;

            funcionarioListado.Columns.Add("Id", "Id");
            funcionarioListado.Columns.Add("Nome", "Nome");
            funcionarioListado.Columns.Add("Cargo", "Cargo");
            funcionarioListado.Columns.Add("CNPJ_CPF", "CPF");

            funcionarioListado.Columns["Id"].Visible = false;
            funcionarioListado.Columns["Nome"].Width = 200;
            funcionarioListado.Columns["Cargo"].Width = 170;
            funcionarioListado.Columns["CNPJ_CPF"].Width = 165;
        }

        public void LimparFormulario()
        {
            funcionarioListado.DataSource = null;
            funcionarioListado.Rows.Clear();
            materialID.SelectedIndex = -1;
        }

        private void materialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialId = (int)materialID.SelectedValue;
        }

        private void Form6_Load(object sender, EventArgs e)
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
                            MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
                        }
                    }

                    materialID.DataSource = dadosMaterial;
                    materialID.ValueMember = "Id";
                    materialID.DisplayMember = "Descricao";
                }
                materialId = (int)materialID.SelectedValue;
                materialID.SelectedValue = -1;
                materialId = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enviarbtn_Click(object sender, EventArgs e)
        {
            if (funcionarioId != 0)
            {
                if (materialId != -1)
                {
                    using (MySqlConnection conexao = new MySqlConnection(conector))
                    {
                        string qtde = quantidadeProduto.Text;
                        string observacao = observacaoEmp.Text;
                        string data = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                        conexao.Open();
                        string sql = "INSERT INTO Funcionario_Material (funcionarioId, materialId, data, qtde, observacao) VALUES (@funcionarioId, @materialId, @data, @qtde, @observacao)";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                        comando.Parameters.AddWithValue("@materialId", materialId);
                        comando.Parameters.AddWithValue("@qtde", qtde);
                        comando.Parameters.AddWithValue("@observacao", observacao);
                        comando.Parameters.AddWithValue("@data", data);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Gravado com sucesso");
                        conexao.Close();
                        limparbtn_Click(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show("Material não Localizado.");
                }

            }
            else
            {
                MessageBox.Show("Funcionario não Localizado.");
            }
        }

        private void limparbtn_Click(object sender, EventArgs e)
        {
            materialID.SelectedValue = -1;
            textFiltrarFuncionario.Text = string.Empty;
            materialId = -1;
            quantidadeProduto.Value = 0;
            observacaoEmp.Clear();
            funcionarioListado.Rows.Clear();
            funcionarioId = 0;
        }

        private DataTable GetUsers()
        {
            using (MySqlConnection conexao = new MySqlConnection(conector))
            {

                try
                {
                    conexao.Open();
                    string sql = "SELECT * FROM Funcionario";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter usuários: " + ex.Message);
                    throw;
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarFiltragem();
        }

        private void funcionario_Selecionado(object sender, EventArgs e)
        {
            if (funcionarioListado.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = funcionarioListado.SelectedRows[0];
                if (int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out funcionarioId))
                {
                    //valor do funcionárioId da linha selecionada.
                }
                else
                {
                    MessageBox.Show("O valor na coluna 'Id' não é um número inteiro válido.");
                }
            }
        }

        private void RealizarFiltragem()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string pesquisa = "%" + textFiltrarFuncionario.Text + "%";

                    string sql = "SELECT * " +
                                 "FROM Funcionario " +
                                 "WHERE nome LIKE @nome";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", pesquisa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            funcionarioListado.Rows.Clear();
                            bool encontrouFuncionario = false;

                            while (reader.Read())
                            {
                                string[] row =
                                {
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                        };
                                funcionarioListado.Rows.Add(row);
                                encontrouFuncionario = true;
                            }

                            if (!encontrouFuncionario)
                            {
                                MessageBox.Show("Nenhum funcionário encontrado.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filtrarFuncionarioKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                RealizarFiltragem();
                e.Handled = true; // Isso impede que o caractere "Enter" seja inserido no TextBox
            }
        }
    }
}
