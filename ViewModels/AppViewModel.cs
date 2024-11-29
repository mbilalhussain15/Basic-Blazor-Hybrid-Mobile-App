using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject1.ViewModels
{
    public class AppViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _isLoadingBusy= true;
        public bool IsLoadingBusy {
            get => _isLoadingBusy;
            set
            {
                if (_isLoadingBusy != value)
                {
                    _isLoadingBusy = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoadingBusy)));
                }

            }
        }
        public void ToggleIsLoadingBusy(bool isLoadingBusy) => IsLoadingBusy = isLoadingBusy;
    }
}
