namespace RocketSeat_CSharp_Test_1.Ex_3;

internal static class Program
{
    private enum Operation : int
    {
         Soma = 1,
         Subtracao = 2,
         Multiplicacao = 3,
         Divisao = 4
    };
    
    internal static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        var firstNumber = Console.ReadLine();
        var firstNumberCleaned = firstNumber?.Trim();

        if (firstNumberCleaned?.Length == 0 || firstNumberCleaned == null)
        {
            Console.WriteLine("O número não pode ser vazio.");
            return;
        }

        double.TryParse(firstNumberCleaned, out var firstNumberProcessed);
        Console.WriteLine($"Primeiro número: {firstNumberProcessed}\n");

        Console.Write("Digite o segundo número: ");
        var secondNumber = Console.ReadLine();
        var secondNumberCleaned = secondNumber?.Trim();

        if (secondNumberCleaned?.Length == 0 || secondNumberCleaned == null)
        {
            Console.WriteLine("O número não pode ser vazio.");
            return;
        }

        double.TryParse(secondNumberCleaned, out var secondNumberProcessed);
        Console.WriteLine($"Segundo número: {secondNumberProcessed}\n");
        
        Console.WriteLine("Agora selecione a operação desejada: ");
        foreach (var operation in Enum.GetValues(typeof(Operation)))
            Console.WriteLine($"Informe {(int)operation} para {operation}");
        
        Console.Write("\nDigite: ");
        var operationNumber = Console.ReadLine();
        var operationNumberCleaned = operationNumber?.Trim();

        if (operationNumberCleaned?.Length == 0 || operationNumberCleaned == null )
        {
            Console.WriteLine("O número não pode ser vazio.");
            return;
        }
        
        int.TryParse(operationNumberCleaned, out var operationNumberProcessed);
        if (operationNumberProcessed <=  0 || operationNumberProcessed > 4)
        {
            Console.WriteLine("O número da operação deve ser entre 1 e 4.");
            return;
        }

        double result;
        switch (operationNumberProcessed)
        {
            case (int)Operation.Soma:
            {
                result = firstNumberProcessed + secondNumberProcessed;
                break;   
            }
            case (int)Operation.Subtracao:
            {
                result = firstNumberProcessed - secondNumberProcessed;
                break;   
            }
            case (int)Operation.Multiplicacao:
            {
                result = firstNumberProcessed * secondNumberProcessed;
                break;   
            }
            case (int)Operation.Divisao:
            {
                if (secondNumberProcessed == 0)
                {
                    Console.Write("Para calcular a divisão, o segundo número deve ser diferente de zero.");
                    return;
                }
                
                result = firstNumberProcessed / secondNumberProcessed;
                break;   
            }
            default:
            {
                Console.WriteLine("Operação inválida.");
                return;
            }
        }
        
        Console.WriteLine($"Resultado: {result}");
    }
}