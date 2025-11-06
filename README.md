# Clean Architecture API

ASP.NET Core Web API built with Clean Architecture for study and learning purposes

### 

[English](#english) | [Português](#português)

<a name="english"></a>
## 🇺🇸 English

### 📋 Table of Contents
- [About](#about)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the Project](#running-the-project)
- [API Documentation](#api-documentation)
- [Project Structure](#project-structure)
- [Features](#features)

---

### 📖 About

This project is a **ASP.NET Core Web API** built following **Clean Architecture** principles. It was developed for study and learning purposes, demonstrating best practices in software architecture, CQRS pattern implementation with MediatR, and modern .NET development.

The API provides a complete CRUD system for user management with validation, mapping, and separation of concerns across different layers.

---

### 🏗️ Architecture

The project follows **Clean Architecture** principles with clear separation of concerns:

<image src="https://github.com/guilherme-rodrigues-de-queiroz/CleanArchitecture/blob/master/Image/BackImage.png"></image>

**Layers:**
- **Presentation**: API Controllers and configuration
- **Application**: Business logic, Use Cases, Validators, and Mappings
- **Domain**: Entities and Interfaces (business rules)
- **Infrastructure**: Data access, repositories, and external services

---

### 🚀 Technologies

#### Frameworks & Runtime
- **.NET 9.0** - Latest .NET framework
- **ASP.NET Core** - Web API framework
- **Entity Framework Core 9.0** - ORM for database access

#### Libraries & Packages
- **MediatR 13.1.0** - CQRS pattern implementation
- **AutoMapper 15.1.0** - Object-to-object mapping
- **FluentValidation 12.1.0** - Model validation
- **Pomelo.EntityFrameworkCore.MySql 9.0.0** - MySQL provider for EF Core
- **Scalar.AspNetCore 2.10.1** - Modern API documentation

#### Database
- **MySQL** - Relational database

#### Design Patterns
- **Clean Architecture** - Separation of concerns
- **CQRS** - Command Query Responsibility Segregation
- **Repository Pattern** - Data access abstraction
- **Unit of Work** - Transaction management
- **Mediator Pattern** - Request/Response handling

---

### ✅ Prerequisites

Before starting, make sure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or higher
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (version 8.0 or higher recommended)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

---

### 📥 Installation

1. **Clone the repository**
```bash
git clone https://github.com/guilherme-rodrigues-de-queiroz/CleanArchitecture.git
cd CleanArchitecture
```

2. **Configure the database connection**

Edit the `appsettings.json` file in `Presentation/CleanArchitecture.API/`:

```json
{
  "ConnectionStrings": {
    "MySQL": "Server=localhost;Database=YourDatabaseName;Uid=your_user;Pwd=your_password;"
  }
}
```

3. **Restore dependencies**
```bash
dotnet restore
```

4. **Build the project**
```bash
dotnet build
```

---

### ▶️ Running the Project

1. **Navigate to the API project folder**
```bash
cd Presentation/CleanArchitecture.API
```

2. **Run the application**
```bash
dotnet run
```

3. **The API will be available at:**
- HTTPS: `https://localhost:7xxx` (port may vary)
- HTTP: `http://localhost:5xxx` (port may vary)

The console will display the exact URLs when the application starts.

> **Note:** The database will be automatically created on first run thanks to `EnsureCreated()` in Program.cs.

---

### 📚 API Documentation

This project uses **Scalar** for API documentation, providing a modern and interactive interface.

#### Accessing Scalar Documentation

After running the project, access:
```
https://localhost:7xxx/scalar
```
or
```
http://localhost:5xxx/scalar
```

#### Available Endpoints

**Users API** (`/api/users`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/users` | Get all users |
| GET | `/api/users/{id}` | Get user by ID |
| POST | `/api/users` | Create new user |
| PUT | `/api/users/{id}` | Update user |
| DELETE | `/api/users/{id}` | Delete user |

#### Example Request (Create User)

```json
POST /api/users
Content-Type: application/json

{
  "email": "user@example.com",
  "name": "John Doe"
}
```

#### Example Response

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "email": "user@example.com",
  "name": "John Doe"
}
```

#### Validation Rules

**Email:**
- Required
- Must be a valid email format
- Maximum 50 characters

**Name:**
- Required
- Minimum 3 characters
- Maximum 50 characters

---

### 📁 Project Structure

```
CleanArchitecture/
│
├── Core/
│   ├── CleanArchitecture.Application/
│   │   ├── Services/              # Application services configuration
│   │   ├── Shared/
│   │   │   └── Behavior/          # MediatR pipeline behaviors
│   │   └── UseCases/              # CQRS Use Cases
│   │       ├── CreateUser/
│   │       │   ├── CreateUserHandler.cs
│   │       │   ├── CreateUserMapper.cs
│   │       │   ├── CreateUserRequest.cs
│   │       │   ├── CreateUserResponse.cs
│   │       │   └── CreateUserValidator.cs
│   │       ├── DeleteUser/
│   │       ├── GetAllUser/
│   │       ├── GetUserById/
│   │       └── UpdateUser/
│   │
│   └── CleanArchitecture.Domain/
│       ├── Entities/              # Domain entities
│       │   ├── BaseEntity.cs
│       │   └── User.cs
│       └── Interfaces/            # Repository interfaces
│           ├── IBaseRepository.cs
│           ├── IUnitOfWork.cs
│           └── IUserRepository.cs
│
├── Infrastructure/
│   └── CleanArchitecture.Persistence/
│       ├── Context/               # Database context
│       │   └── AppDbContext.cs
│       ├── Repositories/          # Repository implementations
│       │   ├── BaseRepository.cs
│       │   ├── UnitOfWork.cs
│       │   └── UserRepository.cs
│       └── ServiceExtensions.cs   # DI configuration
│
├── Presentation/
│   └── CleanArchitecture.API/
│       ├── Controllers/           # API Controllers
│       │   └── UsersController.cs
│       ├── Extensions/            # API extensions
│       │   └── CorsPolicyExtensions.cs
│       ├── appsettings.json       # Configuration
│       └── Program.cs             # Application entry point
│
└── Test/
    └── CleanArchitecture.Tests/   # Unit tests (not implemented)
```

---

### ✨ Features

#### Implemented
- ✅ Complete CRUD for Users
- ✅ Clean Architecture with clear layer separation
- ✅ CQRS pattern with MediatR
- ✅ Request validation with FluentValidation
- ✅ Automatic mapping with AutoMapper
- ✅ Repository Pattern and Unit of Work
- ✅ MySQL database integration
- ✅ Scalar API documentation
- ✅ CORS policy configuration
- ✅ Automatic database creation

#### Not Implemented (Future Improvements)
- ⚠️ Unit Tests
- ⚠️ Exception Handling middleware
- ⚠️ Logging
- ⚠️ Authentication/Authorization
- ⚠️ Pagination
- ⚠️ API Versioning
- ⚠️ Docker support

---

<a name="português"></a>
## 🇧🇷 Português

### 📋 Índice
- [Sobre](#sobre)
- [Arquitetura](#arquitetura-pt)
- [Tecnologias](#tecnologias-pt)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Executando o Projeto](#executando-o-projeto)
- [Documentação da API](#documentação-da-api)
- [Estrutura do Projeto](#estrutura-do-projeto-pt)
- [Funcionalidades](#funcionalidades)

---

### 📖 Sobre

Este projeto é uma **ASP.NET Core Web API** construída seguindo os princípios da **Arquitetura Limpa (Clean Architecture)**. Foi desenvolvido para fins de estudo e aprendizado, demonstrando boas práticas em arquitetura de software, implementação do padrão CQRS com MediatR e desenvolvimento moderno em .NET.

A API fornece um sistema CRUD completo para gerenciamento de usuários com validação, mapeamento e separação de responsabilidades entre diferentes camadas.

---

<a name="arquitetura-pt"></a>
### 🏗️ Arquitetura

O projeto segue os princípios da **Arquitetura Limpa** com clara separação de responsabilidades:

<image src="https://github.com/guilherme-rodrigues-de-queiroz/CleanArchitecture/blob/master/Image/BackImage.png"></image>

**Camadas:**
- **Apresentação**: Controllers da API e configurações
- **Aplicação**: Lógica de negócio, Casos de Uso, Validadores e Mapeamentos
- **Domínio**: Entidades e Interfaces (regras de negócio)
- **Infraestrutura**: Acesso a dados, repositórios e serviços externos

---

<a name="tecnologias-pt"></a>
### 🚀 Tecnologias

#### Frameworks & Runtime
- **.NET 9.0** - Framework .NET mais recente
- **ASP.NET Core** - Framework para Web API
- **Entity Framework Core 9.0** - ORM para acesso ao banco de dados

#### Bibliotecas & Pacotes
- **MediatR 13.1.0** - Implementação do padrão CQRS
- **AutoMapper 15.1.0** - Mapeamento objeto-para-objeto
- **FluentValidation 12.1.0** - Validação de modelos
- **Pomelo.EntityFrameworkCore.MySql 9.0.0** - Provider MySQL para EF Core
- **Scalar.AspNetCore 2.10.1** - Documentação moderna da API

#### Banco de Dados
- **MySQL** - Banco de dados relacional

#### Padrões de Projeto
- **Clean Architecture** - Separação de responsabilidades
- **CQRS** - Command Query Responsibility Segregation
- **Repository Pattern** - Abstração de acesso a dados
- **Unit of Work** - Gerenciamento de transações
- **Mediator Pattern** - Manipulação de Request/Response

---

### ✅ Pré-requisitos

Antes de começar, certifique-se de ter instalado:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (recomendado versão 8.0 ou superior)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

---

### 📥 Instalação

1. **Clone o repositório**
```bash
git clone https://github.com/guilherme-rodrigues-de-queiroz/CleanArchitecture.git
cd CleanArchitecture
```

2. **Configure a conexão com o banco de dados**

Edite o arquivo `appsettings.json` em `Presentation/CleanArchitecture.API/`:

```json
{
  "ConnectionStrings": {
    "MySQL": "Server=localhost;Database=NomeDoBanco;Uid=seu_usuario;Pwd=sua_senha;"
  }
}
```

3. **Restaure as dependências**
```bash
dotnet restore
```

4. **Compile o projeto**
```bash
dotnet build
```

---

### ▶️ Executando o Projeto

1. **Navegue até a pasta do projeto da API**
```bash
cd Presentation/CleanArchitecture.API
```

2. **Execute a aplicação**
```bash
dotnet run
```

3. **A API estará disponível em:**
- HTTPS: `https://localhost:7xxx` (a porta pode variar)
- HTTP: `http://localhost:5xxx` (a porta pode variar)

O console exibirá as URLs exatas quando a aplicação iniciar.

> **Nota:** O banco de dados será criado automaticamente na primeira execução graças ao `EnsureCreated()` no Program.cs.

---

### 📚 Documentação da API

Este projeto usa **Scalar** para documentação da API, fornecendo uma interface moderna e interativa.

#### Acessando a Documentação Scalar

Após executar o projeto, acesse:
```
https://localhost:7xxx/scalar
```
ou
```
http://localhost:5xxx/scalar
```

#### Endpoints Disponíveis

**API de Usuários** (`/api/users`)

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/users` | Buscar todos os usuários |
| GET | `/api/users/{id}` | Buscar usuário por ID |
| POST | `/api/users` | Criar novo usuário |
| PUT | `/api/users/{id}` | Atualizar usuário |
| DELETE | `/api/users/{id}` | Deletar usuário |

#### Exemplo de Requisição (Criar Usuário)

```json
POST /api/users
Content-Type: application/json

{
  "email": "usuario@exemplo.com",
  "name": "João Silva"
}
```

#### Exemplo de Resposta

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "email": "usuario@exemplo.com",
  "name": "João Silva"
}
```

#### Regras de Validação

**Email:**
- Obrigatório
- Deve ser um email válido
- Máximo de 50 caracteres

**Nome:**
- Obrigatório
- Mínimo de 3 caracteres
- Máximo de 50 caracteres

---

<a name="estrutura-do-projeto-pt"></a>
### 📁 Estrutura do Projeto

```
CleanArchitecture/
│
├── Core/
│   ├── CleanArchitecture.Application/
│   │   ├── Services/              # Configuração de serviços da aplicação
│   │   ├── Shared/
│   │   │   └── Behavior/          # Behaviors do pipeline MediatR
│   │   └── UseCases/              # Casos de Uso CQRS
│   │       ├── CreateUser/
│   │       │   ├── CreateUserHandler.cs
│   │       │   ├── CreateUserMapper.cs
│   │       │   ├── CreateUserRequest.cs
│   │       │   ├── CreateUserResponse.cs
│   │       │   └── CreateUserValidator.cs
│   │       ├── DeleteUser/
│   │       ├── GetAllUser/
│   │       ├── GetUserById/
│   │       └── UpdateUser/
│   │
│   └── CleanArchitecture.Domain/
│       ├── Entities/              # Entidades do domínio
│       │   ├── BaseEntity.cs
│       │   └── User.cs
│       └── Interfaces/            # Interfaces de repositório
│           ├── IBaseRepository.cs
│           ├── IUnitOfWork.cs
│           └── IUserRepository.cs
│
├── Infrastructure/
│   └── CleanArchitecture.Persistence/
│       ├── Context/               # Contexto do banco de dados
│       │   └── AppDbContext.cs
│       ├── Repositories/          # Implementações de repositório
│       │   ├── BaseRepository.cs
│       │   ├── UnitOfWork.cs
│       │   └── UserRepository.cs
│       └── ServiceExtensions.cs   # Configuração de DI
│
├── Presentation/
│   └── CleanArchitecture.API/
│       ├── Controllers/           # Controllers da API
│       │   └── UsersController.cs
│       ├── Extensions/            # Extensões da API
│       │   └── CorsPolicyExtensions.cs
│       ├── appsettings.json       # Configurações
│       └── Program.cs             # Ponto de entrada da aplicação
│
└── Test/
    └── CleanArchitecture.Tests/   # Testes unitários (não implementado)
```

---

### ✨ Funcionalidades

#### Implementadas
- ✅ CRUD completo para Usuários
- ✅ Clean Architecture com separação clara de camadas
- ✅ Padrão CQRS com MediatR
- ✅ Validação de requisições com FluentValidation
- ✅ Mapeamento automático com AutoMapper
- ✅ Repository Pattern e Unit of Work
- ✅ Integração com banco de dados MySQL
- ✅ Documentação da API com Scalar
- ✅ Configuração de política CORS
- ✅ Criação automática do banco de dados

#### Não Implementadas (Melhorias Futuras)
- ⚠️ Testes Unitários
- ⚠️ Middleware de tratamento de exceções
- ⚠️ Sistema de Logging
- ⚠️ Autenticação/Autorização
- ⚠️ Paginação
- ⚠️ Versionamento da API
- ⚠️ Suporte ao Docker
 
###

[![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![MySQL](https://img.shields.io/badge/MySQL-Database-4479A1?logo=mysql&logoColor=white)](https://www.mysql.com/)
