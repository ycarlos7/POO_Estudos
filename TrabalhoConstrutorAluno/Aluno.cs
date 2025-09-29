namespace ConstrutorAluno
{
    public class Aluno
    {
        public long Ra { get; private set; }
        public string Nome { get; set; }
        
        public static long Contador { get; private set; }

        public Aluno()
        {
            Contador++;
            Ra = 15704824130000 + Contador;
            Nome = "Aluno não identificado";
        }

        public Aluno(string nome)
        {
            Contador++;
            Ra = 15704824130000 + Contador;
            Nome = nome;
        }

        public void Mostrar()
        {
            Console.WriteLine($"RA: {Ra} \tNome: {Nome}");
        }
    }
}