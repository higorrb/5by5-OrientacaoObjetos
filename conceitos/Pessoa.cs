public class Pessoa
{
    public string Nome;
    private int Idade;
    private char Sexo;

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




}

