namespace RocketSeat_CSharp_Test_1.Ex_2;

internal static class Program
{
    internal static void Main()
    {
        Console.Write("Digite seu nome: ");
        var firstName = Console.ReadLine();
        firstName = firstName?.Trim();

        Console.Write("Digite seu sobrenome: ");
        var lastName = Console.ReadLine();
        lastName = lastName?.Trim();

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("É preciso informar o nome e o sobrenome para prosseguir.");
            return;
        }
        
        var processedName = $"{firstName} {lastName}";

        Console.WriteLine($"Obrigado por informar seu nome completo, {processedName}.");
    }
}