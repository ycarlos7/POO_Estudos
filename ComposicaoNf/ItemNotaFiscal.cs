using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNf
{
    public class ItemNotaFiscal
    {
        public int QuantidadeProduto {get; set;}
        public ItemNotaFiscal (int quantidadeProduto)
        {
            QuantidadeProduto = quantidadeProduto;

        }

        public void Mostrar()
        {
            Console.WriteLine("Quantidade de produto: " + QuantidadeProduto);
        }
    }
}