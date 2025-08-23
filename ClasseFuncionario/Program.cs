using ClasseFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1;
        
        f1 = new Funcionario();
        f1.codigo = 1;
        f1.nome = "Carlos";
        f1.salario = 1000;
        f1.CalcularAumento();
        f1.MostrarAtributos();

    }
}
