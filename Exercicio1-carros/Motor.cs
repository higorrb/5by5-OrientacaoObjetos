public class Motor
{
    public string TipoCombustivel;
    public int Cilindrada;
    public float Potencia;

    public void setTipoComustivel(string tipoCombustivel)
    {
        TipoCombustivel = tipoCombustivel;
    }

    public void setCilindrada(int cilindrada)
    {
        Cilindrada = cilindrada;
    }

    public void setPotencia(float potencia)
    {
        Potencia = potencia;
    }

    public string getTipoCombustivel()
    {
        return TipoCombustivel;
    }

    public int getCilindrada()
    {
        return Cilindrada;
    }

    public float getPotencia()
    {
        return Potencia;
    }

    public override string ToString()
    {
        return "Combustível: " + TipoCombustivel +
               " Cilindrada: " + Cilindrada +
               " Potência: " + Potencia;
    }
}

