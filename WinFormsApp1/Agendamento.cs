using System;

namespace AgendaAtendimentos
{
    public class Agendamento
    {
        public Cliente Cliente { get; set; }
        public Servico Servico { get; set; }
        public DateTime DataHora { get; set; }
        public string Status { get; set; } = "Agendado"; // Já nasce como Agendado

        public override string ToString()
        {
            return $"{DataHora.ToString("HH:mm")} - {Cliente.Nome} | {Servico.Nome} ({Status})";
        }
    }
}