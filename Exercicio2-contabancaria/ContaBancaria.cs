internal class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public void setTitular(string titular)
    {
        Titular = titular;
    }

    public void setSaldo(double saldo)
    {
        Saldo = saldo;
    }

    public string getTitular()
    {
        return Titular;
    }

    public double getSaldo()
    {
        return Saldo;
    }

    public bool Sacar(double valor)
    {
        if(Saldo > 0 && Saldo - valor >= 0)
        {
            Saldo = Saldo - valor;
            Console.WriteLine($"Valor {valor} sacado com SUCESSO!");
            return true;
        }
        else
        {
            Console.WriteLine($"Valor {valor} NÃO foi possivel realizar a transação, verifique seu saldo!");
            return false;
        }
    }

    public bool Depositar(double valor)
    {
        if (Saldo > 0)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"Valor {valor} depositado com SUCESSO!");
            return true;
        }
        else
        {
            Console.WriteLine($"Valor {valor} NÃO foi possivel realizar a transação!");
            return false;
        }
    }

    public override string ToString()
    {
        return "Titular: " + Titular + " Saldo: " + Saldo;
    }

}

