using orcamento;

Console.WriteLine("Inicie o processo para orçar seu livro!");
Console.WriteLine(" ");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
Console.WriteLine(" ");

calculo orca1 = new calculo();

orca1.Nome = "Gustavo";
orca1.QtdLivros = 2;
orca1.QtdPaginasPorLivro = 63;
orca1.ValorPorPagina = 0.75;

orca1.CalculaLivro(orca1.QtdPaginasPorLivro, orca1.ValorPorPagina);
Console.WriteLine(" ");

Console.WriteLine("Sr " + orca1.Nome + ", agradecemos pela compra!");
Console.WriteLine(" ");

Console.WriteLine("O Valor por livro será de R$ " + orca1.ValorPorLivro);

orca1.CalculaValorTotalLivros(orca1.QtdLivros);
Console.WriteLine(" ");

Console.WriteLine("O Valor para todos os " + orca1.QtdLivros + " livros será de R$ " + orca1.ValorTotalLivros);

Console.WriteLine(" ");

comissao ganho = new comissao(orca1.ValorTotalLivros);

Console.WriteLine("A comissão do vendedor para os livros acima vendidos será de R$ " + ganho.ComissaoVendedor);