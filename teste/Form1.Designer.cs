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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNomeUsuario = new TextBox();
            btnAdicionarUsuario = new Button();
            txtPontuacao = new TextBox();
            btnCarregarUsuarios = new Button();
            lblnome = new Label();
            lblpontuacao = new Label();
            btnExcluirUsuario = new Button();
            txtIdUsuario = new TextBox();
            lblid = new Label();
            btnResposta1 = new Button();
            btnResposta2 = new Button();
            btnResposta3 = new Button();
            btnResposta4 = new Button();
            btnResposta = new Button();
            btnIniciarJogo = new Button();
            btnSair = new Button();
            btnPergunta = new Button();
            SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(553, 168);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(114, 23);
            txtNomeUsuario.TabIndex = 0;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.Location = new Point(553, 197);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(75, 23);
            btnAdicionarUsuario.TabIndex = 1;
            btnAdicionarUsuario.Text = "Adicionar";
            btnAdicionarUsuario.UseVisualStyleBackColor = true;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // txtPontuacao
            // 
            txtPontuacao.Location = new Point(673, 168);
            txtPontuacao.Name = "txtPontuacao";
            txtPontuacao.Size = new Size(100, 23);
            txtPontuacao.TabIndex = 2;
            // 
            // btnCarregarUsuarios
            // 
            btnCarregarUsuarios.Location = new Point(634, 197);
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
            lblnome.Location = new Point(553, 150);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome";
            // 
            // lblpontuacao
            // 
            lblpontuacao.AutoSize = true;
            lblpontuacao.Location = new Point(673, 150);
            lblpontuacao.Name = "lblpontuacao";
            lblpontuacao.Size = new Size(64, 15);
            lblpontuacao.TabIndex = 5;
            lblpontuacao.Text = "pontuacao";
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(713, 197);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(75, 23);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(629, 274);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 7;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(629, 244);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 8;
            lblid.Text = "Id";
            // 
            // btnResposta1
            // 
            btnResposta1.BackColor = Color.Transparent;
            btnResposta1.FlatAppearance.BorderColor = Color.FromArgb(255, 223, 0);
            btnResposta1.FlatStyle = FlatStyle.Flat;
            btnResposta1.Location = new Point(50, 168);
            btnResposta1.Name = "btnResposta1";
            btnResposta1.Size = new Size(324, 35);
            btnResposta1.TabIndex = 10;
            btnResposta1.Text = "button1";
            btnResposta1.UseVisualStyleBackColor = false;
            btnResposta1.Click += btnResposta1_Click;
            // 
            // btnResposta2
            // 
            btnResposta2.BackColor = Color.Transparent;
            btnResposta2.FlatAppearance.BorderColor = Color.FromArgb(255, 223, 0);
            btnResposta2.FlatStyle = FlatStyle.Flat;
            btnResposta2.Location = new Point(50, 227);
            btnResposta2.Name = "btnResposta2";
            btnResposta2.Size = new Size(324, 32);
            btnResposta2.TabIndex = 11;
            btnResposta2.Text = "button1";
            btnResposta2.UseVisualStyleBackColor = false;
            btnResposta2.Click += btnResposta2_Click;
            // 
            // btnResposta3
            // 
            btnResposta3.BackColor = Color.Transparent;
            btnResposta3.FlatAppearance.BorderColor = Color.FromArgb(255, 223, 0);
            btnResposta3.FlatStyle = FlatStyle.Flat;
            btnResposta3.Location = new Point(50, 274);
            btnResposta3.Name = "btnResposta3";
            btnResposta3.Size = new Size(324, 39);
            btnResposta3.TabIndex = 12;
            btnResposta3.Text = "button1";
            btnResposta3.UseVisualStyleBackColor = false;
            btnResposta3.Click += btnResposta3_Click;
            // 
            // btnResposta4
            // 
            btnResposta4.BackColor = Color.Transparent;
            btnResposta4.FlatAppearance.BorderColor = Color.FromArgb(255, 223, 0);
            btnResposta4.FlatStyle = FlatStyle.Flat;
            btnResposta4.Location = new Point(50, 329);
            btnResposta4.Name = "btnResposta4";
            btnResposta4.Size = new Size(324, 34);
            btnResposta4.TabIndex = 13;
            btnResposta4.Text = "button1";
            btnResposta4.UseVisualStyleBackColor = false;
            btnResposta4.Click += btnResposta4_Click;
            // 
            // btnResposta
            // 
            btnResposta.Location = new Point(629, 367);
            btnResposta.Name = "btnResposta";
            btnResposta.Size = new Size(75, 23);
            btnResposta.TabIndex = 14;
            btnResposta.Text = "Confirmar";
            btnResposta.UseVisualStyleBackColor = true;
            btnResposta.Click += btnResposta_Click_1;
            // 
            // btnIniciarJogo
            // 
            btnIniciarJogo.Location = new Point(629, 320);
            btnIniciarJogo.Name = "btnIniciarJogo";
            btnIniciarJogo.Size = new Size(75, 23);
            btnIniciarJogo.TabIndex = 15;
            btnIniciarJogo.Text = "START";
            btnIniciarJogo.UseVisualStyleBackColor = true;
            btnIniciarJogo.Click += btnIniciarJogo_Click_1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(629, 406);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 16;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPergunta
            // 
            btnPergunta.BackColor = Color.Transparent;
            btnPergunta.FlatAppearance.BorderColor = Color.FromArgb(255, 223, 0);
            btnPergunta.FlatStyle = FlatStyle.Flat;
            btnPergunta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPergunta.Location = new Point(50, 48);
            btnPergunta.Name = "btnPergunta";
            btnPergunta.Size = new Size(453, 87);
            btnPergunta.TabIndex = 17;
            btnPergunta.Text = "Pergunta";
            btnPergunta.TextAlign = ContentAlignment.TopLeft;
            btnPergunta.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPergunta);
            Controls.Add(btnSair);
            Controls.Add(btnIniciarJogo);
            Controls.Add(btnResposta);
            Controls.Add(btnResposta4);
            Controls.Add(btnResposta3);
            Controls.Add(btnResposta2);
            Controls.Add(btnResposta1);
            Controls.Add(lblid);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(lblpontuacao);
            Controls.Add(lblnome);
            Controls.Add(btnCarregarUsuarios);
            Controls.Add(txtPontuacao);
            Controls.Add(btnAdicionarUsuario);
            Controls.Add(txtNomeUsuario);
            DoubleBuffered = true;
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
        private Button btnResposta1;
        private Button btnResposta2;
        private Button btnResposta3;
        private Button btnResposta4;
        private Button btnResposta;
        private Button btnIniciarJogo;
        private Button btnSair;
        private Button btnPergunta;
    }
}