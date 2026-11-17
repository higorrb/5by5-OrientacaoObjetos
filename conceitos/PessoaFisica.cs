
public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
    public string Mobile { get; set; }
    public char Gender { get; set; }

    //public PessoaFisica(string name) : base(name)
    //{
    //}

    public PessoaFisica(string cpf, string name) : base(name)
    {
        CPF = cpf;
    }


    public void TransformarNome()
    {
        Name = Name.ToUpper();
    } 

    public string getCPF()
    {
        return CPF;
    }
}

