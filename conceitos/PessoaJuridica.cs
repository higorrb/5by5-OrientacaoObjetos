public class PessoaJuridica : Pessoa
{
    public string Alias {  get; set; }
    public string CNPJ {  get; set; }

    public PessoaJuridica(string name, string cnpj) : base(name)
    {
        CNPJ = cnpj;
    }

    public PessoaJuridica(string name, string cnpj, string? alias) : base(name) 
    {
        CNPJ = cnpj;
        if (string.IsNullOrEmpty(alias)) 
        {
            alias = name;
        }
        Alias = alias;

    }
}

