using ConstrutorAluno;

Aluno aluno1 = new Aluno("João da Silva");
aluno1.Mostrar();

Aluno aluno2 = new Aluno();
aluno2.Mostrar();

Aluno aluno3 = new Aluno("Maria Oliveira");
aluno3.Mostrar();

Console.WriteLine("Qtde de instâncias: " + Aluno.Contador);