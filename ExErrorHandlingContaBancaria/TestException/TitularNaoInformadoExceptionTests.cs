using NUnit.Framework;

namespace ExErrorHandlingContaBancaria.Tests
{
    public class TitularNaoInformadoExceptionTests
    {
        [Test]
        public void TitularNaoInformadoException_TitularVazio_DeveLancarTitularNaoInformadoException()
        {
            Assert.Throws<TitularNaoInformadoException>(() => new TitularNaoInformadoException(null));
            Assert.Throws<TitularNaoInformadoException>(() => new TitularNaoInformadoException(""));
        }
    }
}
