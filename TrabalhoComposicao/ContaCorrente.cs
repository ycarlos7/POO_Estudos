using System;

namespace ExercicioComposicaoBanco
{
    public class ContaCorrente
    {
        private int _numero;
        private double _saldo;
        private double _limite;

        public int Numero { get { return _numero; } set { _numero = value; } }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }
        public double Limite { get { return _limite; } set { _limite = value; } }

        public ContaCorrente(int numero, double saldoInicial, double limite)
        {
            this.Numero = numero;
            this.Saldo = saldoInicial;
            this.Limite = limite;
        }

        ~ContaCorrente()
        {
            Console.WriteLine($"Destrutor da Conta Corrente: {this.Numero}");
        }

        public void Mostrar()
        {
            Console.WriteLine($"Conta Corrente N.º: {Numero} | Saldo: R$ {Saldo:F2} | Limite: R$ {Limite:F2}");
        }
    }
}