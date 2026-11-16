int quantidadeLivros = 2;

Livro[] biblioteca = new Livro[quantidadeLivros];

Livro CadastrarLivo()
{
    Console.WriteLine("Informe o titulo do livro: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    string autor = Console.ReadLine();
    Console.WriteLine("Informe as paginas do livro: ");
    int paginas = int.Parse(Console.ReadLine());

    Livro l = new(titulo, autor, paginas);

    return l;
}

void AdicionarLivros()
{
    for (int i = 0; i < quantidadeLivros; i++)
    {
        biblioteca[i] = CadastrarLivo();
    }
}

void MostrarLivros()
{
    for (int i = 0; i < quantidadeLivros; i++)
    {
        Console.WriteLine(biblioteca[i]);
    }
}

AdicionarLivros();
MostrarLivros();