### Integrantes
- Renan da Silva Paulino - RM566610
- Paulo Cavalcante Caroba - RM566667

## Github do Repositório

[Acesse o repositório](https://github.com/cavalcantecpaulo/Cp1.Net)


## Projeto Calculadora Semi-Científica

Programa em linguagem C# do tipo Windows Forms, desenvolvido no Visual Studio 2022, para executar a funcionalidade de uma calculadora básica "semi-científica": entrada dos números de 0 a 9, operações aritméticas básicas (soma, subtração, multiplicação e divisão), raiz quadrada (√y), potenciação (x^y), botão de igual (=) para exibir o resultado, e botão de reset/clear (C) para limpar o visor. Possui também uma tela "Sobre" com os integrantes do grupo e o link deste repositório.

### Funcionalidades

- Botões numéricos de 0 a 9 e vírgula decimal.
- Visor com o resultado alinhado à direita, exibindo o operador pendente enquanto aguarda o próximo número.
- Botão de apagar último dígito, para correção de erros de digitação.
- Operações aritméticas básicas.
- Raiz quadrada (√x).
- Potenciação (x^y).
- Botão de igual para exibir o resultado da conta.
- Botão de reset/clear (C) para limpar o visor e reiniciar a conta.
- Tratamento de erros: raiz de número negativo, divisão por zero e outras operações inválidas exibem `"Erro"` no visor.
- Mensagem de boas-vindas rápida ("Tranquilo!") ao abrir o aplicativo.

### Estrutura do projeto

- `Form1.cs` / `Form1.Designer.cs` — tela principal da calculadora: interface e toda a lógica de estado das operações.
- `Program.cs` — ponto de entrada da aplicação.

### Como executar

1. Abra `CalculadoraCP1.slnx` no Visual Studio.
2. Pressione F5 (ou "Iniciar") para compilar e executar.

### Decisões de projeto

- A conta é resolvida de forma imediata, sem respeitar ordem de precedência entre operações.
- Os operandos são armazenados como `double`, permitindo casas decimais e valores negativos como resultado.
