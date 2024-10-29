namespace LegacySystem
{
    class MainSistema
    {
        static void Main(string[] args)
        {
            ClienteSistema clienteSistema = new ClienteSistema();
            clienteSistema.AddCliente(1, "Joao", "joao@email.com");
            clienteSistema.AddCliente(2, "Maria", "maria@email.com");

            TransacaoSistema transacaoSistema = new TransacaoSistema();
            transacaoSistema.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            transacaoSistema.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            transacaoSistema.AdicionarTransacao(3, 300.75m, "Compra de Software");

            clienteSistema.ExibirTodosOsClientes();
            transacaoSistema.ExibirTransacoes();

            clienteSistema.RemoverCliente(1);
            clienteSistema.ExibirTodosOsClientes();

            clienteSistema.AtualizarNomeCliente(2, "Maria Silva");

            Relatorio relatorio = new Relatorio();
            relatorio.GerarRelatorioCliente(clienteSistema.clientes);
            relatorio.GerarRelatorioCliente(clienteSistema.clientes);
            relatorio.GerarRelatorioCliente(clienteSistema.clientes);

        }
    }
}