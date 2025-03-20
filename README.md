# Comparação de Performance: Cálculo de Mediana e Desvio Padrão vs. Math.NET Numerics

## Introdução

Este projeto console em C# .NET 8 tem como objetivo comparar a performance do cálculo da mediana e do desvio padrão implementados manualmente com a performance da biblioteca Math.NET Numerics (https://numerics.mathdotnet.com/) (versão mais recente disponível no NuGet=5).

O objetivo principal é analisar se a biblioteca otimizada Math.NET Numerics oferece ganhos significativos de performance em relação a uma implementação básica para um conjunto de dados de tamanho razoável (10.000 amostras neste caso).

## Pré-requisitos

* **.NET 8 SDK:** Certifique-se de ter o SDK do .NET 8 instalado em sua máquina. Você pode baixá-lo em [https://dotnet.microsoft.com/download/dotnet/8.0](https://dotnet.microsoft.com/download/dotnet/8.0).
* **IDE ou Editor de Código:** Recomenda-se usar um IDE como Visual Studio ou Visual Studio Code para facilitar a compilação e execução do projeto.
* **Pacote NuGet Math.NET Numerics:** O projeto depende do pacote NuGet `MathNet.Numerics`. Ele será adicionado automaticamente ao restaurar as dependências do projeto.


## Saída
Com 500.000 números aleatórios do tipo double esses foram os prazos:
- Cálculo de mediana na unha: 161ms
- Cálculo de desvio padrão na unha: 32ms

- Cálculo Mediana Math.Net Numerics: 10ms
- Cálculo Desvio Padrão Math.Net Numerics: 3ms
