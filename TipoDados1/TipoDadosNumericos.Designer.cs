namespace NetEssencial.TipoDados1
{
    partial class TipoDadosNumericos
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
            btnExecutar = new Button();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(198, 51);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(96, 31);
            btnExecutar.TabIndex = 0;
            btnExecutar.Text = "executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 135);
            Controls.Add(btnExecutar);
            Name = "Form1";
            Text = "Dados Numericos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
    }
}
