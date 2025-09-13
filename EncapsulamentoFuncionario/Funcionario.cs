using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario //pasta
{
    public class Funcionario
    {
        //declaração de atributos
        private int numero;//atributo
        private string? titular;
        private double saldo;
        
        //declaração dos métodos
        public int Numero //propriedade
        {
            get { return numero; }
            set { numero = value; }
        }
        public string? Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
        


        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome
            + "\tSalário R$ " + salario);
        }
        public void CalcularAumento()
        {   //5%
            salario += salario * 5 / 100;
        }
    }
}