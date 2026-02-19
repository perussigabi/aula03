// -- Arquivo Exercicio4.cs
// -- Professor, eu pedi pra fazer desse jeito e você deixou.
public static class Exercicio4
{
    public static void Executar()
    {
        string nome = "";
        int idade = 0;
        string hobby1 = "";
        string hobby2 = "";
        string cursoGraduacao = "";

        Console.Write("Digite seu nome");
        nome = Console.ReadLine()!;

        Console.Write("Digite sua idade");
        idade = int.Parse(Console.ReadLine()!);

Console.Write("Digite seu hobby1");
        hobby1 = Console.ReadLine()!;

Console.Write("Digite seu hobby2");
        hobby2 = Console.ReadLine()!;

Console.Write("Digite seu cursoGraduacao");
        cursoGraduacao = Console.ReadLine()!;


       Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meus dois passatempos favoritos são {hobby1} e {hobby2}, e pretendo cursar graduacao em {cursoGraduacao}.");
    }
}