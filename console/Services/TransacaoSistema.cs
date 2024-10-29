namespace LegacySystem
{
    class TransacaoSistema
    {
        public List<Transacao> listaDeTransacoes = new List<Transacao>();

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            Transacao transacao = new Transacao(id, valor, descricao);
            listaDeTransacoes.Add(transacao);
        }

        public void ExibirTransacoes()
        {
            foreach (var transacao in listaDeTransacoes)
            {
                Console.WriteLine($"Id: {transacao.id}, Valor: {transacao.valor}, Descrição: {transacao.descricao}");
            }
        }
    }
}