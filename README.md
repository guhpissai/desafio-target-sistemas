# Desafio Técnico - Target Sistemas 🎯

![Status](https://img.shields.io/badge/Status-Concluído-green)
![Language](https://img.shields.io/badge/Language-C%23-purple)
![Framework](https://img.shields.io/badge/.NET-9.0-blue)

Este repositório contém a solução para o desafio técnico da **Target Sistemas**, implementada como uma aplicação de Console em **C# (.NET)**. 

O foco do projeto não foi apenas resolver a lógica, mas demonstrar conhecimentos em **Arquitetura de Software**, **SOLID**, **Clean Code** e manipulação de arquivos.

## 🚀 Funcionalidades Implementadas

O sistema conta com um menu interativo que gerencia os seguintes módulos:

### 1. 💰 Calculadora de Comissão
- Processamento de listas de vendas utilizando **LINQ**.
- Regras de negócio isoladas via **Strategy Pattern**.
- Arredondamento financeiro preciso (`MidpointRounding.AwayFromZero`).
- Relatório agrupado por vendedor e ordenado por desempenho.

### 2. 📦 Gerenciador de Estoque (Persistência JSON)
- Sistema de **CRUD** (Entrada e Saída de produtos).
- **Persistência de dados** em arquivos JSON (`System.Text.Json`).
- Histórico de movimentações (Log de auditoria).
- Tratamento de exceções e validação de estoque negativo.

### 3. 📅 Calculadora de Juros e Multas
- Cálculo de dias de atraso e aplicação de taxas.
- Validação robusta de datas e valores monetários.
- Arquitetura desacoplada permitindo fácil troca das regras de juros.

---

## 🛠️ Tecnologias e Práticas Utilizadas

* **Linguagem:** C# (Latest)
* **Framework:** .NET 9.0
* **Armazenamento:** JSON (File System)
* **Conceitos Aplicados:**
    * ✅ **MVC (Model-View-Controller):** Separação clara entre Interface (Views), Lógica (Services) e Dados (Models).
    * ✅ **SOLID:** Injeção de Dependência manual e Princípio da Responsabilidade Única (SRP).
    * ✅ **Strategy Pattern:** Utilizado nas regras de cálculo (Multas/Comissões) para facilitar manutenção.
    * ✅ **Clean Code:** Nomenclatura descritiva, *Early Return* e métodos pequenos.

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
* [.NET SDK](https://dotnet.microsoft.com/download) instalado.
* Visual Studio 2022 ou VS Code.

### Passo a Passo

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/guhpissai/desafio-target-sistemas.git](https://github.com/guhpissai/desafio-target-sistemas.git)
    cd desafio-target-sistemas
    ```

2.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

---

## ⚠️ Configuração Importante para Visual Studio

Se você estiver utilizando o **Visual Studio 2022** (não o VS Code), é necessário configurar o diretório de execução para que o sistema leia e grave os arquivos JSON na pasta correta.

Por padrão, o VS roda o projeto na pasta `bin/Debug`, o que cria cópias dos arquivos de dados. Para fixar a persistência na raiz do projeto:

1.  Clique na seta ao lado do nome do projeto (botão de **Play/Iniciar**).
2.  Selecione **Propriedades de Depuração** (Debug Properties).
3.  Procure pelo campo **Diretório de Trabalho** (Working Directory).
4.  Defina o caminho para a **pasta raiz do projeto** (onde está o arquivo `.csproj`).
    * *Dica:* Você pode usar a macro `$(ProjectDir)`.

Isso garante que as alterações no estoque sejam refletidas imediatamente no arquivo `Data/estoque.json` visível no seu editor.

## 📂 Estrutura do Projeto

```bash
DesafioTarget/
├── 📂 Data/             # Arquivos JSON (Banco de dados local)
├── 📂 Helpers/          # Utilitários (JsonHelper, ConsoleHelper)
├── 📂 Interfaces/       # Contratos para aplicar Inversão de Dependência
├── 📂 Models/           # Objetos de domínio (Estoque, Venda, Produto)
├── 📂 Services/         # Regras de Negócio (Lógica pesada)
├── 📂 Views/            # Interação com o usuário (Console)
└── 📄 Program.cs        # Ponto de entrada
```

---

---

## 👨‍💻 Autor

Desenvolvido por **Gustavo Pio Pissai**.

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/gustavo-pio-pissai/)
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/guhpissai)

