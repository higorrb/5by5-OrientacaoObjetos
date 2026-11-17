int quantidadeLivros = 0;




Livro CadastrarLivo()
{
    Console.WriteLine("Informe o titulo do livro: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    string autor = Console.ReadLine();

    int paginas = 0;
    while (paginas <= 0) 
    {
        Console.WriteLine("Informe as paginas do livro: ");
        paginas = int.Parse(Console.ReadLine());
    }

    //RETORNANDO O OBJETO DIRETO SEM CRIAR VARIAVEL
    return new Livro(titulo, autor, paginas);

    
}

Livro[] AdicionarLivros()
{
    while (quantidadeLivros <= 0)
    {
        Console.WriteLine("Informe quantos livros vc quer adcionar: ");
        quantidadeLivros = int.Parse(Console.ReadLine());
    }

    Livro[] biblioteca = new Livro[quantidadeLivros];

    for (int i = 0; i < quantidadeLivros; i++)
    {
        biblioteca[i] = CadastrarLivo();
    }
    return biblioteca;
}

void MostrarLivros(Livro[] livro)
{
    for (int i = 0; i < quantidadeLivros; i++)
    {
        Console.WriteLine(livro[i]);
    }
}


MostrarLivros(AdicionarLivros());