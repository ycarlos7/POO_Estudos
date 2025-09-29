using TrabalhoAgregacaoVenda;

Comprador comprador = new Comprador(2000.00);
Console.WriteLine("Situação Inicial do Comprador:");
comprador.MostrarAtributo();

Vendedor vendedor = new Vendedor();
Console.WriteLine("\nSituação Inicial do Vendedor:");
vendedor.MostrarAtributo();

Console.WriteLine("\nProdutos disponíveis para venda:");
Produto prod1 = new Produto("Laptop Gamer", 1500.00);
Produto prod2 = new Produto("Mouse sem fio", 80.50);
Produto prod3 = new Produto("Teclado Mecânico", 120.00);
prod1.MostrarAtributos();
prod2.MostrarAtributos();
prod3.MostrarAtributos();

Console.WriteLine("\n--- INICIANDO PRIMEIRA VENDA ---");

Venda venda1 = new Venda(comprador, vendedor);

venda1.AdicionarProduto(prod1);
venda1.AdicionarProduto(prod2);

venda1.ConcluirVenda();

Console.WriteLine("\n--- SITUAÇÃO APÓS A PRIMEIRA VENDA ---");
comprador.MostrarAtributo();
vendedor.MostrarAtributo();

Console.WriteLine("\n--- INICIANDO SEGUNDA VENDA ---");

Venda venda2 = new Venda(comprador, vendedor);

venda2.AdicionarProduto(prod3);

venda2.ConcluirVenda();

Console.WriteLine("\n--- SITUAÇÃO FINAL APÓS AS DUAS VENDAS ---");
comprador.MostrarAtributo();
vendedor.MostrarAtributo();
