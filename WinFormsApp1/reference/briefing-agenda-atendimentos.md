# Projeto — Agenda de Atendimentos

## Contexto

Uma pequena prestadora de serviços — barbearia, salão, clínica estética, consultório — precisa de um sistema para organizar seus atendimentos. Hoje tudo é feito no papel ou em anotações no celular, e os horários se perdem, os clientes esquecem, e o profissional não sabe o que tem no dia.

Você vai construir um sistema desktop para resolver esse problema.

---

## O sistema

Um gerenciador de agenda que permite cadastrar clientes, cadastrar os serviços oferecidos, agendar atendimentos e visualizar o que tem no dia.

---

## Requisitos

### Clientes
- Cadastrar um novo cliente com nome e telefone
- Listar todos os clientes cadastrados

### Serviços
- Cadastrar um novo serviço com nome e preço
- Listar todos os serviços cadastrados

### Agendamentos
- Criar um novo agendamento informando: cliente, serviço, data e horário
- Listar os agendamentos de um dia específico
- Cada agendamento nasce com o status **Agendado**

---

## Classes mínimas esperadas

Você deve ter ao menos estas três classes no seu projeto, cada uma com suas responsabilidades bem definidas:

`Cliente` — representa um cliente do estabelecimento

`Servico` — representa um serviço oferecido

`Agendamento` — representa um atendimento marcado, ligando cliente e serviço a uma data e horário

---

## Critérios de aceite

O projeto será avaliado com base nos seguintes pontos:

- [ ] É possível cadastrar um cliente e vê-lo na listagem
- [ ] É possível cadastrar um serviço e vê-lo na listagem
- [ ] É possível criar um agendamento com cliente, serviço, data e horário
- [ ] A agenda do dia exibe os agendamentos daquela data
- [ ] As classes têm responsabilidades claras e separadas
- [ ] O projeto roda sem erros

---

## Regras gerais

- O projeto é individual
- Use C# com Windows Forms
- Suba o código no GitHub desde o primeiro dia — commit a cada avanço significativo
- Não é necessário salvar os dados em arquivo — os dados podem existir apenas enquanto o programa estiver aberto
- A interface não precisa ser bonita, precisa funcionar
