namespace app01.View
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbl_Nome = new Label();
            lbl_Telefone = new Label();
            lbl_Mensagem = new Label();
            btn_Executar = new Button();
            txb_Nome = new TextBox();
            txb_Telefone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 86);
            label1.Name = "label1";
            label1.Size = new Size(367, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Pessoas";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(44, 176);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(43, 15);
            lbl_Nome.TabIndex = 1;
            lbl_Nome.Text = "Nome:";
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.AutoSize = true;
            lbl_Telefone.Location = new Point(44, 216);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(54, 15);
            lbl_Telefone.TabIndex = 2;
            lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.BackColor = Color.Plum;
            lbl_Mensagem.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensagem.ForeColor = SystemColors.ControlLightLight;
            lbl_Mensagem.Location = new Point(44, 248);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(383, 118);
            lbl_Mensagem.TabIndex = 3;
            lbl_Mensagem.Click += lbl_Mensagem_Click;
            // 
            // btn_Executar
            // 
            btn_Executar.Location = new Point(44, 380);
            btn_Executar.Name = "btn_Executar";
            btn_Executar.Size = new Size(383, 45);
            btn_Executar.TabIndex = 4;
            btn_Executar.Text = "Executar";
            btn_Executar.UseVisualStyleBackColor = true;
            btn_Executar.Click += btn_Executar_Click;
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(93, 173);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(297, 23);
            txb_Nome.TabIndex = 5;
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(104, 213);
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.Size = new Size(100, 23);
            txb_Telefone.TabIndex = 6;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(493, 450);
            Controls.Add(txb_Telefone);
            Controls.Add(txb_Nome);
            Controls.Add(btn_Executar);
            Controls.Add(lbl_Mensagem);
            Controls.Add(lbl_Telefone);
            Controls.Add(lbl_Nome);
            Controls.Add(label1);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cadastro de Pessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Nome;
        private Label lbl_Telefone;
        private Label lbl_Mensagem;
        private Button btn_Executar;
        private TextBox txb_Nome;
        private TextBox txb_Telefone;
    }
}