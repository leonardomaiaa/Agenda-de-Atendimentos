namespace AgendaAtendimentos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        // Isso serve para o cliente aparecer de forma bonita nas listagens da tela
        public override string ToString()
        {
            return $"{Nome} ({Telefone})";
        }
    }
}