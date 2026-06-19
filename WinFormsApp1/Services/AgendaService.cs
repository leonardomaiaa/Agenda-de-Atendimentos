using AgendaAtendimentos.Models;

namespace AgendaAtendimentos.Services;

public class AgendaService
{
    private List<Cliente> _clientes = new();
    private List<Servico> _servicos = new();
    private List<Agendamento> _agendamentos = new();
    private int _nextClienteId = 1;
    private int _nextServicoId = 1;
    private int _nextAgendamentoId = 1;

    public IReadOnlyList<Cliente> Clientes => _clientes;
    public IReadOnlyList<Servico> Servicos => _servicos;
    public IReadOnlyList<Agendamento> Agendamentos => _agendamentos;

    public Cliente AdicionarCliente(string nome, string telefone)
    {
        var cliente = new Cliente
        {
            Id = _nextClienteId++,
            Nome = nome,
            Telefone = telefone
        };
        _clientes.Add(cliente);
        return cliente;
    }

    public Servico AdicionarServico(string nome, decimal preco)
    {
        var servico = new Servico
        {
            Id = _nextServicoId++,
            Nome = nome,
            Preco = preco
        };
        _servicos.Add(servico);
        return servico;
    }

    public Agendamento Agendar(Cliente cliente, Servico servico, DateTime dataHora)
    {
        var agendamento = new Agendamento
        {
            Id = _nextAgendamentoId++,
            Cliente = cliente,
            Servico = servico,
            DataHora = dataHora
        };
        _agendamentos.Add(agendamento);
        return agendamento;
    }

    public List<Agendamento> FiltrarPorData(DateTime data)
    {
        return _agendamentos
            .Where(a => a.DataHora.Date == data.Date)
            .OrderBy(a => a.DataHora)
            .ToList();
    }

    public bool AlterarStatusAgendamento(int agendamentoId, StatusAgendamento novoStatus)
    {
        var agendamento = _agendamentos.FirstOrDefault(a => a.Id == agendamentoId);
        if (agendamento == null)
            return false;

        agendamento.AlterarStatus(novoStatus);
        return true;
    }
}
