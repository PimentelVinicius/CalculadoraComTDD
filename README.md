Calculadora com Histórico - Testes Unitários
Este projeto implementa uma calculadora com histórico de operações em .NET e utiliza o framework de testes xUnit para validar suas funcionalidades. Ele faz parte de um portfólio de testes unitários com abordagem de desenvolvimento orientado a testes (TDD).

Funcionalidades
A calculadora implementa operações matemáticas básicas e um histórico de operações:

Operações: Soma, Subtração, Multiplicação e Divisão.
Histórico: Registra operações realizadas para posterior consulta.
Estrutura de Testes
A classe de testes UnitTest1 cobre as seguintes funcionalidades:

Soma: Verifica se a adição de dois números retorna o valor correto.
Subtração: Verifica a precisão na subtração.
Multiplicação: Assegura a precisão na multiplicação.
Divisão: Valida a operação de divisão e lida com divisão por zero.
Histórico: Garante que o histórico de operações funciona corretamente.
Cada operação é testada com dados de entrada variados usando o atributo [Theory] para assegurar que diferentes cenários sejam cobertos.

Tecnologias Utilizadas
.NET
xUnit - para execução dos testes
