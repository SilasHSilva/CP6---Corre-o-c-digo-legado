namespace LegacySystem
{
    class Transacao
    {
        public readonly int id;
        public readonly decimal valor;
        public readonly DateTime data;
        public readonly string descricao;

        public Transacao(int id, decimal valor, string descricao)
        {
            this.id = id;
            this.valor = valor;
            this.data = DateTime.Now;
            this.descricao = descricao;
        }

        public void exibirTransacao()
        {
            Console.WriteLine($"Id: {id}, Valor: {valor}, Descricao: {descricao}, Data: {data}");
        }
    }
}