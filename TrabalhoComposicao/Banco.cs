using System;
using System.Collections.Generic;

namespace ExercicioComposicaoBanco
{
    public class Banco
    {
        private string _nome;
        private List<ContaCorrente> _contasCorrentes;
        private List<Poupanca> _poupancas;

        public string Nome { get { return _nome; } set { _nome = value; } }

        public Banco(string nome)
        {
            this.Nome = nome;
            _contasCorrentes = new List<ContaCorrente>();
            _poupancas = new List<Poupanca>();
        }

        ~Banco()
        {
            Console.WriteLine($"Destrutor do Banco: {this.Nome}");
        }

        public void AbrirContaCorrente(int numero, double saldoInicial, double limite)
        {
            _contasCorrentes.Add(new ContaCorrente(numero, saldoInicial, limite));
        }
        
        public void AbrirPoupanca(int numero, double saldoInicial, double juros)
        {
            _poupancas.Add(new Poupanca(numero, saldoInicial, juros));
        }

        public void MostrarContas()
        {
            Console.WriteLine($"\n--- Contas do Banco {this.Nome} ---");
            foreach (var cc in _contasCorrentes)
            {
                cc.Mostrar();
            }
            foreach (var cp in _poupancas)
            {
                cp.Mostrar();
            }
            Console.WriteLine("----------------------------------");
        }
    }
}