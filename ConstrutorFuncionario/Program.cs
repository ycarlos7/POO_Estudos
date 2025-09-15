using ConstrutorFuncionario;
int contador = 0;
Funcionario f1 = new Funcionario();
f1.Mostrar();

Funcionario f2 = new Funcionario(3, "Bia", 1000);
f2.Mostrar();

Funcionario f3 = new Funcionario(49, "Leo");
f3.Mostrar();

Console.WriteLine("Qtde de instâncias: "+ Funcionario.Contador);
