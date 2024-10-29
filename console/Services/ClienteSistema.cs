namespace LegacySystem
{
    class ClienteSistema
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void AddCliente(int id, string nome, string email)
        {
            clientes.Add(new Cliente(id, nome, email));
        }

        public void RemoverCliente(int id)
        {
            Cliente cliente = clientes.Find(x => x.id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }

        public void ExibirTodosOsClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Id: {cliente.id}, Nome: {cliente.nome}, Email: {cliente.email}");
            }
        }

        public void AtualizarNomeCliente(int id, string nome)
        {
            Cliente cliente = clientes.Find(x => x.id == id);
            if (cliente != null)
            {
                cliente.MudarNome(nome);
            }
        }
    }
}