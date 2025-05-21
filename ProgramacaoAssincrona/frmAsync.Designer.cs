namespace NetEssencial.ProgramacaoAssincrona
{
    partial class frmAsync
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
            btnAssincrono = new Button();
            txtEditor = new TextBox();
            Excecoes = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAssincrono
            // 
            btnAssincrono.Location = new Point(28, 12);
            btnAssincrono.Name = "btnAssincrono";
            btnAssincrono.Size = new Size(75, 23);
            btnAssincrono.TabIndex = 0;
            btnAssincrono.Text = "Executar";
            btnAssincrono.UseVisualStyleBackColor = true;
            btnAssincrono.Click += btnAssincrono_Click;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(35, 50);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(325, 179);
            txtEditor.TabIndex = 1;
            // 
            // Excecoes
            // 
            Excecoes.Location = new Point(158, 12);
            Excecoes.Name = "Excecoes";
            Excecoes.Size = new Size(124, 23);
            Excecoes.TabIndex = 2;
            Excecoes.Text = "Exceções Async";
            Excecoes.UseVisualStyleBackColor = true;
            Excecoes.Click += Excecoes_Click;
            // 
            // button1
            // 
            button1.Location = new Point(358, 12);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 3;
            button1.Text = "Varias Exceções Async";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAsync
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 241);
            Controls.Add(button1);
            Controls.Add(Excecoes);
            Controls.Add(txtEditor);
            Controls.Add(btnAssincrono);
            Name = "frmAsync";
            Text = "frmAsync";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAssincrono;
        private TextBox txtEditor;
        private Button Excecoes;
        private Button button1;
    }
}