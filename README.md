# Calculadora em Windows Forms

Este é um projeto de uma calculadora simples desenvolvida em C# utilizando Windows Forms. A calculadora realiza operações básicas como adição, subtração, multiplicação e divisão.

## Funcionalidades

- **Operações básicas**: Adição (+), subtração (-), multiplicação (*) e divisão (/).
- **Entrada de números**: Suporte para números inteiros e decimais (usando vírgula como separador decimal).
- **Limpeza**: Botão para limpar a tela e reiniciar os cálculos.
- **Exibição de resultados**: O resultado é exibido na mesma caixa de texto onde os números são digitados.

## Como funciona

A calculadora funciona da seguinte maneira:

1. O usuário digita um número.
2. Seleciona uma operação (+, -, *, /).
3. Digita o segundo número.
4. Clica no botão "=" para obter o resultado.

Se o usuário tentar dividir por zero, a calculadora exibirá uma mensagem de erro.

## Estrutura do código

O código principal está no arquivo `Form1.cs`. Aqui estão os principais componentes:

- **Variáveis de controle**:
  - `primeiroNumero` e `segundoNumero`: Armazenam os valores digitados pelo usuário.
  - `operacao`: Armazena a operação selecionada (+, -, *, /).

- **Métodos**:
  - `btnX_Click`: Métodos para adicionar números à caixa de texto quando os botões numéricos são clicados.
  - `btnSomar_Click`, `btnSubtracao_Click`, `btnMultiplicacao_Click`, `btnDivisao_Click`: Métodos para definir a operação e armazenar o primeiro número.
  - `btnIgual_Click`: Realiza o cálculo com base na operação selecionada e exibe o resultado.
  - `btnLimpar_Click`: Limpa a caixa de texto e reinicia as variáveis.

## Como executar

1. Certifique-se de ter o [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) instalado.
2. Abra o projeto no Visual Studio.
3. Compile e execute o projeto.
4. Use a interface gráfica para realizar cálculos.

## Capturas de tela

![image](https://github.com/user-attachments/assets/93be8bdf-27b8-48a9-a9ac-20d2742a0b6b)


## Melhorias futuras

- Adicionar suporte para mais operações matemáticas (por exemplo, potência, raiz quadrada).
- Implementar tratamento de erros mais robusto.
- Melhorar a interface gráfica.
