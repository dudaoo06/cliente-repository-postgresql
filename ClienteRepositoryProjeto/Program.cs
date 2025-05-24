using System;

class Program
{
    static void Main(string[] args)
    {
        ClienteRepository repo = new ClienteRepository();

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Criar cliente");
        Console.WriteLine("2 - Listar clientes");
        Console.WriteLine("3 - Deletar cliente");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                repo.CriarCliente(nome, email);
                Console.WriteLine("Cliente criado com sucesso!");
                break;

            case "2":
                Console.WriteLine("Lista de clientes:");
                repo.ListarClientes();
                break;

            case "3":
                Console.Write("ID do cliente a ser deletado: ");
                int id = int.Parse(Console.ReadLine());
                repo.DeletarCliente(id);
                Console.WriteLine("Cliente deletado com sucesso!");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}