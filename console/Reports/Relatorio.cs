namespace LegacySystem
{

    class Relatorio
    {
        public void GerarRelatorioCliente(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Cliente: {cliente.nome} | Email: {cliente.email}");
            }
        }
    }
}