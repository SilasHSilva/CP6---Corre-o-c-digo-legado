using Xunit;
using LegacySystem;

public class ClienteSistemaTests
{
    [Fact]
    public void AddCliente_Deve_Adicionar_Cliente_Ao_Sistema()
    {
        // Arrange
        ClienteSistema clienteSistema = new ClienteSistema();

        // Act
        clienteSistema.AddCliente(1, "ClienteTeste", "cliente@email.com");

        // Assert
        Assert.Single(clienteSistema.clientes);
    }

    [Fact]
    public void RemoverCliente_Deve_Remover_Cliente_Por_Id()
    {
        // Arrange
        ClienteSistema clienteSistema = new ClienteSistema();
        clienteSistema.AddCliente(1, "ClienteTeste", "cliente@email.com");

        // Act
        clienteSistema.RemoverCliente(1);

        // Assert
        Assert.Empty(clienteSistema.clientes);
    }

    [Fact]
    public void AtualizarNomeCliente_Deve_Atualizar_Nome_Cliente()
    {
        // Arrange
        ClienteSistema clienteSistema = new ClienteSistema();
        clienteSistema.AddCliente(1, "ClienteAntigo", "cliente@email.com");

        // Act
        clienteSistema.AtualizarNomeCliente(1, "ClienteNovo");

        // Assert
        Assert.Equal("ClienteNovo", clienteSistema.clientes[0].nome);
    }
}
