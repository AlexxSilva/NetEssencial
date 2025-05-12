namespace NetEssencial.Delegates
{
    partial class Delegates1
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
            btnExecutar.Location = new Point(46, 38);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(150, 39);
            btnExecutar.TabIndex = 4;
            btnExecutar.Text = "executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // Delegates1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 174);
            Controls.Add(btnExecutar);
            Name = "Delegates1";
            Text = "Delegates1";
            Load += Delegates1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
    }
}