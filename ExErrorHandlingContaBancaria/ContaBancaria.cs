namespace ExErrorHandlingContaBancaria;

public class ContaBancaria
{
    public string Numero { get;  set; }
    public string Titular { get;  set; }
    public decimal Saldo { get;  set; }


    public static void Depositar(ContaBancaria conta, decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException(nameof(valor),
                "O valor do depósito deve ser maior que zero.");
        }
        conta.Saldo += valor;
    }

    public static void Sacar(ContaBancaria conta, decimal valor)
    {
        if (conta.Saldo < valor)
        {
            throw new InvalidOperationException("Saldo insuficiente para realizar essa operação");
        }

        conta.Saldo -= valor;
    }

    public static decimal ConsultarSaldo(ContaBancaria conta)
    {
        return conta.Saldo;
    }
}
