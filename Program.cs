class Pessoa
{
    public string Nome;

}
class Program
{
    static void Main()
    {

        Pessoa p1 = new Pessoa();
        p1.Nome = "João";

        Pessoa p2 = p1;

        p2.Nome = "Maria";

        Console.WriteLine(p1.Nome);
    }
}
