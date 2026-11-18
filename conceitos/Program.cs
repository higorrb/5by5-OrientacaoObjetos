PessoaFisica pf = new("12312312", "higor");

Pessoa p = new PessoaJuridica("321", "5by5"); //GENERALIZANDO, usando o construtor de PessoaJuridica, mas apenas usando as propriedades de Pessoa

Console.WriteLine(pf);

Console.ReadKey();


/*
Pessoa p1 = new("higor", 10, 'M'); //Pessoa p = new Pessoa();

Pessoa p = new Pessoa();


Console.Write("Digite seu nome");
p1.SetNome(Console.ReadLine()); //metodo do objeto p1 da Classe Pessoa

Console.WriteLine(p1.GetNome());
p1.Idade = 42;


//Console.WriteLine(p1.Nome);
//Console.WriteLine(p1.Idade);
//Console.WriteLine(p1.Sexo);

Console.WriteLine(p1.ToString());

//Pessoa p2 = new();
*/