namespace AgendaAtendimentos
{
    /// <summary>
    /// Classe que representa um serviço oferecido.
    /// </summary>
    public class Servico
    {
        /// <summary>Nome do serviço.</summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>Preço cobrado pelo serviço.</summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Retorna o nome e o preço formatados para exibição nas listas da tela.
        /// </summary>
        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}