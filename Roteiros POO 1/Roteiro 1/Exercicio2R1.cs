using System.ComponentModel.DataAnnotations;

public class Fantasmas
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasmas()
    {
        Console.WriteLine($"Nick: {Nick}, Habilidade: {Habilidade}, Cor: {Cor}");

    }
    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }

}

    public class Program
    {
        public static void Main()
        {
            Fantasmas fantasma1 = new Fantasmas();
            fantasma1.Nick = "Blinky";
            fantasma1.Habilidade = "Perseguir Pac-Man";
            fantasma1.Cor = "Vermelho";
            fantasma1.GerarFantasmas();
            fantasma1.Mover("cima");

            Fantasmas fantasma2 = new Fantasmas();
            fantasma2.Nick = "Pinky";
            fantasma2.Habilidade = "Prever movimentos de Pac-Man";
            fantasma2.Cor = "Rosa";
            fantasma2.GerarFantasmas();
            fantasma2.Mover("baixo");
        }
    }
