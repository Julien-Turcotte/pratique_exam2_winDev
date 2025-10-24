using Examen2.Data;
using Examen2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Examen2.ViewModels.Pages;

public class MainViewModelEvaluations : ViewModelBase
{
    private JeuxDataProvider _jeuxDataProvider;
    private EvaluationJeuViewModel _evaluationSelectionnee;

    /// <summary>
    /// Liste de jeux
    /// </summary>
    public List<Jeu> Jeux { get; }

    /// <summary>
    /// Liste d'évaluations
    /// </summary>
    public ObservableCollection<EvaluationJeuViewModel> Evaluations { get; }

    /// <summary>
    /// La nouvelle évaluation en construction
    /// </summary>
    public EvaluationJeuViewModel NouvelleEvaluation { get; set; }

    public MainViewModelEvaluations(JeuxDataProvider jeuxDataProvider)
    {
        _jeuxDataProvider = jeuxDataProvider;
        Jeux = new List<Jeu>();
        Evaluations = new ObservableCollection<EvaluationJeuViewModel>();
        NouvelleEvaluation = new EvaluationJeuViewModel(new EvaluationJeu());
    }

    /// <summary>
    /// L'évaluation sélectionnée
    /// </summary>
    public EvaluationJeuViewModel EvaluationSelectionnee
    {
        get => _evaluationSelectionnee;
        set
        {
            if (_evaluationSelectionnee != value)
            {
                _evaluationSelectionnee = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(EvaluationEstSelectionnee));
            }

        }
    }

    /// <summary>
    /// Retourne s'il y a une évaluation sélectionnée en ce moment
    /// </summary>
    public bool EvaluationEstSelectionnee => EvaluationSelectionnee != null;

    internal void ChargerDonnees()
    {
        Jeux.Clear();
        Evaluations.Clear();
        Jeux.AddRange(_jeuxDataProvider.GetJeux());
        List<EvaluationJeu> evalsData = _jeuxDataProvider.GetEvaluations();

        foreach (EvaluationJeu eval in evalsData)
        {
            Evaluations.Add(new EvaluationJeuViewModel(eval));
        }
    }

    /// <summary>
    /// Permet d'ajouter la nouvelle évaluation à la liste d'évaluations
    /// </summary>
    public void AjoutEvaluation()
    {
        Evaluations.Add(NouvelleEvaluation);
        NouvelleEvaluation = new EvaluationJeuViewModel(new EvaluationJeu());
        RaisePropertyChanged(nameof(NouvelleEvaluation));
    }
}
