using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S4U1ConvertirBinario
{
    public class Binario:INotifyPropertyChanged
    {
        public ICommand GenerarBinarioCommand { get; set; }
        public ICommand VerificarCommand { get; set; }

        public string NumeroBinario { get; set; }
        public int NumeroDecimalReal { get; set; }
        public int? NumeroDecimalUsuario { get; set; }

        public Binario()
        {
            GenerarBinarioCommand = new RelayCommand(GenerarBinario);
            VerificarCommand = new RelayCommand(Verificar);
        }

        public bool? Ganado { get; set; }
        public bool? JuegoIniciado { get; set; } = false;
        public string Mensaje { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GenerarBinario()
        {
            Random r = new();
            NumeroDecimalReal = r.Next(1, 255);
            NumeroBinario = Convert.ToString(NumeroDecimalReal, 2);
            JuegoIniciado = true;
            Ganado = null;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Verificar()
        {
            if (NumeroDecimalUsuario == NumeroDecimalReal)
            {
                Ganado = true;
                NumeroDecimalUsuario = null;
                Mensaje = "¡Acertaste!";
            }
            else
            {
                Ganado = false;
                NumeroDecimalUsuario = null;
                Mensaje = "EL VALOR ES INCORRECTO";
            }

            JuegoIniciado = false;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
