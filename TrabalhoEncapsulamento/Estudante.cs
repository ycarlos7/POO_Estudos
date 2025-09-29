namespace TrabalhoEncapsulamento
{
    public class Estudante
    {
        private string _nome;
        private double _nota;

        public string Nome
        {
            get { return _nome.ToUpper(); }
            set { _nome = value; }
        }

        public double Nota
        {
            get { return _nota; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _nota = value;
                }
                else
                {
                    Console.WriteLine("A nota  (" + value + ") é inválida. O valor deve estar entre 0 e 10.");
                }
            }
        }

        public bool EstaAprovado()
        {
            return _nota >= 6;
        }

        public void ExibirInformacoes()
        {
            string status = EstaAprovado() ? "Aprovado" : "Reprovado";

            Console.WriteLine($"Nome do Estudante: {Nome}");
            Console.WriteLine($"Nota: {Nota}");
            Console.WriteLine($"Status: {status}");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("--------------------");
            ExibirInformacoes();
        }
    }
}