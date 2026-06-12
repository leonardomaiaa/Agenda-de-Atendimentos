namespace AgendaAtendimentos
{
    /// <summary>
    /// Classe que representa um cliente da agenda.
    /// </summary>
    public class Cliente
    {
        /// <summary>Nome do cliente.</summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>Telefone de contato do cliente.</summary>
        public string Telefone { get; set; } = string.Empty;

        /// <summary>
        /// Retorna o nome e telefone formatados para exibição nas listas da tela.
        /// </summary>
        public override string ToString()
        {
            return $"{Nome} ({Telefone})";
        }
    }
}