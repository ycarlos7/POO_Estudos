
using TrabalhoVetorProduto;


class Program
{
    static void Main(string[] args)
    {
       
        Produto[] vetorProduto = new Produto[6];

        
        Console.WriteLine(" SCP - Sistema de Controle dos Produtos  ");
        for (int i = 0; i < vetorProduto.Length; i++)
        {

            vetorProduto[i] = new Produto();

            Console.WriteLine($"\n Cadastro do Produto {i + 1} de {vetorProduto.Length} ");
            Console.Write("Digite o código do produto: ");
            vetorProduto[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            vetorProduto[i].nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: R$ ");
            vetorProduto[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            vetorProduto[i].estoque = Convert.ToInt32(Console.ReadLine());
        }

        
    
        Console.WriteLine("\n Alterando Preço e Estoque");
        Console.Write("Digite a porcentagem de aumento para produtos em posições pares: ");
        double porcentagemAumento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade a ser retirada do estoque para produtos em posições ímpares: ");
        int quantidadeRetirada = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < vetorProduto.Length; i++)
        {
            
            if (i % 2 == 0)
            {
                vetorProduto[i].CalcularAumento(porcentagemAumento);
            }
            else 
            {
                vetorProduto[i].RetirarEstoque(quantidadeRetirada);
            }
        }
        


        Console.WriteLine("\nLista de Produtos - Após Aumento e Retirada");
        foreach (Produto p in vetorProduto)
        {
            p.MostrarAtributos();
        }

        Console.WriteLine("\n Calculando o Subtotal ");
        foreach (Produto p in vetorProduto)
        {
            p.CalcularSubtotal();
        }

        Console.WriteLine("\nLista Final de Produtos com Subtotal");
        foreach (Produto p in vetorProduto)
        {
            p.MostrarAtributos();
        }
    }
}

