public abstract class ContaBancaria
{
    public string Numero { get; set; }
    public double Saldo { get; set; }

    public virtual double Depositar(double valor)
    {
        if (valor > 0) 
            Saldo += valor;
        return Saldo;
    }

    public virtual double Sacar(double valor)
    {
        if (valor > 0 && Saldo >= valor)
            Saldo -= valor;
        return Saldo;
    }

    public double Pagar(double valor)
    {
        if (valor > 0 && Saldo >= valor)
            Saldo -= valor;
        return Saldo;
    }

    public void Transferir(ContaBancaria destino, double valor)
    {
        if (valor > 0 && Saldo >= valor)
        {
            Sacar(valor);
            destino.Depositar(valor);
        }
    }

    public override string ToString()
    {
        return $"Numero: {Numero}" +
               $"\nSaldo: {Saldo}\n" ;
    }


}

