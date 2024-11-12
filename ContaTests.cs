using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesterCore;

namespace TestesxUnit
{
    public class ContaTests
    {
        // https://docs.microsoft.com/pt-br/visualstudio/test/walkthrough creating-and-running-unit-tests-for-managed-code?view=vs-2019 [Fact] 
        [Fact]
        public void Deposito_ComValor_AtualizaSaldo()
        {
            //Arrange 
            double saldoInicial = 20;
            double valorDepositado = 4.55;
            double valorEsperado = 24.55;
            var conta = new Conta(saldoInicial);
            //Act                                    
            conta.Depositar(valorDepositado);

            double valorAtualizado = conta.Saldo;
            //Assert
            Assert.Equal(valorEsperado, valorAtualizado);
        }
        [Fact]
        public void Deposito_ComValorInvalido_RetornaErro()
        {
            // Arrange 
            double saldoInicial = 20;
            double valorDepositado = -8;
            var conta = new Conta(saldoInicial);

            Assert.Throws<ArgumentOutOfRangeException>(() => conta.Depositar(valorDepositado));
        }
    }
}
