using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Tutorial.Utils;


namespace Tutorial.ViewModel
{
    class PrincipalViewModel : BaseViewModel
    {
        private ICommand _mensajeCommand, _mouseLeaveEventCommand;

        public ICommand MensajeCommand { get { if (_mensajeCommand == null) _mensajeCommand = new RelayCommand(Mensaje); return _mensajeCommand; } }
        public ICommand MouseLeaveEventCommand { get { if (_mouseLeaveEventCommand == null) _mouseLeaveEventCommand = new RelayCommand(MouseLeave); return _mouseLeaveEventCommand; } }


        public PrincipalViewModel()
        {

        }

        public void Mensaje()
        {
            MessageBox.Show("Desde el VM");
        }

        public void MouseLeave()
        {
            MessageBox.Show("Mensaje desde VM con Behavior");

        }


    }
}
