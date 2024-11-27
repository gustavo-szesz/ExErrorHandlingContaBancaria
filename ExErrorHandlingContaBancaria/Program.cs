using System;

namespace ExErrorHandlingContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarContaInvalidaException();
            TestarTitularNaoInformadoException();
        }

        static void TestarContaInvalidaException()
        {
            try
            {
                Console.WriteLine("Testando ContaInvalidaException com número de conta nulo...");
                new ContaInvalidaException(null);
            }
            catch (ContaInvalidaException ex)
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizado teste com número de conta nulo.\n");
            }

            try
            {
                Console.WriteLine("Testando ContaInvalidaException com número de conta vazio...");
                new ContaInvalidaException("");
            }
            catch (ContaInvalidaException ex)
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizado teste com número de conta vazio.\n");
            }

            try
            {
                Console.WriteLine("Testando ContaInvalidaException com número de conta inválido...");
                new ContaInvalidaException("-1");
            }
            catch (ContaInvalidaException ex)
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizado teste com número de conta inválido.\n");
            }
        }

        static void TestarTitularNaoInformadoException()
        {
            try
            {
                Console.WriteLine("Testando TitularNaoInformadoException com titular nulo...");
                new TitularNaoInformadoException(null);
            }
            catch (TitularNaoInformadoException ex)
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizado teste com titular nulo.\n");
            }

            try
            {
                Console.WriteLine("Testando TitularNaoInformadoException com titular vazio...");
                new TitularNaoInformadoException("");
            }
            catch (TitularNaoInformadoException ex)
            {
                Console.WriteLine($"Exceção capturada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalizado teste com titular vazio.\n");
            }
        }
    }
}
