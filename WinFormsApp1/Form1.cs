using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /// <summary>
        /// Filtra e exibe na lista os agendamentos da data selecionada.
        /// </summary>
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

        /// <summary>
        /// Altera o status do agendamento selecionado na lista.
        /// </summary>
        /// <param name="novoStatus">Novo status a ser aplicado.</param>
        private void AlterarStatusAgendamentoSelecionado(StatusAgendamento novoStatus)
        {
            // Verifica se há um agendamento selecionado na lista
            if (lstAgendaDia.SelectedItem is Agendamento agendamento)
            {
                // Altera o status através do método encapsulado
                agendamento.AlterarStatus(novoStatus);
                // Atualiza a exibição da agenda
                FiltrarAgenda();
            }
            else
            {
                MessageBox.Show("Selecione um agendamento na lista primeiro!");
            }
        }

        /// <summary>
        /// Exibe o menu de contexto apenas se houver um agendamento selecionado,
        /// e marca o status atual com um check.
        /// </summary>
        private void contextMenuStatus_Opening(object sender, CancelEventArgs e)
        {
            // Se não houver agendamento selecionado, não abre o menu
            if (lstAgendaDia.SelectedItem is not Agendamento agendamento)
            {
                e.Cancel = true;
                return;
            }

            // Atualiza os checks visuais conforme o status atual do agendamento
            menuStatusAgendado.Checked = agendamento.Status == StatusAgendamento.Agendado;
            menuStatusConfirmado.Checked = agendamento.Status == StatusAgendamento.Confirmado;
            menuStatusCancelado.Checked = agendamento.Status == StatusAgendamento.Cancelado;
            menuStatusConcluido.Checked = agendamento.Status == StatusAgendamento.Concluido;
        }

        /// <summary>Altera o status do agendamento para Agendado.</summary>
        private void menuStatusAgendado_Click(object sender, EventArgs e)
        {
            AlterarStatusAgendamentoSelecionado(StatusAgendamento.Agendado);
        }

        /// <summary>Altera o status do agendamento para Confirmado.</summary>
        private void menuStatusConfirmado_Click(object sender, EventArgs e)
        {
            AlterarStatusAgendamentoSelecionado(StatusAgendamento.Confirmado);
        }

        /// <summary>Altera o status do agendamento para Cancelado.</summary>
        private void menuStatusCancelado_Click(object sender, EventArgs e)
        {
            AlterarStatusAgendamentoSelecionado(StatusAgendamento.Cancelado);
        }

        /// <summary>Altera o status do agendamento para Concluído.</summary>
        private void menuStatusConcluido_Click(object sender, EventArgs e)
        {
            AlterarStatusAgendamentoSelecionado(StatusAgendamento.Concluido);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}