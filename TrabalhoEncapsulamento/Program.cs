using TrabalhoEncapsulamento;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando o primeiro estudante (aprovado)");
        Estudante estudante1 = new Estudante();
        estudante1.Nome = "Liane";
        estudante1.Nota = 8.5;
        
        estudante1.ExibirDetalhes();
        

        Console.WriteLine("Criando o segundo estudante (reprovado)");
        Estudante estudante2 = new Estudante();
        estudante2.Nome = "Timotio";
        estudante2.Nota = 5;
        
        estudante2.ExibirDetalhes();
        

        Console.WriteLine("Criando o terceiro estudante (nota inválida)");
        Estudante estudante3 = new Estudante();
        estudante3.Nome = "Arlindo";
        estudante3.Nota = 15;

        
        estudante3.ExibirDetalhes();
        

        
    }
}
