public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
    public decimal CalcularValorTotal()
    {
        decimal valortotal = Preco * Quantidade;
        return valortotal;
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        Produto produto1 = new Produto();
        produto1.Nome = "Lápis";
        produto1.Preco = 1.00m;
        produto1.Quantidade = 10;
        produto1 .ExibirDados();

        decimal valortotal = produto1.CalcularValorTotal();
        Console.WriteLine($"Valor total: {valortotal:C}");
        
        Produto produto2 = new Produto();
        produto2.Nome = "Caderno";
        produto2.Preco = 10.00m;
        produto2.Quantidade = 5;
        produto2.ExibirDados();

        decimal valortotal2 = produto2.CalcularValorTotal();
        Console.WriteLine($"Valor total: {valortotal2:C}");

        Produto produto3 = new Produto(); 
        produto3.Nome = "Borracha";
        produto3.Preco = 2.00m;
        produto3.Quantidade = 20;
        produto3.ExibirDados();

        decimal valortotal3 = produto3.CalcularValorTotal();
        Console.WriteLine($"Valor total: {valortotal3:C}");
    }



    
}



   
    