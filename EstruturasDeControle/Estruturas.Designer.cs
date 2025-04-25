namespace NetEssencial.EstruturasDeControle
{
    partial class Estruturas
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
            btnExecutar = new Button();
            txtDesconto = new TextBox();
            label1 = new Label();
            txtNota = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(193, 118);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(150, 39);
            btnExecutar.TabIndex = 3;
            btnExecutar.Text = "executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(12, 47);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 5;
            label1.Text = "Tem desconto? (S ou N)";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(175, 47);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 18);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 7;
            label2.Text = "Nota Aluno ? (1-10)";
            // 
            // Estruturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 275);
            Controls.Add(label2);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Controls.Add(txtDesconto);
            Controls.Add(btnExecutar);
            Name = "Estruturas";
            Text = "Estruturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecutar;
        private TextBox txtDesconto;
        private Label label1;
        private TextBox txtNota;
        private Label label2;
    }
}