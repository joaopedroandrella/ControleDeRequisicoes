using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BarbanteBandeirantes
{
    public partial class FormEquipamento : Form
    {
        MySqlConnection Conexao;
        private string conector = "Conexão";
        private int? id_Material_Selecionado = null;

        public FormEquipamento()
        {
            InitializeComponent();

            listarMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            listarMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            listarMaterial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listarMaterial.MultiSelect = false;
            listarMaterial.ReadOnly = true;

            listarMaterial.ColumnHeadersVisible = true;
            listarMaterial.RowHeadersVisible = false;
            listarMaterial.AllowUserToAddRows = false;

            listarMaterial.Columns.Add("ID", "ID");
            listarMaterial.Columns.Add("Descricao", "Descricao");
            listarMaterial.Columns.Add("Obs", "Observação Material");

            listarMaterial.Columns["ID"].Visible = false;
            listarMaterial.Columns["Descricao"].Width = 270;
            listarMaterial.Columns["Obs"].Width = 269;

            carregar_daddos();
        }

        private void gravarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = descricaoMaterial.Text;
                string observacao = observacaoMaterial.Text;

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();

                    if (id_Material_Selecionado == null)
                    {
                        if (descricao == "")
                        {
                            MessageBox.Show("A descrição não pode ser nula. Preencha um valor válido.");
                        }
                        else
                        {
                            string sql = "INSERT INTO Material (descricao, observacao) VALUES (@descricao, @observacao)";
                            MySqlCommand comando = new MySqlCommand(sql, conexao);
                            comando.Parameters.AddWithValue("@descricao", descricao);
                            comando.Parameters.AddWithValue("@observacao", observacao);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Gravado com sucesso");
                        }
                    }
                    else
                    {
                        string sql = "UPDATE Material SET descricao=@descricao, observacao=@observacao " +
                            "WHERE id=@id";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@id", id_Material_Selecionado);
                        comando.Parameters.AddWithValue("@descricao", descricao);
                        comando.Parameters.AddWithValue("@observacao", observacao);

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

        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string pesquisa = "%" + pesquisarMaterial.Text + "%";

                    string sql = "SELECT * " +
                                 "FROM Material " +
                                 "WHERE descricao LIKE @descricao";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@descricao", pesquisa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            listarMaterial.Rows.Clear();
                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                };
                                listarMaterial.Rows.Add(row);
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

        private void deletarbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(conector))
                    {
                        conexao.Open();
                        string sql = "DELETE FROM Material WHERE Id = @id";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@id", id_Material_Selecionado);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Deletado com sucesso");
                        carregar_daddos();
                        conexao.Close();
                        limparbtn_Click(this, new EventArgs());
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Esse Material está relacionado a um Funcionário");
                }
            }
        }

        private void carregar_daddos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM Material ORDER BY id DESC ";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            listarMaterial.Rows.Clear();
                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                };
                                listarMaterial.Rows.Add(row);
                                listarMaterial.ClearSelection();
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

        private void listarMaterial_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection itensSelecionados = listarMaterial.SelectedRows;
            foreach (DataGridViewRow linha in itensSelecionados)
            {
                id_Material_Selecionado = Convert.ToInt32(linha.Cells[0].Value.ToString());
                descricaoMaterial.Text = linha.Cells[1].Value.ToString();
                observacaoMaterial.Text = linha.Cells[2].Value.ToString();
            }
        }

        private void limparbtn_Click(object sender, EventArgs e)
        {
            listarMaterial.ClearSelection();
            id_Material_Selecionado = null;
            descricaoMaterial.Clear();
            observacaoMaterial.Clear();
        }

        private void FormMaterial_Load(object sender, EventArgs e)
        {
            listarMaterial.ClearSelection();
            id_Material_Selecionado = null;
            descricaoMaterial.Clear();
            observacaoMaterial.Clear();
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conector))
                {
                    conexao.Open();
                    string pesquisa = "%" + pesquisarMaterial.Text + "%";

                    string sql = "SELECT * " +
                                 "FROM Funcionario " +
                                 "WHERE nome LIKE @nome";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", pesquisa);
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            listarMaterial.Rows.Clear();
                            while (reader.Read())
                            {
                                string[] row =
                                {
                                    reader.GetString(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                };
                                listarMaterial.Rows.Add(row);
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

        private void listarMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisarFuncionario_Click_1(object sender, EventArgs e)
        {

        }
    }
}
