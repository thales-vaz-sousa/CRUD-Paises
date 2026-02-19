# 🌍 Gerenciador de Países (CRUD) - Desafio Técnico #1

Nesse Projeto foi me pedido um sistema de gerenciamento de países MVC desenvolvido em C# utilizando uma das plataforma de interface para desenvolvimento na mesma. Escolhi ASP.NET Core MVC por o tema de tempo e também por ser multiplataforma, já que estava desenvolvendo no linux POP_OS. 

O sistema permite realizar todas as operações de CRUD (Criar, Visualizar, Editar e Excluir) em um banco de dados local. 

## 🛠️ Tecnologias Utilizadas
- **Linguagem**: C# (.NET 10)
- **Framework (Interface)**: ASP.NET Core MVC
- **Banco de Dados**: SQLite (Arquivo local para fácil portabilidade e desenvolvimento)
- **Interface**: Web Gráfica estilizada com Bootstrap 5 nos elementos (botões, lista e fonte)

## 📌 Funcionalidades Principais
- **CRUD Completo**: Gestão total dos registros de países.
- **Barra de Busca**: Filtro dinâmico por Nome ou Continente.
- **Localização PT-BR**: Configuração de formatação brasileira para exibição correta de datas (`dd/mm/aaaa`) e separadores decimais.
- **Armazenamento Local**: Uso de SQLite, dispensa a instalação de servidores de banco de dados externos.

## 🚀 Requisitos para Rodar o Projeto

Para executar o programa no seu ambiente, siga os passos abaixo:

### 1. Pré-requisitos
- Ter o **SDK do .NET 10** instalado. (Você poderá verificar com o comando `dotnet --version`).
- Git instalado para clonar o repositório.

### 2. Passo a Passo

1. **Clonar o Repositório**:
    
	Bash:  `git clone [https://github.com/thales-vaz-sousa/CRUD-Paises.git](https://github.com/thales-vaz-sousa/CRUD-Paises.git)`
      
2. **Entrar na pasta do projeto**:
    
    Bash:     `cd CRUD-Paises/desafio_paises`
    
3. **Restaurar dependências e rodar**:
    
	Bash: `dotnet watch run`
    
4. **Acesse no navegador**: O terminal indicará a porta (ex: `http://localhost:5000` ou `https://localhost:7001`).
    

## 📁 Estrutura do Banco

O arquivo de banco de dados (`paises.db`) está incluído no repositório com dados de países exemplo. Caso deseje resetar, as Migrations do Entity Framework estão configuradas inicializar novamente ao reiniciar o webapp.

---

**by: Thales Vaz Sousa**