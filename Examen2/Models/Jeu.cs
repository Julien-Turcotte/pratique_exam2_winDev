namespace Examen2.Models;

public class Jeu
{
    public string Nom { get; set; }

    public Plateforme Plateforme { get; set; }

    public string NomComplet
    {
        get => $"{Nom} ({Plateforme.Nom})";
    }

    public Jeu(string nom = "", Plateforme plateforme = null)
    {
        Nom = nom;
        Plateforme = plateforme;
    }
}
