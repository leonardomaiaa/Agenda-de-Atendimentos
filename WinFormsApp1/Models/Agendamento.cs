namespace AgendaAtendimentos.Models;

public class Agendamento
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; } = null!;
    public Servico Servico { get; set; } = null!;
    public DateTime DataHora { get; set; }
    public StatusAgendamento Status { get; private set; } = StatusAgendamento.Agendado;

    public void AlterarStatus(StatusAgendamento novoStatus)
    {
        Status = novoStatus;
    }

    public override string ToString()
    {
        return $"{DataHora:HH:mm} - {Cliente.Nome} | {Servico.Nome} [{Status}]";
    }
}
