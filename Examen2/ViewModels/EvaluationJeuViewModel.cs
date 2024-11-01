using Examen2.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Examen2.ViewModels;

public class EvaluationJeuViewModel : ViewModelValidable
{
    private EvaluationJeu _evaluation;

    public EvaluationJeuViewModel(EvaluationJeu evaluation)
    {
        _evaluation = evaluation;
        _errors.Add("Description", new ObservableCollection<ValidationResult>());
    }

    public Jeu Jeu
    {
        get => _evaluation.Jeu;
        set
        {
            if (_evaluation.Jeu != value)
            {
                _evaluation.Jeu = value;
                RaisePropertyChanged();
            }
        }
    }

    public int Note
    {
        get => _evaluation.Note;
        set
        {
            if (_evaluation.Note != value && Validate(value))
            {
                _evaluation.Note = value;
                RaisePropertyChanged();
            }

        }
    }

    public string Description
    {
        get => _evaluation.Description;
        set
        {
            if (_evaluation.Description != value && Validate(value))
            {
                _evaluation.Description = value;
                RaisePropertyChanged();
            }
        }
    }

    public DateTime Date
    {
        get => _evaluation.Date;
        set
        {
            if (_evaluation.Date != value)
            {
                _evaluation.Date = value;
                RaisePropertyChanged();
            }
        }
    }
}
