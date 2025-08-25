using ClasseProduto;

internal class Program
{
    private static void Main(string[] args)
    {
        // exemplo simples demonstrando os métodos
        Produto p1 = new Produto();
        p1.codigo = 1;
        p1.nome = "Caneta";
        p1.preco = 2.50;
        p1.estoque = 100;

        Console.WriteLine("--- Valores iniciais ---");
        p1.MostrarAtributos();

        Console.WriteLine();
        Console.WriteLine("Aumentando preço em 20%...");
        p1.CalcularAumento(20);
        p1.MostrarAtributos();

        Console.WriteLine();
        Console.WriteLine("Retirando 5 unidades do estoque...");
        p1.RetirarEstoque(5);
        p1.MostrarAtributos();
    }
}