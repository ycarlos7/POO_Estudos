using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario //pasta
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public void CalcularAumento()
        {
            salario += 0.05 * salario;
            System.Console.WriteLine(salario);
        }

        public void MostrarAtributos()
        {
            Console.WriteLine(" Código: " + codigo + " Nome: " + nome + " Salário R$: " + salario);
        }
    }
}