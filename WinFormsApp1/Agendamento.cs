using System;

namespace AgendaAtendimentos
{
    /// <summary>
    /// Classe que representa um agendamento na agenda de atendimentos.
    /// </summary>
    public class Agendamento
    {
        /// <summary>Cliente associado ao agendamento.</summary>
        public Cliente Cliente { get; set; } = null!;

        /// <summary>Serviço que será realizado.</summary>
        public Servico Servico { get; set; } = null!;

        /// <summary>Data e hora marcada para o atendimento.</summary>
        public DateTime DataHora { get; set; }

        /// <summary>
        /// Status atual do agendamento.
        /// O setter é privado para garantir o encapsulamento.
        /// Ao criar um agendamento, o status padrão é "Agendado".
        /// </summary>
        public StatusAgendamento Status { get; private set; } = StatusAgendamento.Agendado;

        /// <summary>
        /// Altera o status do agendamento.
        /// O encapsulamento do status impede que ele seja alterado
        /// de fora sem passar por este método.
        /// </summary>
        /// <param name="novoStatus">Novo estado do agendamento.</param>
        public void AlterarStatus(StatusAgendamento novoStatus)
        {
            Status = novoStatus;
        }

        /// <summary>
        /// Retorna uma string formatada para exibição na lista da agenda.
        /// </summary>
        public override string ToString()
        {
            return $"{DataHora:HH:mm} - {Cliente.Nome} | {Servico.Nome} [{Status}]";
        }
    }
}