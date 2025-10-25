using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Examen2.ViewModels;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    /// <summary>
    /// Évènement lancé lorsqu'une propriété est modifiée
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Méthode chargée de lancer l'évènement PropertyChanged
    /// </summary>
    protected void RaisePropertyChanged([CallerMemberName] string propriete = "")
    {
        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propriete));
    }
}