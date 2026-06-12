using System;

namespace AgendaAtendimentos
{
    /// <summary>
    /// Enumeração que representa os possíveis estados de um agendamento.
    /// </summary>
    public enum StatusAgendamento
    {
        /// <summary>Agendamento criado, aguardando confirmação.</summary>
        Agendado,

        /// <summary>Agendamento confirmado pelo cliente.</summary>
        Confirmado,

        /// <summary>Agendamento cancelado.</summary>
        Cancelado,

        /// <summary>Atendimento realizado com sucesso.</summary>
        Concluido
    }
}
