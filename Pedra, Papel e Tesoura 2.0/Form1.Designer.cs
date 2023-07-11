namespace Pedra__Papel_e_Tesoura_2._0
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
            bt_pedra = new Button();
            bt_papel = new Button();
            bt_tesoura = new Button();
            bt_resultado = new TextBox();
            label1 = new Label();
            btm_usuario = new Label();
            btm_maquina = new Label();
            btm_resultado2 = new Label();
            btm_resultado1 = new Label();
            bt_console = new Label();
            textBox1 = new TextBox();
            btm_w = new Label();
            btm_w2 = new Label();
            SuspendLayout();
            // 
            // bt_pedra
            // 
            bt_pedra.Location = new Point(408, 233);
            bt_pedra.Name = "bt_pedra";
            bt_pedra.Size = new Size(112, 34);
            bt_pedra.TabIndex = 0;
            bt_pedra.Text = "Pedra";
            bt_pedra.UseVisualStyleBackColor = true;
            bt_pedra.Click += bt_pedra_Click;
            // 
            // bt_papel
            // 
            bt_papel.Location = new Point(526, 233);
            bt_papel.Name = "bt_papel";
            bt_papel.Size = new Size(112, 34);
            bt_papel.TabIndex = 1;
            bt_papel.Text = "Papel";
            bt_papel.UseVisualStyleBackColor = true;
            bt_papel.Click += bt_papel_Click;
            // 
            // bt_tesoura
            // 
            bt_tesoura.Location = new Point(644, 233);
            bt_tesoura.Name = "bt_tesoura";
            bt_tesoura.Size = new Size(112, 34);
            bt_tesoura.TabIndex = 2;
            bt_tesoura.Text = "Tesoura";
            bt_tesoura.UseVisualStyleBackColor = true;
            bt_tesoura.Click += bt_tesoura_Click;
            // 
            // bt_resultado
            // 
            bt_resultado.Location = new Point(408, 60);
            bt_resultado.Name = "bt_resultado";
            bt_resultado.Size = new Size(348, 31);
            bt_resultado.TabIndex = 3;
            bt_resultado.Text = " ";
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 19);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 4;
            label1.Text = "Pedra  Papel  Tesoura";
            // 
            // btm_usuario
            // 
            btm_usuario.AutoSize = true;
            btm_usuario.Location = new Point(138, 63);
            btm_usuario.Name = "btm_usuario";
            btm_usuario.Size = new Size(72, 25);
            btm_usuario.TabIndex = 5;
            btm_usuario.Text = "Usuário";
            // 
            // btm_maquina
            // 
            btm_maquina.AutoSize = true;
            btm_maquina.Location = new Point(138, 128);
            btm_maquina.Name = "btm_maquina";
            btm_maquina.Size = new Size(81, 25);
            btm_maquina.TabIndex = 6;
            btm_maquina.Text = "Máquina";
            // 
            // btm_resultado2
            // 
            btm_resultado2.AutoSize = true;
            btm_resultado2.Location = new Point(228, 128);
            btm_resultado2.Name = "btm_resultado2";
            btm_resultado2.Size = new Size(22, 25);
            btm_resultado2.TabIndex = 7;
            btm_resultado2.Text = "0";
            
            // 
            // btm_resultado1
            // 
            btm_resultado1.AutoSize = true;
            btm_resultado1.Location = new Point(228, 63);
            btm_resultado1.Name = "btm_resultado1";
            btm_resultado1.Size = new Size(22, 25);
            btm_resultado1.TabIndex = 8;
            btm_resultado1.Text = "0";
            
            // 
            // bt_console
            // 
            bt_console.AutoSize = true;
            bt_console.Location = new Point(561, 93);
            bt_console.Name = "bt_console";
            bt_console.Size = new Size(0, 25);
            bt_console.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 31);
            textBox1.TabIndex = 10;
            
            // 
            // btm_w
            // 
            btm_w.AutoSize = true;
            btm_w.Location = new Point(803, 60);
            btm_w.Name = "btm_w";
            btm_w.Size = new Size(0, 25);
            btm_w.TabIndex = 11;
            // 
            // btm_w2
            // 
            btm_w2.AutoSize = true;
            btm_w2.Location = new Point(803, 128);
            btm_w2.Name = "btm_w2";
            btm_w2.Size = new Size(0, 25);
            btm_w2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1060, 450);
            Controls.Add(btm_w2);
            Controls.Add(btm_w);
            Controls.Add(textBox1);
            Controls.Add(bt_console);
            Controls.Add(btm_resultado1);
            Controls.Add(btm_resultado2);
            Controls.Add(btm_maquina);
            Controls.Add(btm_usuario);
            Controls.Add(label1);
            Controls.Add(bt_resultado);
            Controls.Add(bt_tesoura);
            Controls.Add(bt_papel);
            Controls.Add(bt_pedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_pedra;
        private Button bt_papel;
        private Button bt_tesoura;
        private TextBox bt_resultado;
        private Label label1;
        private Label btm_usuario;
        private Label btm_maquina;
        private Label btm_resultado2;
        private Label btm_resultado1;
        private Label bt_console;
        private TextBox textBox1;
        private Label btm_w;
        private Label btm_w2;
    }
}