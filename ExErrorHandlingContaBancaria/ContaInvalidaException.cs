namespace ExErrorHandlingContaBancaria
{
    public class ContaInvalidaException : ContaBancariaException
    {
        private const string DefaultMessage = "Conta inválida";
        private const string InvalidAccountNumberMessage = "O número da conta é inválido.";

        public string? NumeroConta { get; }

        /// <summary>
        /// Creates a new instance of <see cref="ContaInvalidaException"/> with a default message.
        /// </summary>
        public ContaInvalidaException() : base(DefaultMessage){}

        /// <summary>
        /// Creates a new instance of <see cref="ContaInvalidaException"/> with a custom message.
        /// </summary>
        /// <param name="message">The custom message.</param>
        public ContaInvalidaException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message) || (int.TryParse(message, out int numero) && numero < 0))
            {
                throw new ContaInvalidaException(InvalidAccountNumberMessage);
            }
        }


        /// <summary>
        /// Creates a new instance of <see cref="ContaInvalidaException"/> with a custom message and account number.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="numeroConta">The account number.</param>
        public ContaInvalidaException(string message, string numeroConta) : base(message)
        {
            if (string.IsNullOrWhiteSpace(numeroConta) || (int.TryParse(numeroConta, out int numero) && numero < 0))
            {
                throw new ContaInvalidaException(InvalidAccountNumberMessage);
            }

            NumeroConta = numeroConta;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContaInvalidaException"/> with an account number.
        /// </summary>
        /// <param name="numeroConta">The account number.</param>
        public ContaInvalidaException(string numeroConta, bool useDefaultMessage) : base(useDefaultMessage ? DefaultMessage : InvalidAccountNumberMessage)
        {
            if (string.IsNullOrWhiteSpace(numeroConta) || (int.TryParse(numeroConta, out int numero) && numero < 0))
            {
                throw new ContaInvalidaException(InvalidAccountNumberMessage);
            }

            NumeroConta = numeroConta;
        }
    }
}
