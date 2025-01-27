using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace teste
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
            perguntasUsadas = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private string connectionString = "Server=localhost;Database=Showjogo;Uid=root;Pwd=;";
        private int idUsuarioAtual;
        private int pontuacao;
        private List<int> perguntasUsadas;

        private MySqlConnection ConectarBD()
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                // Aqui você pode tratar erros específicos do MySQL, como problemas de conexão.
                MostrarErro("Erro na conexão com o banco de dados.", ex);
            }
            catch (Exception ex)
            {
                // Trata exceções gerais.
                MostrarErro("Erro inesperado ao conectar com o banco de dados.", ex);
            }
            return null;
        }

        private void MostrarErro(string mensagem, Exception ex)
        {
            // Exibe uma mensagem para o usuário e loga o erro (log pode ser feito em um arquivo ou banco de dados)
            MessageBox.Show($"{mensagem}\nDetalhes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Opcionalmente, logue o erro em um arquivo de log ou banco de dados:
            // LogError(ex);
        }



        private void CarregarUsuarios()
        {
            try
            {
                using (MySqlConnection conn = ConectarBD())
                {
                    if (conn == null)
                        return;

                    string query = "SELECT * FROM Usuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Exemplo de como exibir os dados de cada usuário
                            Console.WriteLine($"ID: {reader["idUsuario"]}, Nome: {reader["nomeUsuario"]}, Pontuação: {reader["quantidadePontuacao"]}");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MostrarErro("Erro ao carregar os usuários do banco de dados.", ex);
            }
            catch (Exception ex)
            {
                MostrarErro("Erro inesperado ao carregar os usuários.", ex);
            }
        }



        private void AdicionarUsuario(string nomeUsuario, int quantidadePontuacao)
        {
            try
            {
                using (MySqlConnection conn = ConectarBD())
                {
                    if (conn == null)
                        return;

                    string query = "INSERT INTO Usuario (nomeUsuario, quantidadePontuacao) VALUES (@nomeUsuario, @quantidadePontuacao)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                        cmd.Parameters.AddWithValue("@quantidadePontuacao", quantidadePontuacao);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário adicionado com sucesso!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MostrarErro("Erro ao adicionar o usuário no banco de dados.", ex);
            }
            catch (Exception ex)
            {
                MostrarErro("Erro inesperado ao adicionar o usuário.", ex);
            }
        }


        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNomeUsuario.Text.Trim();
            if (string.IsNullOrEmpty(nomeUsuario))
            {
                MessageBox.Show("O nome do usuário não pode ser vazio.");
                return;
            }

            if (!int.TryParse(txtPontuacao.Text, out int quantidadePontuacao))
            {
                MessageBox.Show("A pontuação deve ser um número válido.");
                return;
            }

            AdicionarUsuario(nomeUsuario, quantidadePontuacao);
        }


        private void btnCarregarUsuarios_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void ExcluirUsuario(int idUsuario)
        {
            try
            {
                using (MySqlConnection conn = ConectarBD())
                {
                    if (conn == null)
                        return;

                    string query = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum usuário encontrado com o ID fornecido.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MostrarErro("Erro ao excluir o usuário no banco de dados.", ex);
            }
            catch (Exception ex)
            {
                MostrarErro("Erro inesperado ao excluir o usuário.", ex);
            }
        }


        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = int.Parse(txtIdUsuario.Text);  // Pegando o ID do usuário a ser excluído

                // Mostra uma caixa de mensagem de confirmação
                DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ExcluirUsuario(idUsuario);  // Exclui o usuário se confirmado

                    // Atualiza a lista de usuários
                    CarregarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
            }
        }

        private void CarregarPergunta()
        {
            try
            {
                using (MySqlConnection conn = ConectarBD())
                {
                    if (conn == null)
                        return;

                    string query = "SELECT * FROM Pergunta WHERE jaUtilizada = 0 ORDER BY RAND() LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string pergunta = reader["pergunta"].ToString();
                            string resposta1 = reader["resposta1"].ToString();
                            string resposta2 = reader["resposta2"].ToString();
                            string resposta3 = reader["resposta3"].ToString();
                            string resposta4 = reader["resposta4"].ToString();
                            int idPergunta = Convert.ToInt32(reader["idPergunta"]);
                            int respostaCorreta = Convert.ToInt32(reader["respostaCorreta"]);
                            int pontosPergunta = Convert.ToInt32(reader["pontosPergunta"]);

                            perguntasUsadas.Add(idPergunta);
                            AtualizarPergunta(pergunta, resposta1, resposta2, resposta3, resposta4, respostaCorreta, pontosPergunta);

                            // Agora podemos fazer uma segunda consulta em outra conexão, se necessário
                            CarregarOutraPergunta();  // Exemplo de outra consulta
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pergunta: " + ex.Message);
            }
        }

        private void CarregarOutraPergunta()
        {
            try
            {
                using (MySqlConnection conn2 = ConectarBD())
                {
                    if (conn2 == null)
                        return;

                    string query = "SELECT * FROM Pergunta";
                    using (MySqlCommand cmd2 = new MySqlCommand(query, conn2))
                    using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        // Faz algo com os dados de outra consulta
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar outra pergunta: " + ex.Message);
            }
        }




        private void AtualizarPergunta(string pergunta, string resposta1, string resposta2, string resposta3, string resposta4, int respostaCorreta, int pontosPergunta)
        {
            btnPergunta.Text = pergunta;
            btnResposta1.Text = resposta1;
            btnResposta2.Text = resposta2;
            btnResposta3.Text = resposta3;
            btnResposta4.Text = resposta4;

            // Armazenamos a resposta correta no Tag de cada botão
            btnResposta1.Tag = (respostaCorreta == 1) ? pontosPergunta : 0;
            btnResposta2.Tag = (respostaCorreta == 2) ? pontosPergunta : 0;
            btnResposta3.Tag = (respostaCorreta == 3) ? pontosPergunta : 0;
            btnResposta4.Tag = (respostaCorreta == 4) ? pontosPergunta : 0;
        }


        private void VerificarResposta(Button respostaSelecionada)
        {
            int pontos = Convert.ToInt32(respostaSelecionada.Tag);

            if (pontos > 0) // Se a resposta está correta
            {
                pontuacao += pontos;
                MessageBox.Show($"Você acertou! Pontuação atual: {pontuacao}");
            }
            else // Se a resposta está errada
            {
                MessageBox.Show($"Você errou! Pontuação atual: {pontuacao}");
            }

            // Atualiza a pontuação do usuário no banco
            AtualizarPontuacaoUsuario();

            // Carrega a próxima pergunta
            CarregarPergunta();
        }


        private void AtualizarPontuacaoUsuario()
        {
            MySqlConnection conn = ConectarBD();
            string query = "UPDATE Usuario SET quantidadePontuacao = @quantidadePontuacao WHERE idUsuario = @idUsuario";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@quantidadePontuacao", pontuacao);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuarioAtual);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        private void btnIniciarJogo_Click_1(object sender, EventArgs e)
        {
            // Captura o ID do usuário atual
            idUsuarioAtual = Convert.ToInt32(txtIdUsuario.Text); // Use um TextBox para pegar o ID ou outra forma.

            // Inicializa a pontuação
            pontuacao = 0;

            // Carrega a primeira pergunta
            CarregarPergunta();
        }

        private void btnResposta_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            VerificarResposta(btn);
        }

        private void btnResposta1_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta1);
        }

        private void btnResposta2_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta2);
        }

        private void btnResposta3_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta3);
        }

        private void btnResposta4_Click(object sender, EventArgs e)
        {
            VerificarResposta(btnResposta4);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}