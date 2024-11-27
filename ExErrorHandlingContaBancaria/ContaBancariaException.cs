namespace ExErrorHandlingContaBancaria;


public class ContaBancariaException : Exception
{
    private const string DefaultMessage = "Erro ao realizar operação";

    public ContaBancariaException() : base(DefaultMessage)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a default message.
        /// </summary>
    }

    public ContaBancariaException(string message) : base(message)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a custom message.
        /// </summary>
        /// <param name="message">The custom message.</param>
    }

    public ContaBancariaException(string message, Exception innerException) : base(message, innerException)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a custom message and an inner exception.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="innerException">The inner exception.</param>
    }

    public ContaBancariaException(Exception innerException) : base(DefaultMessage, innerException)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a default message and an inner exception.
        /// </summary>
        /// <param name="innerException">The inner exception.</param>
    }

    public ContaBancariaException(string message, string numeroConta) : base(message)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a custom message and the account number.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="numeroConta">The account number.</param>
    }

    public ContaBancariaException(string message, string numeroConta, Exception innerException) : base(message, innerException)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a custom message, the account number, and an inner exception.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="numeroConta">The account number.</param>
        /// <param name="innerException">The inner exception.</param>
    }

    public ContaBancariaException(string message, string numeroConta, string titularConta) : base(message)
    {
        /// <summary>
        /// Creates a new instance of <see cref="ContaBancariaException"/> with a custom message, the account number, and the account holder.
        /// </summary>
        /// <param name="message">The custom message.</param>
        /// <param name="numeroConta">The account number.</param>
        /// <param name="titularConta">The account holder.</param>
    }

}