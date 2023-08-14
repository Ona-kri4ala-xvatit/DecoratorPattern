using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeaponMenu.ViewModels.Base
{
    public abstract class Inpc : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged<T>(out T prop, T value, [CallerMemberName] string? propName = null)
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
