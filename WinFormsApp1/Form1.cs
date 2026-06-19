using System.ComponentModel;
using AgendaAtendimentos.Models;
using AgendaAtendimentos.Services;

namespace AgendaAtendimentos;

public partial class Form1 : Form
{
    private readonly AgendaService _agendaService = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnSalvarCliente_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
        {
            MessageBox.Show("Digite o nome do cliente!");
            return;
        }

        _agendaService.AdicionarCliente(txtNomeCliente.Text, txtTelefoneCliente.Text);
        AtualizarListasClientes();
        txtNomeCliente.Clear();
        txtTelefoneCliente.Clear();
    }

    private void btnSalvarServico_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNomeServico.Text) || !decimal.TryParse(txtPrecoServico.Text, out decimal preco))
        {
            MessageBox.Show("Preencha o nome e um preço válido!");
            return;
        }

        _agendaService.AdicionarServico(txtNomeServico.Text, preco);
        AtualizarListasServicos();
        txtNomeServico.Clear();
        txtPrecoServico.Clear();
    }

    private void btnAgendar_Click(object sender, EventArgs e)
    {
        if (cmbClientes.SelectedItem is not Cliente clienteSelecionado)
        {
            MessageBox.Show("Selecione um cliente!");
            return;
        }

        if (cmbServicos.SelectedItem is not Servico servicoSelecionado)
        {
            MessageBox.Show("Selecione um serviço!");
            return;
        }

        _agendaService.Agendar(clienteSelecionado, servicoSelecionado, dtpDataHora.Value);
        FiltrarAgenda();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        FiltrarAgenda();
    }

    private void AtualizarListasClientes()
    {
        lstClientes.DataSource = null;
        lstClientes.DataSource = _agendaService.Clientes.ToList();

        cmbClientes.DataSource = null;
        cmbClientes.DataSource = _agendaService.Clientes.ToList();
    }

    private void AtualizarListasServicos()
    {
        lstServicos.DataSource = null;
        lstServicos.DataSource = _agendaService.Servicos.ToList();

        cmbServicos.DataSource = null;
        cmbServicos.DataSource = _agendaService.Servicos.ToList();
    }

    private void FiltrarAgenda()
    {
        var agendamentos = _agendaService.FiltrarPorData(dtpFiltroAgenda.Value);
        lstAgendaDia.DataSource = null;
        lstAgendaDia.DataSource = agendamentos;
    }

    private void AlterarStatusAgendamentoSelecionado(StatusAgendamento novoStatus)
    {
        if (lstAgendaDia.SelectedItem is Agendamento agendamento)
        {
            _agendaService.AlterarStatusAgendamento(agendamento.Id, novoStatus);
            FiltrarAgenda();
        }
        else
        {
            MessageBox.Show("Selecione um agendamento na lista primeiro!");
        }
    }

    private void contextMenuStatus_Opening(object sender, CancelEventArgs e)
    {
        if (lstAgendaDia.SelectedItem is not Agendamento agendamento)
        {
            e.Cancel = true;
            return;
        }

        menuStatusAgendado.Checked = agendamento.Status == StatusAgendamento.Agendado;
        menuStatusConfirmado.Checked = agendamento.Status == StatusAgendamento.Confirmado;
        menuStatusCancelado.Checked = agendamento.Status == StatusAgendamento.Cancelado;
        menuStatusConcluido.Checked = agendamento.Status == StatusAgendamento.Concluido;
    }

    private void menuStatusAgendado_Click(object sender, EventArgs e)
    {
        AlterarStatusAgendamentoSelecionado(StatusAgendamento.Agendado);
    }

    private void menuStatusConfirmado_Click(object sender, EventArgs e)
    {
        AlterarStatusAgendamentoSelecionado(StatusAgendamento.Confirmado);
    }

    private void menuStatusCancelado_Click(object sender, EventArgs e)
    {
        AlterarStatusAgendamentoSelecionado(StatusAgendamento.Cancelado);
    }

    private void menuStatusConcluido_Click(object sender, EventArgs e)
    {
        AlterarStatusAgendamentoSelecionado(StatusAgendamento.Concluido);
    }
}
