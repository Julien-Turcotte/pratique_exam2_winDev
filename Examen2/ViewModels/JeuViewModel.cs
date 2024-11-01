using Examen2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Examen2.ViewModels;

public class JeuViewModel : ViewModelValidable
{
    private Jeu _jeu;

    public JeuViewModel(Jeu jeu)
    {
        _jeu = jeu;
        _errors.Add("Nom", new ObservableCollection<ValidationResult>());
    }

    public Jeu Jeu
    {
        get => _jeu;
    }

    public string Nom
    {
        get => _jeu.Nom;
        set
        {
            if (_jeu.Nom != value && Validate(value))
            {
                _jeu.Nom = value;
                RaisePropertyChanged();
            }
        }
    }

    public Plateforme Plateforme
    {
        get => _jeu.Plateforme;
        set
        {
            if (_jeu.Plateforme != value)
            {
                _jeu.Plateforme = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(NomPlateforme));
            }
        }
    }

    public string NomPlateforme
    {
        get => _jeu.Plateforme.Nom;
    }
}
