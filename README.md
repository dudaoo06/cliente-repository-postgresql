# Trabalho de Banco de Dados - 2º Bimestre

Este repositório contém a implementação de um projeto prático em **C#** com integração ao **PostgreSQL**, desenvolvido como parte da avaliação do 2º bimestre da disciplina de **Banco de Dados** no curso de Análise e Desenvolvimento de Sistemas.

O objetivo do trabalho é demonstrar o domínio das operações básicas de persistência de dados através da implementação de três métodos que interagem com o banco de dados (Create, Read e Delete).

---

## 📌 Objetivo do Projeto

Desenvolver uma aplicação de console simples que permita:
- Cadastrar um novo cliente
- Listar os clientes cadastrados
- Deletar um cliente pelo ID

Os dados são armazenados e manipulados em um banco de dados PostgreSQL, utilizando comandos SQL através do driver **Npgsql**.

---

## 🧱 Estrutura do Projeto

ClienteRepositoryProjeto/
│
├── Program.cs # Interface de console para interação com o usuário
├── ClienteRepository.cs # Classe responsável pela comunicação com o banco de dados
└── README.md # Documentação do projeto

yaml
Copy
Edit

---

## ⚙️ Requisitos

Antes de rodar o projeto, certifique-se de ter:

- [.NET SDK](https://dotnet.microsoft.com/download) instalado
- PostgreSQL instalado e configurado
- Pacote NuGet [Npgsql](https://www.nuget.org/packages/Npgsql/) instalado:

```bash
dotnet add package Npgsql
🗃️ Estrutura da Tabela
Crie um banco de dados chamado sistema_chamados e execute o script abaixo para criar a tabela de clientes:

sql
Copy
Edit
CREATE TABLE clientes (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100)
);
🚀 Executando o Projeto
Clone o repositório e execute o projeto com os comandos abaixo:

bash
Copy
Edit
git clone https://github.com/seu-usuario/trabalho-bd-b2.git
cd trabalho-bd-b2
dotnet run
Você verá um menu de opções no console:

Copy
Edit
1 - Criar cliente
2 - Listar clientes
3 - Deletar cliente
💡 Funcionalidades
Criar Cliente
Solicita o nome e email e armazena os dados no banco.

Listar Clientes
Exibe todos os registros presentes na tabela clientes.

Deletar Cliente
Remove um cliente do banco com base no seu ID.

👩‍💻 Autora
Nome: Maria Eduarda Barro Novo

Turma: 3º ADS – Noite

📬 Contato
Caso tenha dúvidas ou sugestões, fique à vontade para abrir uma issue ou entrar em contato.
dudabarronovo06@gmail.com

