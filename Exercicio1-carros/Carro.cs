internal class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoFabricante;
    public int AnoModelo;
    public double PreçoVenda;
    public Motor MotorCarro;

    public Carro()
    {
    }

    public Carro(string fabricante, string modelo, int anoFabricante, int anoModelo, double preçoVenda, Motor motorCarro)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        AnoFabricante = anoFabricante;
        AnoModelo = anoModelo;
        PreçoVenda = preçoVenda;
        MotorCarro = motorCarro;
    }

    //TRATAMENTO DE MODELO DE ANO
    private bool ValidarAnoModelo(int ano)
    {
        if (ano == AnoFabricante || ano == AnoFabricante + 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public double CalcularIPVA()
    {
        if (2026 - AnoModelo < 20)
        {
            return PreçoVenda * 0.04;
        }
        else
        {
            return 0.00;
        }
    }



    //SET E GET
    public void setFabricante(string fabricante)
    {
        Fabricante = fabricante;
    }

    public void setModelo(string modelo)
    {
        Modelo = modelo;
    }

    public void setAnoFabricante(int anoFabricante)
    {
        AnoFabricante = anoFabricante;
    }

    public void setAnoModelo(int anoModelo)
    {
        //TRATAMENTO DE ANO MODELO
        if (ValidarAnoModelo(anoModelo))
            AnoModelo = anoModelo;
        else
            AnoModelo = AnoFabricante;
    }

    public void setPrecoVenda(double precoVenda)
    {
        PreçoVenda = precoVenda;
    }

    public string getFabricante()
    {
        return Fabricante;
    }

    public string getModelo()
    {
        return Modelo;
    }

    public int getAnoFabricante()
    {
        return AnoFabricante;
    }

    public int getAnoModelo()
    {
        return AnoModelo;
    }

    public double getPrecoVenda()
    {
        return PreçoVenda;
    }


    public override string? ToString()
    {
        return "fabricante: " + Fabricante + "\n" +
               "modelo: " + Modelo + "\n" +
               "anoFabricante: " + AnoFabricante + "\n" +
               "anoModelo: " + AnoModelo + "\n" +
               "preçoVenda: " + PreçoVenda + "\n" +
               "Motor: " + MotorCarro;
    }
}

