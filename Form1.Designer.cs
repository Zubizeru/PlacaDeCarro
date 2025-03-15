namespace PlacaDeCarro
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
            btnValidar = new Button();
            txtPlaca = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(165, 231);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(125, 182);
            txtPlaca.Mask = "aaa-0000";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(158, 23);
            txtPlaca.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(txtPlaca);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Venda Placa de Carro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnValidar;
        private MaskedTextBox txtPlaca;
    }
}
