namespace Examen2.Models;

public class Plateforme
{
    public string Nom { get; set; }

    public Plateforme(string nom = "")
    {
        Nom = nom;
    }
}