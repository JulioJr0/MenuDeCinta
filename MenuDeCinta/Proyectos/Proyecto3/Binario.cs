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
    {   //COMMANDS
        public ICommand GenerarBinarioCommand { get; set; }
        public ICommand VerificarBinarioCommand { get; set; }
        
        public string NumBinario { get; set; }
        public int NumDecimalReal { get; set; }
        public int? NumDecimalUsuario { get; set; }

        public Binario()
        {
            GenerarBinarioCommand = new RelayCommand(GenerarBinario);
            VerificarBinarioCommand = new RelayCommand(Verificar);
        }

        public bool? Ganado { get; set; }
        public bool? JuegoIniciado { get; set; } = false;
        public string Mensaje { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GenerarBinario()
        {
            Random r = new();
            NumDecimalReal = r.Next(1, 255);
            NumBinario = Convert.ToString(NumDecimalReal, 2);
            JuegoIniciado = true;
            Ganado = null;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void Verificar()
        {
            if (NumDecimalUsuario == NumDecimalReal)
            {
                Ganado = true;
                NumDecimalUsuario = null;
                Mensaje = "¡ES VALOR ES CORRECTO!";
            }
            else
            {
                Ganado = false;
                NumDecimalUsuario = null;
                Mensaje = "¡EL VALOR ES INCORRECTO!";
            }

            JuegoIniciado = false;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
