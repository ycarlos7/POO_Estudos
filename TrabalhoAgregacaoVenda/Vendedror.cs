using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        private double _comissao;

        public double Comissao
        {
            get { return _comissao; }
            private set { _comissao = value; }
        }
        
        public Vendedor()
        {
            this.Comissao = 0;
        }

        public void CalcularComissao(double valorVenda)
        {
            this.Comissao += valorVenda * 0.02;
        }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Comissão acumulada do vendedor: R$ {Comissao:F2}");
        }
    }
}