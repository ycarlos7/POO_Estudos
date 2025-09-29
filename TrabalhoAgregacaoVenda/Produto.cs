using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        private static int proximoCodigo = 500;

        private int _codigo;
        private string _nome;
        private double _preco;

        public int Codigo
        {
            get { return _codigo; }
            private set { _codigo = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value >= 0)
                {
                    _preco = value;
                }
                else
                {
                    Console.WriteLine("O preço não pode ser negativo. O valor foi ajustado para 0.");
                    _preco = 0;
                }
            }
        }

        public Produto(string nome, double preco)
        {
            this.Codigo = proximoCodigo++;
            this.Nome = nome;
            this.Preco = preco;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Preço: R$ {Preco:F2}");
        }
    }
}