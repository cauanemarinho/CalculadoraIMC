public class Individuo
{
    public folat Altura{get; set;}
    public float Peso {get; set;}

    public Individuo(float altura, float peso)
    {
        Altura = altura;
        Peso = peso;
    }

    public double IMC { get => Peso / (Altura * altura);}
}