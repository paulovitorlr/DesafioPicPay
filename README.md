# 💸 PicPay Simplificado

Implementação do [Desafio Backend do PicPay](https://github.com/PicPay/picpay-desafio-backend) em **ASP.NET Core** com **C#**.

---

## 📋 Sobre o desafio

O desafio consiste em criar uma versão simplificada do PicPay, onde é possível cadastrar usuários e realizar transferências de dinheiro entre eles. Antes de cada transferência, um serviço autorizador externo é consultado, e o usuário recebe uma notificação ao receber um valor.

---

## 🚀 Funcionalidades

- Cadastro de usuários (CPF e CNPJ)
- Autenticação por e-mail e senha
- Transferência de saldo entre usuários
- Validação de saldo antes da transferência
- Consulta a autorizador externo antes de efetivar a transação
- Notificação por e-mail após transferência concluída

---

## 🛠️ Tecnologias

- [.NET 10](https://dotnet.microsoft.com/)
- [ASP.NET Core](https://learn.microsoft.com/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/ef/core)
- [PostgreSQL](https://www.postgresql.org/)
- [Npgsql](https://www.npgsql.org/)

---

## 📁 Estrutura do projeto

```
PicPay.Api/
├── Controllers/
│   ├── Controller-Auth/       # Endpoints de autenticação
│   └── Controller-Transfer/   # Endpoint de transferência
├── DTOs/
│   ├── DTO-Auth/              # RegisterDTO, LoginDTO
│   └── DTO-Transfer/          # TransferDTO
├── Data/
│   └── AppDbContext.cs        # Contexto do EF Core
├── Model/
│   └── User.cs                # Entidade de usuário
├── Repositories/
│   ├── AuthRepository.cs      # Acesso a dados de autenticação
│   └── Transfer-Repositories/ # Acesso a dados de transferência
├── Services/
│   ├── Auth-Services/         # Regras de negócio de autenticação
│   └── Transfer-Service/      # Regras de negócio de transferência
├── appsettings.Example.json   # Exemplo de configuração
└── Program.cs
```

---

## ⚙️ Como rodar localmente

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)

### Passos

**1. Clone o repositório**

```bash
git clone https://github.com/seu-usuario/seu-repo.git
cd seu-repo/PicPay.Api
```

**2. Configure o banco de dados**

Copie o arquivo de exemplo e preencha com suas credenciais:

```bash
cp appsettings.Example.json appsettings.json
```

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=picpay;Username=SEU_USUARIO;Password=SUA_SENHA"
  }
}
```

**3. Aplique as migrations**

```bash
dotnet ef database update
```

**4. Rode o projeto**

```bash
dotnet run
```

A API estará disponível em `https://localhost:7119`.

---

## 📡 Endpoints

### Autenticação

| Método | Rota | Descrição |
|--------|------|-----------|
| POST | `/api/auth/register` | Cadastrar usuário |
| POST | `/api/auth/login` | Autenticar usuário |

**Cadastro**
```json
POST /api/auth/register
{
  "fullName": "João Silva",
  "email": "joao@teste.com",
  "document": "12345678901",
  "password": "123456"
}
```

**Login**
```json
POST /api/auth/login
{
  "email": "joao@teste.com",
  "password": "123456"
}
```

---

### Transferência

| Método | Rota | Descrição |
|--------|------|-----------|
| POST | `/api/transfer` | Realizar transferência |

```json
POST /api/transfer
{
  "payer": 1,
  "payee": 2,
  "value": 50.00
}
```

---

## 🔒 Serviços externos

| Serviço | URL |
|--------|-----|
| Autorizador | `https://util.devi.tools/api/v2/authorize` |
| Notificação | `https://util.devi.tools/api/v1/notify` |

---

## 📌 Observações

- Documentos com 11 dígitos são classificados como **CPF**, com 14 dígitos como **CNPJ**
- Todo usuário começa com saldo de **R$ 100,00**
- A transferência só é efetivada após autorização do serviço externo
- O arquivo `appsettings.json` está no `.gitignore` — nunca suba credenciais reais
