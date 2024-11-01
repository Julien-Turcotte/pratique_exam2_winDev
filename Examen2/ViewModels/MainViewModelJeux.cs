using Examen2.Data;
using Examen2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Examen2.ViewModels;

public class MainViewModelJeux : ViewModelBase
{
    private IJeuxDataProvider _jeuxDataProvider;
    public ObservableCollection<JeuViewModel> Jeux { get; }

    public MainViewModelJeux(IJeuxDataProvider jeuxDataProvider)
    {
        this._jeuxDataProvider = jeuxDataProvider;
        Jeux = new ObservableCollection<JeuViewModel>();
    }

    public void ChargerDonnees()
    {
        Jeux.Clear();
        List<Jeu> jeuxData = _jeuxDataProvider.GetJeux();
        foreach (Jeu jeu in jeuxData)
        {
            Jeux.Add(new JeuViewModel(jeu));
        }
    }
}
