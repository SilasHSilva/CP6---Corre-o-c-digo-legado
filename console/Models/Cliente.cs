namespace LegacySystem
{
    class Cliente
    {
        public readonly int id;
        public readonly string nome;
        public readonly string email;
        public readonly DateTime dataDeCadastro;

        public Cliente(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            dataDeCadastro = DateTime.Now;
        }

        public void MudarNome(string nome)
        {
            if (!string.IsNullOrWhiteSpace(nome))
            {
                nome = nome;
            }
        }

        public void AtualizarEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
            {
                email = email;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Id: {id}, Nome: {nome}, Email: {email}, Cadastro: {dataDeCadastro}");
        }
    }
}


