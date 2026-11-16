
Carro[] vetorCarro = new Carro [4];

//Carro c1 = new("Toyota", "Corola", 2000, 2005, 80000);
//Carro c2 = new("teste", "testemod", 1999, 2001, 100000);
//Carro c3 = new("carrofab", "carrotest", 2001, 2015, 85000);
//Carro c4 = new("fabrica", "modelo", 2009, 2009, 810000);

/*
vetorCarro[0] = c1;
vetorCarro [1] = c2;
vetorCarro[2] = c3;
vetorCarro[3] = c4;
*/

Carro CadastrarCarro()
{
    Console.WriteLine("Informe o fabricante: ");
    string fab = Console.ReadLine();
    Console.WriteLine("Informe o modelo: ");
    string mod = Console.ReadLine();
    Console.WriteLine("Informe o ano fabricacao: ");
    int anofab = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ano modelo: ");
    int anomod = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o preco: ");
    double preco = double.Parse(Console.ReadLine());

    //Carro c = new();

    Carro c = new(fab,mod,anofab,anomod,preco);

    //c.setFabricante(fab);
    //c.setModelo(mod);
    //c.setAnoFabricante(anofab);
    //c.setAnoModelo(anomod);
    //c.setPrecoVenda(preco);

    return c;

}

void AdicionarCarros()
{
    for (int i = 0; i < vetorCarro.Length; i++)
    {
        vetorCarro [i] = CadastrarCarro();
    }
}

void MostrarCarro()
{
    for (int i = 0; i < vetorCarro.Length; i++)
    {
        Console.WriteLine(vetorCarro[i].ToString()); 
        //NAO PRECISA USAR O ToString(), pois o Console.WriteLine ja mostra uma string
        //e como sobrescrevemos o metodo ToString() todo uso desse metodo para retornar os Objetos da Classe Carro ja sai formatado como feito no metodo da Classe
    }
}

AdicionarCarros();
MostrarCarro ();




