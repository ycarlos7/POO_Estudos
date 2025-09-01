using EncapsulamentoConta;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new conta();
        c1.Numero = -1;
        c1.Titular = "Ana";
        c1.Saldo = 100;
        c1.MostrarAtributos();

        Conta c2 = new Conta();
        Console.WriteLine("Digite o número: ");
        c2.Numero = Convert.Toint32(Console.Redline());
        Console.WriteLine("Digite o titular: ");
        c2.Titular = Console.Redline();
        Console.WriteLine("Digite o número: ");
        c2.Numero = Convert.Todouble(Console.Redline());
        c2.MostrarAtributos();
    }
}