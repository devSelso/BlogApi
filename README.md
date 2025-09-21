# BlogApi: API REST para Gerenciamento de um Blog

![Status: Concluído](https://img.shields.io/badge/status-concluído-brightgreen)

API RESTful desenvolvida como parte dos meus estudos no ecossistema .NET. O projeto consiste em um back-end para um sistema de blog, permitindo a criação, leitura, atualização e exclusão de postagens.

---

## 🚀 Funcionalidades

A API oferece os seguintes endpoints para gerenciar postagens:

* **`GET /api/posts`**: Retorna uma lista com todas as postagens.
* **`GET /api/posts/{id}`**: Retorna uma postagem específica pelo seu ID.
* **`POST /api/posts`**: Cria uma nova postagem.
* **`PUT /api/posts/{id}`**: Atualiza uma postagem existente.
* **`DELETE /api/posts/{id}`**: Deleta uma postagem.

---

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído utilizando as seguintes tecnologias e conceitos:

* **.NET 8** e **ASP.NET Core Web API**: Framework para a construção da API.
* **C#**: Linguagem de programação principal.
* **Entity Framework Core 8**: ORM para comunicação com o banco de dados (Code-First).
* **SQLite**: Banco de dados relacional leve e baseado em arquivo.
* **Padrão REST**: Arquitetura para a criação dos endpoints.
* **DTO (Data Transfer Objects)**: Padrão para proteger e modelar os dados transferidos pela API.
* **Injeção de Dependência**: Padrão para gerenciar as dependências (ex: `BlogContext`).
* **Swagger/OpenAPI**: Para documentação e testes interativos da API.

---

## ⚙️ Como Executar o Projeto

Siga os passos abaixo para rodar a aplicação localmente.

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina:
* [.NET 8 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)

### Passo a Passo

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/devselso/blogapi.git](https://github.com/devselso/blogapi.git)
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd BlogApi
    ```

3.  **Restaure as dependências do projeto:**
    ```bash
    dotnet restore
    ```

4.  **Aplique as migrations para criar o banco de dados:**
    *(Este comando cria o arquivo `blog.db` com as tabelas `Posts` e `Comentarios`)*
    ```bash
    dotnet ef database update
    ```

5.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

6.  **Acesse e teste no Swagger:**
    * Após a execução, a aplicação estará disponível em `https://localhost:PORTA` (a porta pode variar).
    * Acesse a documentação interativa do Swagger em `https://localhost:PORTA/swagger` para testar todos os endpoints.

---

## 👨‍💻 Autor

Desenvolvido por **[Selso Pacheco dos Santos Júnior]**.

[<img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/pachecoselso/)