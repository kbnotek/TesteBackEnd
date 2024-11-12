
using TesterCore;

namespace TestesxUnit
{
    public class OperacoesTests // Define a classe de testes "OperacoesTests".
    {
        // Teste unit�rio utilizando o atributo [Fact] que indica um teste simples.
        [Fact]
        public void SomarDoisNumeroRetornarResultado()
        {
            //Arrange: Nesta parte, s�o configurados os valores e vari�veis para o teste.
            double primeiroNumero = 10; // Define a vari�vel "primeiroNumero" com valor 10.
            double segundoNumero = 20; // Define a vari�vel "segundoNumero" com valor 20.

            //Act: A��o do teste, executa o m�todo ou fun��o que ser� testada.
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Chama o m�todo "Somar" da classe "Operacoes" passando os dois n�meros definidos anteriormente e armazena o resultado.

            //Assert: A parte do teste onde se verifica se o resultado est� correto.
            Assert.Equal(30, resultado);
            // Verifica se o valor retornado pelo m�todo "Somar" � igual a 30 (esperado).
            // Se o valor for diferente de 30, o teste falhar�.
        }

        // Teste parametrizado utilizando o atributo [Theory] e [InlineData], que permite rodar o teste com v�rios conjuntos de dados.
        [Theory]
        [InlineData(1, 2, 3)] // Define o primeiro conjunto de dados: soma de 1 + 2 deve resultar em 3.
        [InlineData(2, 3, 5)] // Define o segundo conjunto de dados: soma de 2 + 3 deve resultar em 5.
        public void SomaDoisNumeros_RetornarResultado_ParaListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            //Act: Executa a a��o de somar os dois n�meros fornecidos.
            var resultadoDaSoma = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Chama o m�todo "Somar" da classe "Operacoes", passando os valores dos par�metros "primeiroNumero" e "segundoNumero".

            //Assert: Verifica se o resultado da soma corresponde ao valor esperado.
            Assert.Equal(resultadoDaSoma, resultadoEsperado);
            // Compara o resultado retornado pelo m�todo com o valor esperado (passado no atributo [InlineData]).
            // Se o valor retornado n�o for igual ao esperado, o teste falhar�.
        }
    }
}