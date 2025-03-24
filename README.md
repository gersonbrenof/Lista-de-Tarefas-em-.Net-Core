# Lista de Tarefas API

Este é um projeto de API para gerenciar uma lista de tarefas. A API permite criar tarefas e obter todas as tarefas salvas no banco de dados SQLite.

## Funcionalidades

- **GET** `/api/tarefas` - Retorna todas as tarefas armazenadas.
- **POST** `/api/tarefas` - Adiciona uma nova tarefa à lista.

Cada tarefa possui um título, uma descrição e um campo de conclusão (booleano). Por padrão, o campo `Concluido` é `false` quando uma nova tarefa é criada.

## Tecnologias Usadas

- **ASP.NET Core 8**
- **Entity Framework Core**
- **SQLite**
- **Swagger** para documentação da API

## Como Rodar o Projeto

### 1. Clonar o repositório

Clone este repositório para o seu computador.

```bash
git clone https://github.com/seu-usuario/ListaDeTarefas.git
cd ListaDeTarefas
dotnet restore
dotnet run
