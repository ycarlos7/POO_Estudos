using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //namespace é uma pasta
{
    public class Conta //tipo de dados meu de programador
    {
        //declaração dos atributos
        private int numero;
        private string? titular;
        private double saldo;
        //declaração dos métodos

        public int Numero{//Numero maiúsculo é a propriedade
        //propriedade é a representação dos étodos de encapsulamento get e set
            set{//numero misnusculo é o atributo
                if (value >0)
                numero = value;
                else
                Console.WriteLine("Número de conta inválido!");
            }
            get{//numero misnusculo é o atributo
                return numero;
            }
        }

        public string? Titular {
            get {
                return titular;
            }
            set {
                 titular = value;
            }
        }

        public double Saldo{
            set{saldo = value;}
            get{return saldo;}
        }       public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero +
            "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
    }
}