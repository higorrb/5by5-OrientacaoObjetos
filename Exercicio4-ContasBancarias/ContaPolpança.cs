internal class ContaPolpança : ContaBancaria
{
    public double Sacar(double valor)
    {
        double total = valor + valor * 0.05;
        if (valor > 0 && Saldo >= total)
        {
            Saldo -= total;
        }
        return Saldo;
    }

}

