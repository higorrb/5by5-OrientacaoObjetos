public class ContaCorrente : ContaBancaria
{
    public double Limite; //deixar ela como ATRIBUTO pois ela vai ser usada somente na classse

    public ContaCorrente(double limite)
    {
        Limite = limite;
    }

    public override bool Sacar(double valor)
    {
        if (valor > 0 && Saldo + Limite >= valor )
        {
            Saldo -= valor;
            DeterminarLimite();
            return true;
        }
        return false;
    }

    public override bool Depositar(double valor)
    {
        if (base.Depositar(valor)) //TAMBEM posso usar o base para pegar o metdo base e acrescentar a funcao de limite
        {
            DeterminarLimite();
            return true;
        }
        return false;
    }

    public override bool Pagar(double valor)
    {
        return Sacar(valor);
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

