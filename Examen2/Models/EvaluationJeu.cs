using System;

namespace Examen2.Models;

public class EvaluationJeu
{
    public Jeu Jeu { get; set; }

    public int Note { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }

    public EvaluationJeu(Jeu jeu = null, int note = 0, string desc = "")
    {
        Jeu = jeu;
        Note = note;
        Description = desc;
        Date = DateTime.Now;
    }
}
