using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaAtendimentos
{
    public partial class Form1 : Form
    {
        // Listas na memória para guardar os dados enquanto o programa estiver aberto
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Servico> listaServicos = new List<Servico>();
        private List<Agendamento> listaAgendamentos = new List<Agendamento>();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento do botão Salvar Cliente
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Digite o nome do cliente!");
                return;
            }

            Cliente novoCliente = new Cliente
            {
                Nome = txtNomeCliente.Text,
                Telefone = txtTelefoneCliente.Text
            };

            listaClientes.Add(novoCliente);
            AtualizarListasClientes();

            // Limpa os campos digitados
            txtNomeCliente.Clear();
            txtTelefoneCliente.Clear();
            MessageBox.Show("Cliente salvo com sucesso!");
        }

        // Evento do botão Salvar Serviço
        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeServico.Text) || !decimal.TryParse(txtPrecoServico.Text, out decimal preco))
            {
                MessageBox.Show("Preencha o nome e um preço válido!");
                return;
            }

            Servico novoServico = new Servico
            {
                Nome = txtNomeServico.Text,
                Preco = preco
            };

            listaServicos.Add(novoServico);
            AtualizarListasServicos();

            // Limpa os campos digitados
            txtNomeServico.Clear();
            txtPrecoServico.Clear();
            MessageBox.Show("Serviço salvo com sucesso!");
        }

        // Evento do botão Agendar
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null || cmbServicos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente e um serviço!");
                return;
            }

            Agendamento novoAgendamento = new Agendamento
            {
                Cliente = (Cliente)cmbClientes.SelectedItem,
                Servico = (Servico)cmbServicos.SelectedItem,
                DataHora = dtpDataHora.Value
            };

            listaAgendamentos.Add(novoAgendamento);
            MessageBox.Show("Agendamento realizado!");
            
            // Atualiza a exibição da agenda caso seja o mesmo dia
            FiltrarAgenda();
        }

        // Evento do botão Ver Agenda
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarAgenda();
        }

        // Métodos Auxiliares para atualizar a tela
        private void AtualizarListasClientes()
        {
            // Atualiza o ListBox e o ComboBox de seleção
            lstClientes.DataSource = null;
            lstClientes.DataSource = listaClientes;

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = listaClientes;
        }

        private void AtualizarListasServicos()
        {
            lstServicos.DataSource = null;
            lstServicos.DataSource = listaServicos;

            cmbServicos.DataSource = null;
            cmbServicos.DataSource = listaServicos;
        }

        private void FiltrarAgenda()
        {
            lstAgendaDia.Items.Clear();
            DateTime dataSelecionada = dtpFiltroAgenda.Value.Date;

            foreach (var agendamento in listaAgendamentos)
            {
                if (agendamento.DataHora.Date == dataSelecionada)
                {
                    lstAgendaDia.Items.Add(agendamento);
                }
            }
        }
    }
}