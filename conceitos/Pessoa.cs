public abstract class Pessoa
{
    public string Name { get; set; } //prop -> get e set implicito - tornando uma propriedade
    public string Address { get; set; }
    public DateOnly Date { get; set; }
    public string Phone { get; set; }

    
    protected Pessoa(string name)
    {
        Name = name;
        Date = DateOnly.FromDateTime(DateTime.Now);
    }

    public override string ToString()
    {
        return $"Nome: {Name}" +
               $"\nData de Criação: {Date}" +
               $"\nTelefone: {Phone}" ;
    }


    /*
    public Pessoa(string nome, int idade, char sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }

    public string GetNome()
    {
        return Nome;
    }

    public override string? ToString()
    {
        return base.ToString();
    }

    //public override string ToString()
    //{
    //    return "Nome: " + Nome + "\nIdade: " + Idade + "\nSexo: " + Sexo;
    //}
    */



}

