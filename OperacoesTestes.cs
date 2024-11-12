
using TesterCore;

namespace TestesxUnit
{
    public class OperacoesTests // Define a classe de testes "OperacoesTests".
    {
        // Teste unitário utilizando o atributo [Fact] que indica um teste simples.
        [Fact]
        public void SomarDoisNumeroRetornarResultado()
        {
            //Arrange: Nesta parte, são configurados os valores e variáveis para o teste.
            double primeiroNumero = 10; // Define a variável "primeiroNumero" com valor 10.
            double segundoNumero = 20; // Define a variável "segundoNumero" com valor 20.

            //Act: Ação do teste, executa o método ou função que será testada.
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Chama o método "Somar" da classe "Operacoes" passando os dois números definidos anteriormente e armazena o resultado.

            //Assert: A parte do teste onde se verifica se o resultado está correto.
            Assert.Equal(30, resultado);
            // Verifica se o valor retornado pelo método "Somar" é igual a 30 (esperado).
            // Se o valor for diferente de 30, o teste falhará.
        }

        // Teste parametrizado utilizando o atributo [Theory] e [InlineData], que permite rodar o teste com vários conjuntos de dados.
        [Theory]
        [InlineData(1, 2, 3)] // Define o primeiro conjunto de dados: soma de 1 + 2 deve resultar em 3.
        [InlineData(2, 3, 5)] // Define o segundo conjunto de dados: soma de 2 + 3 deve resultar em 5.
        public void SomaDoisNumeros_RetornarResultado_ParaListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            //Act: Executa a ação de somar os dois números fornecidos.
            var resultadoDaSoma = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Chama o método "Somar" da classe "Operacoes", passando os valores dos parâmetros "primeiroNumero" e "segundoNumero".

            //Assert: Verifica se o resultado da soma corresponde ao valor esperado.
            Assert.Equal(resultadoDaSoma, resultadoEsperado);
            // Compara o resultado retornado pelo método com o valor esperado (passado no atributo [InlineData]).
            // Se o valor retornado não for igual ao esperado, o teste falhará.
        }
    }
}