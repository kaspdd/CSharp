namespace Atividades_Polimorfismo.Modelos;

internal class Calcular
{
    public double AreaCirculo { get; set; }
    public double AreaRetangulo { get; set; }
    public double AreaTrapezio { get; set; }
    public string ResumoCirculo => $"A area do circulo 'e: {AreaCirculo:f1}";
    public string ResumoRetangulo => $"A area do circulo 'e: {AreaRetangulo:f1}";
    public string ResumoTrapezio => $"A area do circulo 'e: {AreaTrapezio:f1}";
    //circulo
    public double CalculandoArea(Circulo c)
    {
        AreaCirculo = Math.PI * Math.Pow(c.Raio, 2);
        return AreaCirculo;
    }
    //retangulo
    public double CalculandoArea(Retangulo r)
    {
        AreaRetangulo = r.Altura*r.Largura;
        return AreaRetangulo;
    }

    public double CalculandoArea(Trapezio t)
    {
        AreaTrapezio = (t.BaseMaior+t.BaseMenor)*t.Altura/2; 
        return AreaTrapezio;
    }

}