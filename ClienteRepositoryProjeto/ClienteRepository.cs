using Npgsql;
using System;

public class ClienteRepository
{
    private readonly string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=sistema_chamados";

    public void CriarCliente(string nome, string email)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();
        using var cmd = new NpgsqlCommand("INSERT INTO clientes (nome, email) VALUES (@nome, @email)", conn);
        cmd.Parameters.AddWithValue("nome", nome);
        cmd.Parameters.AddWithValue("email", email);
        cmd.ExecuteNonQuery();
    }

    public void ListarClientes()
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();
        using var cmd = new NpgsqlCommand("SELECT id, nome, email FROM clientes", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader.GetInt32(0)} | Nome: {reader.GetString(1)} | Email: {reader.GetString(2)}");
        }
    }

    public void DeletarCliente(int id)
    {
        using var conn = new NpgsqlConnection(connectionString);
        conn.Open();
        using var cmd = new NpgsqlCommand("DELETE FROM clientes WHERE id = @id", conn);
        cmd.Parameters.AddWithValue("id", id);
        cmd.ExecuteNonQuery();
    }
}