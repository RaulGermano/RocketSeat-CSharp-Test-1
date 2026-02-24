using System.Globalization;

namespace RocketSeat_CSharp_Test_1.Ex_6;

internal static class Program
{
    private static readonly Dictionary<int, (string description, string format)> DateFormats =
        new()
        {
            [1] = ("completo", "dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"),
            [2] = ("abreviado", "dd/MM/yyyy"),
            [3] = ("horário (24h)", "HH:mm'h'"),
            [4] = ("mês por extenso", "dd 'de' MMMM 'de' yyyy")
        };

    internal static void Main()
    {
        Console.WriteLine("Escolha um número de 1 a 4 para visualizar a data atual em diferentes formatos: ");
        foreach (var dateFormat in DateFormats)
            Console.WriteLine($"Informe {dateFormat.Key} para formato {dateFormat.Value.description}");

        Console.Write("\nDigite: ");

        var input = Console.ReadLine();
        var inputCleaned = input?.Trim();

        if (inputCleaned?.Length == 0 || inputCleaned == null)
        {
            Console.WriteLine("É obrigatório informar uma opção.");
            return;
        }

        int.TryParse(inputCleaned, out var option);
        if (option <= 0 || option > 4)
        {
            Console.WriteLine("É preciso informar uma das opções válidas.");
            return;
        }

        DateTime now = DateTime.Now;
        CultureInfo ptBR = new CultureInfo("pt-BR");
        var dataFormatted = now.ToString(DateFormats[option].format, ptBR);

        Console.Write($"Valor na formatação escolhida: {dataFormatted}");
    }
}