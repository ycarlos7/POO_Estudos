using System;
using ExercicioComposicaoBanco;

Console.WriteLine("--- Iniciando Teste de Composição com Banco ---\n");
            

Banco meuBanco = new Banco("MeuBank");


meuBanco.AbrirContaCorrente(101, 500.00, 200.00);
meuBanco.AbrirPoupanca(201, 1200.00, 0.5);
meuBanco.AbrirContaCorrente(102, 3400.00, 1000.00);


meuBanco.MostrarContas();

Console.WriteLine("\nFim da execução do programa.");