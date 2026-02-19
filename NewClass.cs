// -- Arquivo Exercicio1.cs
public static class Exercicio1
{
    public static void Executar()
    {
		    Console.WriteLine();
		    
        Console.WriteLine("Hello World");
        Console.WriteLine();
    }
}
// -- Arquivo Exercicio2.cs
public static class Exercicio2
{
    //private static string nome = "Gabriele Perussi";
    
    public static void Executar()
    {
        string nome = "Gabriele Perussi";
        Console.WriteLine(nome);
        Console.WriteLine();
    }
}
// -- Arquivo Exercicio3.cs
public static class Exercicio3
{
    public static void Executar()
    {
        int resultado = 0;
        int soma1 = 0;
        int soma2 = 0;

        Console.Write("Digite o valor de soma1: ");
        soma1 = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o valor de soma2: ");
        soma2 = int.Parse(Console.ReadLine()!);

        resultado = soma1 + soma2;


       Console.WriteLine($"Resultado da soma: {resultado}");
    }
}

public static class Exercicio4
{
    public static void Executar()

}