using NUnit.Framework;
using System;

namespace ExErrorHandlingContaBancaria.TestException
{
    [TestFixture]
    public class ContaBancariaExceptionTests
    {
        [Test]
        public void Depositar_ValorMenorOuIgualAZero_DeveLancarArgumentException()
        {
            var conta = new ContaBancaria { Numero = "123", Titular = "Teste", Saldo = 100 };

            Assert.Throws<ArgumentException>(() => ContaBancaria.Depositar(conta, 0));
            Assert.Throws<ArgumentException>(() => ContaBancaria.Depositar(conta, -10));
        }

        [Test]
        public void Sacar_SaldoInsuficiente_DeveLancarInvalidOperationException()
        {
            var conta = new ContaBancaria { Numero = "123", Titular = "Teste", Saldo = 100 };

            Assert.Throws<InvalidOperationException>(() => ContaBancaria.Sacar(conta, 200));
        }
    }
}
