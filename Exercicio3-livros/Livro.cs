
public class Livro
{
    public string Titulo;
    public string Autor;
    public int Paginas;

    public Livro(string titulo, string autor, int paginas)
    {
        Titulo = titulo;
        Autor = autor;
        setPaginas(paginas);
    }

  
    public void setPaginas(int paginas)
    {
        if (paginas > 0)
        {
            Paginas = paginas;
        }
        else
        {
            Console.WriteLine("Quantidade de páginas inválida!");
        }
    }

    public string getTitulo()
    {
        return Titulo;
    }

    public string getAutor()
    {
        return Autor;
    }

    public int getPaginas()
    {
        return Paginas;
    }

    public override string ToString()
    {
        return "Título: " + Titulo +
               "\nAutor: " + Autor +
               "\nPáginas: " + Paginas;
    }
}


