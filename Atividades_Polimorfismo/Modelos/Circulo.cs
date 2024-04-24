namespace Atividades_Polimorfismo.Modelos;

internal class Circulo : Calcular
{
    public Circulo(double raio)
    {
        this.Raio = raio;
    }
    public double Raio { get; set; }
    public double AreaCirculo { get; set; }
    
    //public Calcular c;

}