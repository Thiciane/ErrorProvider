public class Pessoa
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    private double peso;
    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    private double altura;
    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public Pessoa(string nome, double peso, double altura)
    {
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;
    }

    public (double, string, string) ImcCal()
    {
        double imc = peso / (altura * altura);
        if (imc < 18.5)
        {
            return (imc, "MAGREZA", "0");
        }
        else if (imc > 18.5 && imc < 24.9)
        {
            return (imc, "NORMAL", "0");
        }
        else if (imc > 25.0 && imc < 29.9)
        {
            return (imc, "SOBREPESO", "I");
        }
        else if (imc > 30.0 && imc < 39.9)
        {
            return (imc, "OBESIDADE", "II");
        }
        else
        {
            return (imc, "OBESIDADE GRAVE ", "III");
        }
    }
}