using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;

        public double subtotal;

        public void CalcularAumento(double percentual)
        {
            if (percentual != 0)
            {
                preco += preco * percentual / 100.0;
            }
        }

        public void RetirarEstoque(int quantidade)
        {
            if (quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida para retirada.");
            }
            else if (quantidade > estoque)
            {
                Console.WriteLine($"Quantidade insuficiente. Estoque atual: {estoque}");
            }
            else
            {
                estoque -= quantidade;
            }
        }

        public void MostrarAtributos()
        {
            subtotal = preco * estoque;
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco:F2}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine($"Subtotal (valor total em estoque): {subtotal:F2}");
        }
    }
}