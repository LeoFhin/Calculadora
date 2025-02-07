# Calculadora em Windows Forms

Este é um projeto de uma calculadora simples desenvolvida em **C# utilizando Windows Forms**.  
A calculadora realiza operações básicas como adição, subtração, multiplicação e divisão, além de **manter um histórico das operações realizadas**.

## 📌 Funcionalidades

- **Operações básicas**: Adição (+), subtração (-), multiplicação (*) e divisão (/).
- **Entrada de números**: Suporte para números inteiros e decimais (usando vírgula como separador decimal).
- **Limpeza**: Botão para limpar a tela e reiniciar os cálculos.
- **Exibição de resultados**: O resultado é exibido na mesma caixa de texto onde os números são digitados.
- **Histórico de cálculos**: Armazena os cálculos realizados e permite visualizar ou limpar o histórico.

## 🛠️ Como funciona

1. O usuário digita um número.
2. Seleciona uma operação (**+, -, *, /**).
3. Digita o segundo número.
4. Clica no botão **"="** para obter o resultado.
5. O cálculo é armazenado no histórico.
6. O usuário pode visualizar o histórico em uma nova janela ou apagá-lo quando desejar.
7. Se o usuário tentar **dividir por zero**, a calculadora exibirá uma mensagem de erro.

## 📂 Estrutura do código

O código principal está no arquivo `Form1.cs`. Aqui estão os principais componentes:

### 🔹 Variáveis de controle

- `primeiroNumero` e `segundoNumero`: Armazenam os valores digitados pelo usuário.
- `operacao`: Armazena a operação selecionada (**+, -, *, /**).

### 🔹 Métodos principais

- `btnX_Click`: Adiciona números à caixa de texto quando os botões numéricos são clicados.
- `btnSomar_Click`, `btnSubtracao_Click`, `btnMultiplicacao_Click`, `btnDivisao_Click`: Definem a operação e armazenam o primeiro número.
- `btnIgual_Click`: Realiza o cálculo com base na operação selecionada e exibe o resultado.
- `btnLimpar_Click`: Limpa a caixa de texto e reinicia as variáveis.
- `btnLimparHistorico_Click`: Limpa o histórico de cálculos armazenado no arquivo.

## 📝 Gerenciamento de Histórico

A funcionalidade de histórico está implementada na classe **`Historico.cs`**. Ela permite armazenar, carregar e limpar os cálculos realizados.  
O histórico é salvo no arquivo **`historico.txt`**.

- `SalvarNoArquivo(string texto)`: Salva um novo cálculo no arquivo.
- `CarregarHistorico()`: Retorna todos os cálculos armazenados.
- `LimparHistorico()`: Apaga todo o conteúdo do histórico.

A interface para visualizar o histórico está na classe **`Historico_Calculadora.cs`**, que carrega os dados do arquivo e exibe no `RichTextBox`.

## ▶️ Como executar

1. Certifique-se de ter o [**.NET Framework**](https://dotnet.microsoft.com/download/dotnet-framework) instalado.
2. Abra o projeto no **Visual Studio**.
3. Compile e execute o projeto.
4. Use a interface gráfica para realizar cálculos e visualizar o histórico.

## 📸 Capturas de tela

![image](https://github.com/user-attachments/assets/d2e12d41-47e2-4b37-8010-8efeb726e330)
