namespace WinFormsApp1
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
            label1 = new Label();
            txtNomeCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            Telefone = new Label();
            btnSalvarCliente = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(23, 44);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(125, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(23, 116);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(125, 27);
            txtTelefoneCliente.TabIndex = 2;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(23, 93);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(66, 20);
            Telefone.TabIndex = 3;
            Telefone.Text = "Telefone";
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.Location = new Point(23, 163);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(94, 29);
            btnSalvarCliente.TabIndex = 4;
            btnSalvarCliente.Text = "Salvar Cliente";
            btnSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(23, 198);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(205, 164);
            lstClientes.TabIndex = 5;
            lstClientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstClientes);
            Controls.Add(btnSalvarCliente);
            Controls.Add(Telefone);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCliente;
        private TextBox txtTelefoneCliente;
        private Label Telefone;
        private Button btnSalvarCliente;
        private ListBox lstClientes;
    }
}
