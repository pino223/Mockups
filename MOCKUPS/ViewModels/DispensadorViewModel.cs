using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MOCKUPS.ViewModels
{
    internal class DispensadorViewModel : INotifyPropertyChanged
    {

        private string _mensaje;
        public string Mensaje
        {
            get => _mensaje;
            set
            {
                _mensaje = value;
                OnPropertyChanged(nameof(Mensaje));
            }
        }

        public DispensadorViewModel()
        {
            Mensaje = "Bienvenido al dispensador";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
