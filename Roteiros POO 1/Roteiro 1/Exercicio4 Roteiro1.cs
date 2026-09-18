public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public decimal Saldo;

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine ("Não é possível depositar um valor negativo ou zero.");

        } else
        {
            Saldo += valor;
            Console.WriteLine($"Depósito Realizado com Sucesso! Novo Saldo: {Saldo:C}");
        }
    }
    public void Sacar(decimal valor)
    {
        if (Saldo == 0)
        {
            Console.WriteLine("Não é possível realizar o saque, a conta está sem saldo.");

        } else if (valor <= 0)
        {
            Console.WriteLine("Não é possível sacar um valor negativo ou zero.");
        }
        else if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque Realizado com Sucesso! Novo Saldo: {Saldo:C}");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo Atual: {Saldo:C}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Titular = "João Silva";
        conta.NumeroConta = 123456;
        conta.Saldo = 0m;
        conta.Depositar(-10m);
        conta.Sacar(50m);
        conta.Depositar(100m);
        conta.Sacar(50m);
        conta.ExibirSaldo();

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Joana Dark";
        conta2.NumeroConta = 654321;
        conta2.Saldo = 5000m;
        conta2.Depositar(0);
        conta2.Depositar(250m);
        conta2.Sacar(10000m);
        conta2.ExibirSaldo();
        conta2.Sacar(1000m);
        conta2.ExibirSaldo();
    }

    }