namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeUsuario = new TextBox();
            btnAdicionarUsuario = new Button();
            txtPontuacao = new TextBox();
            btnCarregarUsuarios = new Button();
            lblnome = new Label();
            lblpontuacao = new Label();
            btnExcluirUsuario = new Button();
            txtIdUsuario = new TextBox();
            lblid = new Label();
            lblPergunta = new Label();
            btnResposta1 = new Button();
            btnResposta2 = new Button();
            btnResposta3 = new Button();
            btnResposta4 = new Button();
            btnResposta = new Button();
            btnIniciarJogo = new Button();
            SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(32, 36);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(114, 23);
            txtNomeUsuario.TabIndex = 0;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Location = new Point(32, 76);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(75, 23);
            btnAdicionarUsuario.TabIndex = 1;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // txtPontuacao
            // 
            txtPontuacao.Location = new Point(228, 36);
            txtPontuacao.Name = "txtPontuacao";
            txtPontuacao.Size = new Size(100, 23);
            txtPontuacao.TabIndex = 2;
            // 
            // btnCarregarUsuarios
            // 
            btnCarregarUsuarios.Location = new Point(228, 76);
            btnCarregarUsuarios.Name = "btnCarregarUsuarios";
            btnCarregarUsuarios.Size = new Size(75, 23);
            btnCarregarUsuarios.TabIndex = 3;
            btnCarregarUsuarios.Text = "Carregar";
            btnCarregarUsuarios.UseVisualStyleBackColor = true;
            btnCarregarUsuarios.Click += btnCarregarUsuarios_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(32, 9);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome";
            // 
            // lblpontuacao
            // 
            lblpontuacao.AutoSize = true;
            lblpontuacao.Location = new Point(228, 9);
            lblpontuacao.Name = "lblpontuacao";
            lblpontuacao.Size = new Size(64, 15);
            lblpontuacao.TabIndex = 5;
            lblpontuacao.Text = "pontuacao";
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(395, 76);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(75, 23);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(395, 36);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 7;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(395, 9);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 8;
            lblid.Text = "Id";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Location = new Point(142, 159);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(55, 15);
            lblPergunta.TabIndex = 9;
            lblPergunta.Text = "Pergunta";
            // 
            // btnResposta1
            // 
            btnResposta1.Location = new Point(62, 214);
            btnResposta1.Name = "btnResposta1";
            btnResposta1.Size = new Size(153, 76);
            btnResposta1.TabIndex = 10;
            btnResposta1.Text = "button1";
            btnResposta1.UseVisualStyleBackColor = true;
            btnResposta1.Click += btnResposta1_Click;
            // 
            // btnResposta2
            // 
            btnResposta2.Location = new Point(323, 214);
            btnResposta2.Name = "btnResposta2";
            btnResposta2.Size = new Size(132, 76);
            btnResposta2.TabIndex = 11;
            btnResposta2.Text = "button1";
            btnResposta2.UseVisualStyleBackColor = true;
            btnResposta2.Click += btnResposta2_Click;
            // 
            // btnResposta3
            // 
            btnResposta3.Location = new Point(62, 296);
            btnResposta3.Name = "btnResposta3";
            btnResposta3.Size = new Size(153, 94);
            btnResposta3.TabIndex = 12;
            btnResposta3.Text = "button1";
            btnResposta3.UseVisualStyleBackColor = true;
            btnResposta3.Click += btnResposta3_Click;
            // 
            // btnResposta4
            // 
            btnResposta4.Location = new Point(323, 296);
            btnResposta4.Name = "btnResposta4";
            btnResposta4.Size = new Size(132, 94);
            btnResposta4.TabIndex = 13;
            btnResposta4.Text = "button1";
            btnResposta4.UseVisualStyleBackColor = true;
            btnResposta4.Click += btnResposta4_Click;
            // 
            // btnResposta
            // 
            btnResposta.Location = new Point(492, 296);
            btnResposta.Name = "btnResposta";
            btnResposta.Size = new Size(75, 23);
            btnResposta.TabIndex = 14;
            btnResposta.Text = "Confirmar";
            btnResposta.UseVisualStyleBackColor = true;
            btnResposta.Click += btnResposta_Click_1;
            // 
            // btnIniciarJogo
            // 
            btnIniciarJogo.Location = new Point(492, 251);
            btnIniciarJogo.Name = "btnIniciarJogo";
            btnIniciarJogo.Size = new Size(75, 23);
            btnIniciarJogo.TabIndex = 15;
            btnIniciarJogo.Text = "START";
            btnIniciarJogo.UseVisualStyleBackColor = true;
            btnIniciarJogo.Click += btnIniciarJogo_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciarJogo);
            Controls.Add(btnResposta);
            Controls.Add(btnResposta4);
            Controls.Add(btnResposta3);
            Controls.Add(btnResposta2);
            Controls.Add(btnResposta1);
            Controls.Add(lblPergunta);
            Controls.Add(lblid);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(lblpontuacao);
            Controls.Add(lblnome);
            Controls.Add(btnCarregarUsuarios);
            Controls.Add(txtPontuacao);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(txtNomeUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeUsuario;
        private Button btnAdicionarUsuario;
        private TextBox txtPontuacao;
        private Button btnCarregarUsuarios;
        private Label lblnome;
        private Label lblpontuacao;
        private Button btnExcluirUsuario;
        private TextBox txtIdUsuario;
        private Label lblid;
        private Label lblPergunta;
        private Button btnResposta1;
        private Button btnResposta2;
        private Button btnResposta3;
        private Button btnResposta4;
        private Button btnResposta;
        private Button btnIniciarJogo;
    }
}