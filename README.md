# ExErrorHandlingContaBancaria


## Descrição
Este projeto é um exemplo de tratamento de exceções em operações bancárias utilizando C# e .NET 8.0. O objetivo principal é criar um sistema robusto para lidar com erros comuns em contas bancárias, como números de conta inválidos e titulares não informados.

## Funcionalidades
- **Exceção `ContaInvalidaException`**: Lança exceções para números de conta nulos, vazios ou inválidos.
- **Exceção `TitularNaoInformadoException`**: Garante que o titular da conta seja informado, lançando exceções quando necessário.
- **Testes Unitários**: Implementação de testes unitários utilizando NUnit para garantir a confiabilidade e a robustez do sistema.
- **Blocos `Try-Catch-Finally`**: Demonstração prática do uso de blocos try-catch-finally para capturar e tratar exceções de forma eficiente.

## Tecnologias Utilizadas
- **C# 12.0**
- **.NET 8.0**
- **NUnit** para testes unitários

## Estrutura do Projeto

```plaintext
ExErrorHandlingContaBancaria/
│
├── ExErrorHandlingContaBancaria/
│   ├── ContaInvalidaException.cs
│   ├── TitularNaoInformadoException.cs
│   ├── ContaBancariaException.cs
│   └── Program.cs
│
├── ExErrorHandlingContaBancaria.Tests/
│   ├── ContaInvalidaExceptionTests.cs
│   └── TitularNaoInformadoExceptionTests.cs
│
└── ExErrorHandlingContaBancaria.sln

```

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/ExErrorHandlingContaBancaria.git

2. Caminhe ate o diretorio 
  ```bash
    cd ExErrorHandlingContaBancaria
```
## Testes
Para executar os testes unitários, siga os passos abaixo:

Navegue até o diretório dos testes:

  ```bash
  cd ExErrorHandlingContaBancaria.Tests
```
Execute os testes utilizando o NUnit:
  ```bash
  dotnet test
```

## Dia 2 programando continuamente até conseguir um emprego na área.
