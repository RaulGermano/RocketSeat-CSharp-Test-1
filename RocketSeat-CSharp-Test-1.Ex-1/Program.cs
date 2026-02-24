namespace RocketSeat_CSharp_Test_1.Ex_1;

internal static class Program
{
    internal static void Main()
    {
        Console.Write("Digite seu nome: ");
        
        var name = Console.ReadLine();
        name = name?.Trim();

        var processedName = name?.Length > 0
            ? name
            : "Zero Meia";
        
        Console.WriteLine($"Olá, {processedName}! Seja muito bem-vindo!");
    }
}