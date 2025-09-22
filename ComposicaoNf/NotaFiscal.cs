using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNf
{
    public class NotaFiscal
    {
        public int NumeroNf {get; set;}
        public string? Data {get; set;}
        public List<ItemNotaFiscal> VetItens {get;set;}
        public NotaFiscal(int nf, strind data)
        {
            VetItens = new List<ItemNotaFiscal>();
            NumeroNf = nf;
            Data = data;
        }

        {
            VetItens = null;
            Console.WriteLine("Destruindo a nota fiscal");
        }
        public void Mostrar()
        {

        }
    }
}