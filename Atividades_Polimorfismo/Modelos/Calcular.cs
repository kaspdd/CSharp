namespace Atividades_Polimorfismo.Modelos;

internal class Calcular
{
    //circulo
    public double CalculandoArea(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }
    //retangulo
    public double CalculandoArea(double a, double l)
    {
        return a*l;
    }

    public double CalculandoArea(double bMaior, double bMenor, double a)
    {
        return (bMaior+bMenor)*a/2;
    }

}