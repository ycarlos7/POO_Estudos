using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> VetProd { get; set; }

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.Comp = comprador;
            this.Vend = vendedor;
            this.VetProd = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            VetProd.Add(produto);
        }

        public void ConcluirVenda()
        {
            double totalVenda = 0;
            
            foreach (var produto in VetProd)
            {
                totalVenda += produto.Preco;
            }

            if (Comp.Verba >= totalVenda)
            {
                Comp.RealizarPagamento(totalVenda);
                Vend.CalcularComissao(totalVenda);
                Console.WriteLine($"\nVenda realizada com sucesso! Valor total: R$ {totalVenda:F2}");
            }
            else
            {
                Console.WriteLine($"\nVenda não pode ser realizada. Verba insuficiente!");
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\n--- Detalhes da Venda ---");
            Console.WriteLine($"Comprador tem R$ {Comp.Verba:F2} restantes.");
            Console.WriteLine($"Vendedor tem R$ {Vend.Comissao:F2} de comissão.");
            Console.WriteLine("Produtos vendidos:");
            foreach (var produto in VetProd)
            {
                produto.MostrarAtributos();
            }
            Console.WriteLine("---------------------------\n");
        }
    }
}