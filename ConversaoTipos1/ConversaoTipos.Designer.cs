namespace NetEssencial.ConversaoTipos1
{
    partial class ConversaoTipos
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
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(171, 83);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(91, 34);
            btnExecutar.TabIndex = 4;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // ConversaoTipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 201);
            Controls.Add(btnExecutar);
            Name = "ConversaoTipos";
            Text = "ConversaoTipos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
    }
}