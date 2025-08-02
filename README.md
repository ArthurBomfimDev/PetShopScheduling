# PetShopScheduling - Sistema de Agendamento

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow) ![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet) ![C#](https://img.shields.io/badge/C%23-12-blue) ![Arquitetura](https://img.shields.io/badge/Arquitetura-Limpa-brightgreen) ![GitHub](https://img.shields.io/github/license/ArthurBomfimDev/PetShopScheduling)

## 📖 Sobre o Projeto

`PetShopScheduling` é um sistema de agendamento de serviços que está sendo desenvolvido com uma visão ambiciosa: ser uma plataforma **genérica, modular e adaptável** a qualquer tipo de negócio que opere com horários marcados.

A ideia central é fornecer um núcleo de agendamento sólido e permitir que funcionalidades específicas para cada ramo de atividade (como um **Pet Shop**, uma **Barbearia**, uma **Clínica** ou um **Estúdio de Tatuagem**) sejam acopladas através de módulos.

Este projeto serve como um estudo prático e portfólio, demonstrando a construção de um software flexível e escalável, aplicando princípios de **Arquitetura Limpa (Clean Architecture)** e padrões de design modernos.

## 🔭 Visão e Arquitetura Genérica

O maior diferencial do `PetShopScheduling` é sua arquitetura pensada para a extensibilidade.

* **Núcleo do Sistema (Core):** O núcleo contém todas as funcionalidades comuns e essenciais para qualquer agendamento:
    * Gestão de Usuários (Clientes e Prestadores de Serviço)
    * Cadastro de Serviços
    * Controle da Grade de Horários e Disponibilidade
    * Criação e Gestão de Agendamentos
    * Sistema de Notificações

* **Módulos de Negócio (Plugins):** Cada módulo adiciona as regras e campos específicos de um determinado negócio. Por exemplo:
    * **Módulo PetShop:** Adicionaria campos como `Nome do Pet`, `Espécie`, `Raça` e `Observações Veterinárias` ao agendamento.
    * **Módulo Barbearia:** Poderia incluir `Tipo de Serviço` (Corte, Barba), `Barbeiro Preferido` e histórico de cortes do cliente.
    * **Módulo Clínica:** Gerenciaria `Especialidade Médica`, `Prontuário do Paciente` e `Convênios`.

Essa abordagem garante que o sistema se mantenha limpo, coeso e fácil de estender, sem que as regras de um negócio interfiram nas de outro.

## ✨ Funcionalidades Planejadas

Como o projeto está em desenvolvimento, esta é a lista de funcionalidades planejadas.

### Funcionalidades do Núcleo
- [ ] CRUD completo de Clientes.
- [ ] CRUD de Serviços oferecidos.
- [ ] Gestão de múltiplos Prestadores de Serviço/Funcionários.
- [ ] Definição de horários de trabalho e folgas.
- [ ] Interface para o cliente final realizar e consultar seus agendamentos.
- [ ] Painel administrativo para gestão de todos os agendamentos.
- [ ] Sistema de notificação por e-mail (confirmação, lembrete).

### Exemplos de Funcionalidades Modulares
- [ ] (PetShop) Ficha de cadastro do animal.
- [ ] (Barbearia) Associação de serviço a um profissional específico.
- [ ] (Clínica) Anexar exames ao agendamento.

## 🚀 Tecnologias e Arquitetura

Para construir um sistema robusto e manutenível, estamos utilizando uma stack moderna e padrões de projeto consagrados pelo mercado.

* **Plataforma:** .NET 8.0 e C# 12
* **ORM:** Entity Framework Core 8.0
* **Arquitetura:** Princípios de Clean Architecture, com separação clara entre as camadas de Domínio, Aplicação, Infraestrutura e Apresentação.
* **Padrões de Design:**
    * **Service Layer:** Camada de serviços para orquestrar as regras de negócio.
    * **Repository & Unit of Work:** Abstração da camada de acesso a dados para garantir a consistência das transações.
    * **DTOs (Data Transfer Objects):** Objetos para a transferência de dados entre camadas de forma segura e otimizada.
    * **Sistema de Notificação:** Padrão para centralizar o feedback de validações e operações, evitando o lançamento excessivo de exceções.

## 🚧 Status do Projeto

**Este projeto está em fase ativa de desenvolvimento.** As funcionalidades do núcleo estão sendo construídas e a arquitetura modular está sendo refinada. Portanto, a `branch main` pode apresentar instabilidade. Sinta-se à vontade para explorar o código, mas não o utilize em produção.

## ⚙️ Como Executar o Projeto (Instruções Futuras)

As instruções detalhadas de como configurar e executar o projeto serão adicionadas assim que a primeira versão estável do núcleo for concluída. O processo seguirá o padrão:

1.  Clonar o repositório.
2.  Configurar a string de conexão com o banco de dados no `appsettings.json`.
3.  Executar as migrations do Entity Framework (`dotnet ef database update`).
4.  Executar o projeto.
