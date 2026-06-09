namespace AgendaAtendimentos
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        // Isso serve para o cliente aparecer de forma bonita nas listagens da tela
        public override string ToString()
        {
            return $"{Nome} ({Telefone})";
        }
    }
}