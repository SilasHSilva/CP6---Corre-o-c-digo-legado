using Xunit;
using LegacySystem;

public class TransacaoSistemaTests
{
    [Fact]
    public void AdicionarTransacao_Deve_Adicionar_Nova_Transacao()
    {
        // Arrange
        TransacaoSistema transacaoSistema = new TransacaoSistema();

        // Act
        transacaoSistema.AdicionarTransacao(1, 100.0m, "Teste de Transacao");

        // Assert
        Assert.Single(transacaoSistema.listaDeTransacoes);
    }

    [Fact]
    public void ExibirTransacoes_Deve_Exibir_Transacoes_No_Console()
    {
        // Arrange
        TransacaoSistema transacaoSistema = new TransacaoSistema();
        transacaoSistema.AdicionarTransacao(1, 100.0m, "Teste de Transacao");

        // Act & Assert
        Assert.Collection(transacaoSistema.listaDeTransacoes,
            item => Assert.Equal("Teste de Transacao", item.descricao));
    }
}
