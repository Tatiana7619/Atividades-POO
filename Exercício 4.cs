class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        string num = Console.ReadLine();

        int resultado;

        if(int.TryParse(num, out resultado))

        {
            Console.WriteLine($"O número digitado: {resultado}");
        }
        else
        {
            Console.WriteLine("número inválido");
        }
    }
}