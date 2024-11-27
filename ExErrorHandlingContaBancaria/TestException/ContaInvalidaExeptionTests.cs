using NUnit.Framework;
using System;

namespace ExErrorHandlingContaBancaria.Tests
{
    [TestFixture]
    public class ContaInvalidaExeptionTests
    {
        [Test]
        public void ContaInvalidaExeption_NumeroContaInvalido_DeveLancarContaInvalidaExeption()
        {
            Assert.Throws<ContaInvalidaException>(() => new ContaInvalidaException(null));
            Assert.Throws<ContaInvalidaException>(() => new ContaInvalidaException(""));
            Assert.Throws<ContaInvalidaException>(() => new ContaInvalidaException("-1"));
        }
    }
}
