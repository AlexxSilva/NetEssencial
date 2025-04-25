namespace NetEssencial.OperadoresAritmeticos1
{
    partial class OperadoresAritmeticos
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
            btnOperadores = new Button();
            SuspendLayout();
            // 
            // btnOperadores
            // 
            btnOperadores.Location = new Point(187, 114);
            btnOperadores.Name = "btnOperadores";
            btnOperadores.Size = new Size(122, 53);
            btnOperadores.TabIndex = 0;
            btnOperadores.Text = "executar";
            btnOperadores.UseVisualStyleBackColor = true;
            btnOperadores.Click += btnOperadores_Click;
            // 
            // OperadoresAritmeticos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 257);
            Controls.Add(btnOperadores);
            Name = "OperadoresAritmeticos";
            Text = "OperadoresAritmeticos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOperadores;
    }
}