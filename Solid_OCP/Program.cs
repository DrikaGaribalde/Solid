using Solid_OCP.Resolucao_OCP;

class Program
{
    static void Main(string[] args)
    {
        // Criar uma instância da classe derivada
        DebitoContaCorrente_OCP debitoContaCorrente = new DebitoContaCorrente_OCP();

        // Chamar o método Debitar
        string numeroTransacao = debitoContaCorrente.Debitar(100.00m, "123456");

        // Exibir o número de transação gerado
        Console.WriteLine($"Número de transação: {numeroTransacao}");
    }
}