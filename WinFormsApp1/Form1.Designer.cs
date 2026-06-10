namespace AgendaAtendimentos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNomeCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            Telefone = new Label();
            btnSalvarCliente = new Button();
            lstClientes = new ListBox();
            btnSalvarServico = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNomeServico = new TextBox();
            txtPrecoServico = new TextBox();
            cmbClientes = new ComboBox();
            lstServicos = new ListBox();
            label4 = new Label();
            label5 = new Label();
            cmbServicos = new ComboBox();
            label6 = new Label();
            dtpDataHora = new DateTimePicker();
            btnAgendar = new Button();
            label7 = new Label();
            dtpFiltroAgenda = new DateTimePicker();
            btnFiltrar = new Button();
            lstAgendaDia = new ListBox();
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
            txtNomeCliente.Size = new Size(191, 27);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.Text = "o";
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(23, 116);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(144, 27);
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
            btnSalvarCliente.Click += btnSalvarCliente_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.Location = new Point(237, 28);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(431, 184);
            lstClientes.TabIndex = 5;
            // 
            // btnSalvarServico
            // 
            btnSalvarServico.Location = new Point(23, 399);
            btnSalvarServico.Name = "btnSalvarServico";
            btnSalvarServico.Size = new Size(94, 29);
            btnSalvarServico.TabIndex = 6;
            btnSalvarServico.Text = "Salvar Serviço";
            btnSalvarServico.UseVisualStyleBackColor = true;
            btnSalvarServico.Click += btnSalvarServico_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 249);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome do Serviço";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 325);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Preço";
            // 
            // txtNomeServico
            // 
            txtNomeServico.Location = new Point(24, 272);
            txtNomeServico.Name = "txtNomeServico";
            txtNomeServico.Size = new Size(190, 27);
            txtNomeServico.TabIndex = 9;
            // 
            // txtPrecoServico
            // 
            txtPrecoServico.Location = new Point(24, 348);
            txtPrecoServico.Name = "txtPrecoServico";
            txtPrecoServico.Size = new Size(143, 27);
            txtPrecoServico.TabIndex = 10;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(16, 544);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(151, 28);
            cmbClientes.TabIndex = 11;
            // 
            // lstServicos
            // 
            lstServicos.FormattingEnabled = true;
            lstServicos.Location = new Point(237, 249);
            lstServicos.Name = "lstServicos";
            lstServicos.Size = new Size(431, 204);
            lstServicos.TabIndex = 12;
            lstServicos.SelectedIndexChanged += lstServicos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 516);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 13;
            label4.Text = "Selecione Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 516);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 14;
            label5.Text = "Selecione Serviço";
            // 
            // cmbServicos
            // 
            cmbServicos.FormattingEnabled = true;
            cmbServicos.Location = new Point(220, 544);
            cmbServicos.Name = "cmbServicos";
            cmbServicos.Size = new Size(151, 28);
            cmbServicos.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 593);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 16;
            label6.Text = "Data e Hora";
            // 
            // dtpDataHora
            // 
            dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.Location = new Point(16, 616);
            dtpDataHora.Name = "dtpDataHora";
            dtpDataHora.ShowUpDown = true;
            dtpDataHora.Size = new Size(250, 27);
            dtpDataHora.TabIndex = 17;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(73, 662);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(94, 29);
            btnAgendar.TabIndex = 18;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(988, 21);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 19;
            label7.Text = "Filtrar por data";
            // 
            // dtpFiltroAgenda
            // 
            dtpFiltroAgenda.CustomFormat = "dd/MM/yyyy";
            dtpFiltroAgenda.Format = DateTimePickerFormat.Custom;
            dtpFiltroAgenda.Location = new Point(920, 42);
            dtpFiltroAgenda.Name = "dtpFiltroAgenda";
            dtpFiltroAgenda.Size = new Size(250, 27);
            dtpFiltroAgenda.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(1002, 75);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 21;
            btnFiltrar.Text = "Ver Agenda";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lstAgendaDia
            // 
            lstAgendaDia.FormattingEnabled = true;
            lstAgendaDia.Location = new Point(812, 116);
            lstAgendaDia.Name = "lstAgendaDia";
            lstAgendaDia.Size = new Size(468, 524);
            lstAgendaDia.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 748);
            Controls.Add(lstAgendaDia);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpFiltroAgenda);
            Controls.Add(label7);
            Controls.Add(btnAgendar);
            Controls.Add(dtpDataHora);
            Controls.Add(label6);
            Controls.Add(cmbServicos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstServicos);
            Controls.Add(cmbClientes);
            Controls.Add(txtPrecoServico);
            Controls.Add(txtNomeServico);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalvarServico);
            Controls.Add(lstClientes);
            Controls.Add(btnSalvarCliente);
            Controls.Add(Telefone);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agenda de Atendimentos";
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
        private Button btnSalvarServico;
        private Label label2;
        private Label label3;
        private TextBox txtNomeServico;
        private TextBox txtPrecoServico;
        private ComboBox cmbClientes;
        private ListBox lstServicos;
        private Label label4;
        private Label label5;
        private ComboBox cmbServicos;
        private Label label6;
        private DateTimePicker dtpDataHora;
        private Button btnAgendar;
        private Label label7;
        private DateTimePicker dtpFiltroAgenda;
        private Button btnFiltrar;
        private ListBox lstAgendaDia;
    }
}
