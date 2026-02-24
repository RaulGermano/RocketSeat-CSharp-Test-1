namespace RocketSeat_CSharp_Test_1.Ex_4;

internal static class Program
{
    internal static void Main()
    {
        Console.WriteLine("Digite algo (Pode ser uma palavra, enrredo do Sherk ou qualquer outra coisa): ");
        var input = Console.ReadLine();
        var inputCleaned = input?.Trim();
        
        if (inputCleaned?.Length == 0 || inputCleaned == null)
        {
            Console.WriteLine("O texto não pode ser vazio.");
            return;
        }
        
        int charsCount = inputCleaned.Length;
        int wordsCount = inputCleaned.Split(' ').Length;
        
        Console.WriteLine($"Quantidade de palavras digitadas: {wordsCount}");
        Console.WriteLine($"Quantidade de letras digitadas: {charsCount}");
    }
}