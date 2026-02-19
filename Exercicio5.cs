// -- Arquivo Exercicio5.cs
// -- Professor, eu pedi pra fazer desse jeito e você deixou.
public static class Exercicio5
{
    public static void Executar()
    {
        string nome = "";
        string estiloMusical = "";
        string artistaFavorito = "";

        Console.Write("Digite seu nome");
        nome = Console.ReadLine()!;

        Console.Write("Digite seu estiloMusical");
        estiloMusical = Console.ReadLine()!;

        Console.Write("Digite seu artistaFavorito");
        artistaFavorito = Console.ReadLine()!;


       Console.WriteLine($"Eu sou {nome}, curto o esilo musical {estiloMusical} e meu artista favorito desse estilo é {artistaFavorito}.");
    }
}
    
