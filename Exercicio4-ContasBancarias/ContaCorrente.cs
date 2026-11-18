internal class ContaCorrente : ContaBancaria
{
    public double Limite {  get; set; }


    public override double Sacar(double valor)
    {
        if (valor > 0 && Saldo + Limite >= valor )
        {
            Saldo -= valor;
            DeterminarLimite();
        }
        return Saldo;
    }
    public override double Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            DeterminarLimite();
        }
        return Saldo;
    }

    public double DeterminarLimite()
    {
        if (Saldo > 0)
            Limite = Saldo * 3;
        else
            Limite = 0;
        return Limite;
    }

    public override string ToString()
    {
        return base.ToString() + "Limite: " + Limite;
    }

}

