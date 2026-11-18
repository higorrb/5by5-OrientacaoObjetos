public abstract class ContaBancaria
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public virtual bool Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            return true;
        }
       
        return false;
    }

    public virtual bool Sacar(double valor)
    {
        if (valor > 0 && Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }
        
        return false;
    }

    public virtual bool Pagar(double valor)
    {
        return Sacar(valor);    
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

