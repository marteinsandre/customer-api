# Customer API

API RESTful para gestão de clientes, desenvolvida em C# .NET Core seguindo boas práticas de Clean Architecture, SOLID e Clean Code.

## Funcionalidades
- Cadastro de clientes
- Consulta de clientes
- Atualização de dados
- Remoção de clientes

## Endpoints
- `GET /api/clientes` — Lista todos os clientes
- `GET /api/clientes/{id}` — Busca cliente por ID
- `POST /api/clientes` — Cria novo cliente
- `PUT /api/clientes/{id}` — Atualiza cliente existente
- `DELETE /api/clientes/{id}` — Remove cliente

## Como executar
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. No terminal, navegue até o diretório do projeto:
   ```sh
   cd CustomerApi
   dotnet run
   ```
3. Acesse o Swagger para testar os endpoints:
   - `https://localhost:{porta}/swagger`

## Estrutura do Projeto
- `Controllers/` — Controllers da API
- `Models/` — Entidades de domínio
- `Services/` — Lógica de negócio e manipulação de dados

## Observações
- Os dados são mantidos em memória (não persistem após reiniciar a aplicação).
- Documentação dos métodos e entidades em português.

---
Desenvolvido seguindo padrões profissionais para fácil manutenção e extensão.
