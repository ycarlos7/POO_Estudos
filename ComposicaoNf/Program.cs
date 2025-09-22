using ComposicaoNf

ItemNotaFiscal item1 = new ItemNotaFiscal (12);
ItemNotaFiscal item2 = new ItemNotaFiscal (20);

NotaFiscal nf = new NotaFiscal (1, "22/09/2025")

nf.VetItens.Add(item1);
nf.VetItens.Add(item2);
Console.WriteLine("\nApresentação dos itens de nota fiscal \n");
foreach (var item in nf.VetItens)

nf.Mostrar();

nf = null;

GC.Collect();