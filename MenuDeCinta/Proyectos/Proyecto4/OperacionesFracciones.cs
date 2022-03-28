using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S4U1CalculadoraFracciones
{
    public class OperacionesFracciones: INotifyPropertyChanged
    {
        public OperacionesFracciones()
        {
            SumarFraccionesCommand = new RelayCommand(Sumar);
            RestarFraccionesCommand = new RelayCommand(Restar);
            LimpiarFraccionesCommand = new RelayCommand(Limpiar);

        }
        public ICommand SumarFraccionesCommand { get; set; }
        public ICommand RestarFraccionesCommand { get; set; }
        public ICommand LimpiarFraccionesCommand { get; set; }


        private int resultadoNumerador;

        public int ResultadoNumerador
        {
            get { return resultadoNumerador; }
            set { resultadoNumerador = value; }
        }
        private int resultadoDenominador;

        public int ResultadoDenominador
        {
            get { return resultadoDenominador; }
            set { resultadoDenominador = value; }
        }
        public bool JuegoIniciado { get; set; } = false;

        //private int numerador1;
        //private int denominador1;
        //private int numerador2;
        //private int denominador2;

        public int Numerador1 { get; set; }
        public int Denominador1 { get; set; }
        public int Numerador2 { get; set; }
        public int Denominador2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Sumar()
        {
            if (Denominador1 == Denominador2)
            {
                resultadoDenominador = Denominador1;
                resultadoNumerador = Numerador1 + Numerador2;
            }
            else
            {
                resultadoDenominador = Denominador1 * Denominador2;
                resultadoNumerador = Numerador1 * Denominador2 + Denominador1 * Numerador2;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
        public void Restar()
        {
            if (Denominador1 == Denominador2)
            {
                resultadoDenominador = Denominador1;
                resultadoNumerador = Numerador1 - Numerador2;
            }
            else
            {
                resultadoDenominador = Denominador1 * Denominador2;
                resultadoNumerador = Numerador1 * Denominador2 - Denominador1 * Numerador2;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
        public void Limpiar()
        {
            Numerador1 = 0;
            Numerador2 = 0;
            Denominador1 = 0;
            Denominador2 = 0;
            ResultadoNumerador = 0;
            ResultadoDenominador = 0;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));

        }
    }
}
