using System;
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
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MessageBox.Show("Conex�o bem-sucedida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conex�o: " + ex.Message);
            }
            return conn;
        }

        private void CarregarUsuarios()
        {
            try
            {
                MySqlConnection conn = ConectarBD();
                string query = "SELECT * FROM Usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Exemplo de como exibir os dados de cada usu�rio
                    Console.WriteLine($"ID: {reader["idUsuario"]}, Nome: {reader["nomeUsuario"]}, Pontua��o: {reader["quantidadePontuacao"]}");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usu�rios: " + ex.Message);
            }
        }


        private void AdicionarUsuario(string nomeUsuario, int quantidadePontuacao)
        {
            try
            {
                MySqlConnection conn = ConectarBD();
                string query = "INSERT INTO Usuario (nomeUsuario, quantidadePontuacao) VALUES (@nomeUsuario, @quantidadePontuacao)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@quantidadePontuacao", quantidadePontuacao);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usu�rio adicionado com sucesso!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usu�rio: " + ex.Message);
            }

        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNomeUsuario.Text;
            int quantidadePontuacao = int.Parse(txtPontuacao.Text);
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
                MySqlConnection conn = ConectarBD();
                string query = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario); // Passando o id do usu�rio a ser exclu�do

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Usu�rio exclu�do com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum usu�rio encontrado com o ID fornecido.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usu�rio: " + ex.Message);
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = int.Parse(txtIdUsuario.Text);  // Pegando o ID do usu�rio a ser exclu�do

                // Mostra uma caixa de mensagem de confirma��o
                DialogResult result = MessageBox.Show("Voc� tem certeza que deseja excluir este usu�rio?", "Confirma��o", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ExcluirUsuario(idUsuario);  // Exclui o usu�rio se confirmado

                    // Atualiza a lista de usu�rios
                    CarregarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir usu�rio: " + ex.Message);
            }
        }

        private void CarregarPergunta()
        {
            MySqlConnection conn = ConectarBD();
            string query = "SELECT * FROM Pergunta WHERE jaUtilizada = 0 ORDER BY RAND() LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

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

                // Marca a pergunta como utilizada
                string updateQuery = "UPDATE Pergunta SET jaUtilizada = 1 WHERE idPergunta = @idPergunta";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@idPergunta", idPergunta);
                updateCmd.ExecuteNonQuery();
            }

            conn.Close();
        }


        private void AtualizarPergunta(string pergunta, string resposta1, string resposta2, string resposta3, string resposta4, int respostaCorreta, int pontosPergunta)
        {
            lblPergunta.Text = pergunta;
            btnResposta1.Text = resposta1;
            btnResposta2.Text = resposta2;
            btnResposta3.Text = resposta3;
            btnResposta4.Text = resposta4;

            // Armazena a resposta correta
            btnResposta1.Tag = (respostaCorreta == 1) ? pontosPergunta : 10;
            btnResposta2.Tag = (respostaCorreta == 2) ? pontosPergunta : 10;
            btnResposta3.Tag = (respostaCorreta == 3) ? pontosPergunta : 10;
            btnResposta4.Tag = (respostaCorreta == 4) ? pontosPergunta : 10;
        }

        private void VerificarResposta(Button respostaSelecionada)
        {
            int pontos = Convert.ToInt32(respostaSelecionada.Tag);

            if (pontos > 0) // Se a resposta est� correta
            {
                pontuacao += pontos;
                MessageBox.Show($"Voc� acertou! Pontua��o atual: {pontuacao}");
            }
            else // Se a resposta est� errada
            {
                MessageBox.Show($"Voc� errou! Pontua��o atual: {pontuacao}");
            }

            // Atualiza a pontua��o do usu�rio no banco de dados
            AtualizarPontuacaoUsuario();

            // Carrega a pr�xima pergunta
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
            // Captura o ID do usu�rio atual
            idUsuarioAtual = Convert.ToInt32(txtIdUsuario.Text); // Use um TextBox para pegar o ID ou outra forma.

            // Inicializa a pontua��o
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
    }
}