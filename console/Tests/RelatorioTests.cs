using Xunit;
using LegacySystem;

public class RelatorioTests
{
    [Fact]
    public void GerarRelatorioCliente_Deve_Exibir_Relatorio_Com_Dados_Do_Cliente()
    {
        // Arrange
        Relatorio relatorio = new Relatorio();
        List<Cliente> clientes = new List<Cliente>
        {
            new Cliente(1, "Cliente1", "cliente1@email.com"),
            new Cliente(2, "Cliente2", "cliente2@email.com")
        };

        // Act & Assert
        relatorio.GerarRelatorioCliente(clientes);
    }
}
