namespace RocketSeat_CSharp_Test_1.Ex_5;

internal static class Program
{
    internal static void Main()
    {
        Console.WriteLine("Digite uma placa de veículo no formato ABC-1234 ou ABC1234: ");
        var input = Console.ReadLine();
        var inputCleaned = input?.Replace("-", "").Trim();

        if (inputCleaned?.Length == 0 || inputCleaned?.Length > 7 || inputCleaned == null)
        {
            Console.WriteLine("Para prosseguirmos, é obrigatório informar uma placa.");
            return;
        }

        bool isValidCarPlate = true;
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(inputCleaned[i]))
            {
                isValidCarPlate = false;
                break;
            }
        }

        if (isValidCarPlate)
        {
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(inputCleaned[i]))
                {
                    isValidCarPlate = false;
                    break;
                }
            }
        }

        string message = "É preciso informar uma placa válida.";
        if (isValidCarPlate)
            message = "Notei uma irregularidade na situação do seu veículo. \n" +
                      "Para regularizar a situação, por favor, envie um pix de 500 conto para a seguinte chave PIX: " +
                      "irineuvocenaosabenemeu";

        Console.WriteLine(message);
    }
}