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
            lvPlacas = new ListView();
            columnHeader1 = new ColumnHeader();
            lblPlacas = new Label();
            txtPlaca = new TextBox();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.DarkSlateGray;
            btnValidar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidar.ForeColor = Color.Ivory;
            btnValidar.Location = new Point(110, 164);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(88, 34);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // lvPlacas
            // 
            lvPlacas.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvPlacas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvPlacas.ForeColor = Color.DarkSlateGray;
            lvPlacas.GridLines = true;
            lvPlacas.Location = new Point(45, 225);
            lvPlacas.Name = "lvPlacas";
            lvPlacas.Size = new Size(225, 183);
            lvPlacas.TabIndex = 3;
            lvPlacas.UseCompatibleStateImageBehavior = false;
            lvPlacas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Placa";
            columnHeader1.Width = 200;
            // 
            // lblPlacas
            // 
            lblPlacas.AutoSize = true;
            lblPlacas.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacas.ForeColor = Color.DarkSlateGray;
            lblPlacas.Location = new Point(87, 33);
            lblPlacas.Name = "lblPlacas";
            lblPlacas.Size = new Size(140, 43);
            lblPlacas.TabIndex = 4;
            lblPlacas.Text = "Placas";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(61, 119);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(192, 23);
            txtPlaca.TabIndex = 5;
            txtPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(309, 450);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlacas);
            Controls.Add(lvPlacas);
            Controls.Add(btnValidar);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Venda Placa de Carro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnValidar;
        private ListView lvPlacas;
        private Label lblPlacas;
        private ColumnHeader columnHeader1;
        private TextBox txtPlaca;
    }
}
