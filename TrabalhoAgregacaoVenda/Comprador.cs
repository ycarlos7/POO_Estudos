using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        private double _verba;

        public double Verba
        {
            get { return _verba; }
            private set { _verba = value; }
        }

        public Comprador(double verbaInicial)
        {
            this.Verba = verbaInicial;
        }

        public void RealizarPagamento(double valorCompra)
        {
            this.Verba -= valorCompra;
        }



        public void MostrarAtributo()
        {
            Console.WriteLine($"Verba atual do comprador: R$ {Verba:F2}");
        }
    }
}