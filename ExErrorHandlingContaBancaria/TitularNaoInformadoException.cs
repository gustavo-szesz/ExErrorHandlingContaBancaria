namespace ExErrorHandlingContaBancaria
{
    public class TitularNaoInformadoException : ContaBancariaException
    {
        private const string DefaultMessage = "Titular não informado.";

        /// <summary>
        /// Creates a new instance of <see cref="TitularNaoInformadoException"/> with a default message.
        /// </summary>
        public TitularNaoInformadoException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="TitularNaoInformadoException"/> with a custom message.
        /// </summary>
        /// <param name="message">The custom message.</param>
        public TitularNaoInformadoException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new TitularNaoInformadoException(DefaultMessage);
            }
        }

        /// <summary>
        /// Creates a new instance of <see cref="TitularNaoInformadoException"/> with a custom message and account holder name.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="titular">The account holder name.</param>
        public TitularNaoInformadoException(string message, string titular) : base(message)
        {
            if (string.IsNullOrWhiteSpace(titular))
            {
                throw new TitularNaoInformadoException(DefaultMessage);
            }
        }
    }
}
