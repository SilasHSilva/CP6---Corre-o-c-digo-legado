using Xunit;
using LegacySystem;

public class ClienteTests
{
    [Fact]
    public void Cliente_Deve_Ser_Criado_Com_Propriedades_Corretas()
    {
        // Arrange
        int id = 1;
        string nome = "Teste";
        string email = "teste@email.com";

        // Act
        Cliente cliente = new Cliente(id, nome, email);

        // Assert
        Assert.Equal(id, cliente.id);
        Assert.Equal(nome, cliente.nome);
        Assert.Equal(email, cliente.email);
        Assert.Equal(DateTime.Now.Date, cliente.dataDeCadastro.Date);
    }

    [Fact]
    public void MudarNome_Deve_Atualizar_Nome_Quando_Valor_Valido()
    {
        // Arrange
        Cliente cliente = new Cliente(1, "AntigoNome", "teste@email.com");

        // Act
        cliente.MudarNome("NovoNome");

        // Assert
        Assert.Equal("NovoNome", cliente.nome);
    }

    [Fact]
    public void MudarNome_Nao_Deve_Atualizar_Para_Nome_Invalido()
    {
        // Arrange
        Cliente cliente = new Cliente(1, "NomeInicial", "teste@email.com");

        // Act
        cliente.MudarNome("");

        // Assert
        Assert.Equal("NomeInicial", cliente.nome);
    }

    [Fact]
    public void AtualizarEmail_Deve_Atualizar_Quando_Email_Valido()
    {
        // Arrange
        Cliente cliente = new Cliente(1, "Teste", "teste@email.com");

        // Act
        cliente.AtualizarEmail("novo@email.com");

        // Assert
        Assert.Equal("novo@email.com", cliente.email);
    }

    [Fact]
    public void AtualizarEmail_Nao_Deve_Atualizar_Para_Email_Invalido()
    {
        // Arrange
        Cliente cliente = new Cliente(1, "Teste", "teste@email.com");

        // Act
        cliente.AtualizarEmail("emailinvalido");

        // Assert
        Assert.Equal("teste@email.com", cliente.email);
    }
}
