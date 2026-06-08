namespace AgendaAtendimentos
{
    public class Servico
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}