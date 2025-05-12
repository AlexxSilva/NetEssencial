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
            // 
            // frmAsync
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 241);
            Controls.Add(btnAssincrono);
            Name = "frmAsync";
            Text = "frmAsync";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAssincrono;
    }
}