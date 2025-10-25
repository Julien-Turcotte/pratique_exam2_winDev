using Examen2.Models;
using System.Collections.Generic;

namespace Examen2.Data;

public interface IJeuxDataProvider
{

    /// <summary>
    /// Retourne une liste de plateformes de jeux
    /// </summary>
    List<Plateforme> GetPlateformes();

    /// <summary>
    /// Retourne une liste de jeux
    /// </summary>
    List<Jeu> GetJeux();

    /// <summary>
    /// Retourne une liste d'évaluations de jeux
    /// </summary>
    List<EvaluationJeu> GetEvaluations();
}
