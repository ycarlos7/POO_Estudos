using System;

namespace ExercicioComposicaoBanco
{
    public class Poupanca
    {
        private int _numero;
        private double _saldo;
        private double _juros;

        public int Numero { get { return _numero; } set { _numero = value; } }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }
        public double Juros { get { return _juros; } set { _juros = value; } }

        public Poupanca(int numero, double saldoInicial, double juros)
        {
            this.Numero = numero;
            this.Saldo = saldoInicial;
            this.Juros = juros;
        }

        ~Poupanca()
        {
            Console.WriteLine($"Destrutor da Conta Poupança: {this.Numero}");
        }

        public void Mostrar()
        {
            Console.WriteLine($"Conta Poupança N.º: {Numero} | Saldo: R$ {Saldo:F2} | Juros: {Juros}%");
        }
    }
}