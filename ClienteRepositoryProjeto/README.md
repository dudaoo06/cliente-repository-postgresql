# Projeto - ClienteRepository com PostgreSQL

Este projeto foi desenvolvido como parte do trabalho do 2º bimestre da disciplina de **Banco de Dados**.  
Consiste em um sistema simples em **C#** que realiza operações de **CRUD** (Create, Read, Delete) em uma tabela de clientes, utilizando o banco de dados **PostgreSQL**.

## Requisitos

- .NET SDK instalado
- PostgreSQL instalado e em execução
- Pacote NuGet Npgsql instalado

Você pode instalar o Npgsql com o seguinte comando:

```bash
dotnet add package Npgsql
```

## Configuração do Banco de Dados

Certifique-se de que o PostgreSQL está com um banco de dados chamado `sistema_chamados` e que existe uma tabela chamada `clientes` com a seguinte estrutura:

```sql
CREATE TABLE clientes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100)
);
```

## Classe Implementada

A classe `ClienteRepository` contém os seguintes métodos:

- `CriarCliente(string nome, string email)`: Adiciona um novo cliente à base de dados.
- `ListarClientes()`: Lista todos os clientes cadastrados.
- `DeletarCliente(int id)`: Remove um cliente pelo ID.

## Como Executar

Execute o projeto com o seguinte comando:

```bash
dotnet run
```

Você verá um menu com as opções para criar, listar ou deletar clientes.
