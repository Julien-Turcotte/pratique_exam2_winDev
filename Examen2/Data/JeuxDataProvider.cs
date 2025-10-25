using Examen2.Models;
using System.Collections.Generic;

namespace Examen2.Data;

public class JeuxDataProvider : IJeuxDataProvider
{
    private static List<Plateforme> plateformes = new List<Plateforme>()
    {
        new Plateforme("PC"),
        new Plateforme("PS5"),
        new Plateforme("XBOX"),
        new Plateforme("Switch")
    };

    private static List<Jeu> jeux = new List<Jeu>(){
       new Jeu("Luigi's Mansion 2", plateformes[3]),
       new Jeu("The Last of Us", plateformes[1]),
       new Jeu("Dragon Age: The Veilguard", plateformes[0]),
    };

    public List<Plateforme> GetPlateformes()
    {
        return plateformes;
    }

    public List<EvaluationJeu> GetEvaluations()
    {
        return new List<EvaluationJeu>() {
            new EvaluationJeu(jeux[0], 4, "Un classique")
        };
    }

    public List<Jeu> GetJeux()
    {
        return jeux;
    }
}
