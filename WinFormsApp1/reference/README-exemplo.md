<!--
  Este é o modelo de README do projeto.
  Preencha cada seção substituindo os trechos entre colchetes [ ... ].
  Apague estes comentários e as instruções em itálico antes de entregar.
  Um bom README permite que qualquer pessoa rode seu projeto sem te perguntar nada.
-->

# [Nome do Sistema]

[Uma frase explicando o que o sistema faz. Ex: "Sistema de gestão de chamados de suporte técnico com controle de acesso por papéis."]

---

## Sobre o projeto

[Um parágrafo curto descrevendo o domínio e o propósito do sistema. Para quem serve, que problema resolve.]

**Domínio:** [Ex: Gestão de Chamados]
**Dupla:** [Nome 1] e [Nome 2]

---

## Funcionalidades

- [ ] Cadastro, listagem, edição e exclusão de [entidade principal]
- [ ] Login com autenticação
- [ ] Controle de acesso por papéis (Visualizador, Operador, Admin)
- [ ] Senhas protegidas com BCrypt
- [ ] Persistência de dados em banco SQLite

[Adicione ou ajuste conforme o seu sistema.]

---

## Papéis de acesso

| Papel | O que pode fazer |
|-------|-----------------|
| Visualizador | [O que esse papel vê/faz no seu sistema] |
| Operador | [O que esse papel vê/faz no seu sistema] |
| Admin | [O que esse papel vê/faz no seu sistema] |

---

## Tecnologias usadas

- **Linguagem:** C#
- **Interface:** Windows Forms (.NET 8)
- **Banco de dados:** SQLite
- **Segurança:** BCrypt.Net-Next (hashing de senhas)

---

## Como rodar o projeto

### Pré-requisitos

- [Ex: Visual Studio 2022 com a carga "Desenvolvimento para Desktop com .NET"]
- [Ex: .NET 8 SDK]

### Passos

1. Clone o repositório:
   ```
   git clone [URL do seu repositório]
   ```
2. Abra o arquivo `[NomeDoProjeto].sln` no Visual Studio
3. Restaure os pacotes NuGet (o Visual Studio faz isso automaticamente ao abrir)
4. Rode com **F5**

> O banco de dados é criado automaticamente na primeira execução, junto com um usuário administrador inicial.

---

## Acesso inicial

Na primeira vez que o sistema roda, é criado um usuário administrador:

- **Login:** [ex: admin]
- **Senha:** [ex: admin123]

[Recomende trocar ou cadastrar novos usuários após o primeiro acesso.]

---

## Estrutura do projeto

```
[NomeDoProjeto]/
├── Models/        → classes de domínio
├── Data/          → conexão e criação do banco
├── Repositories/  → acesso ao banco (SQL)
├── Services/      → regras de negócio e autorização
├── Forms/         → telas do sistema
└── Program.cs     → ponto de entrada
```

---

## Instalação (versão .exe)

[Se você gerou o instalador com Inno Setup, explique aqui como instalar.]

1. Baixe o arquivo `[NomeDoInstalador].exe` na seção [Releases / pasta do projeto]
2. Execute o instalador e siga os passos
3. Abra o sistema pelo atalho criado

---

## Autores

- [Nome 1] — [GitHub ou contato]
- [Nome 2] — [GitHub ou contato]
