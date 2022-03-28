using GalaSoft.MvvmLight.Command;
using S4U1Binario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using U1Act1TableroFootball;
using S4U1ConvertirBinario;
using S4U1CalculadoraFracciones;

namespace MenuDeCinta.Proyectos
{
    public class MenuCinta
    {
        public MenuCinta()
        {
            TableroCommand = new RelayCommand(Proyecto1Tablero);
            ContadorCommand = new RelayCommand(Proyecto2Contador);
            BinarioCommand = new RelayCommand(Proyecto3Binario);
            FraccionesCommand = new RelayCommand(Proyecto4Fracciones);



        }
        public ICommand TableroCommand { get; set; }
        public ICommand ContadorCommand { get; set; }
        public ICommand BinarioCommand { get; set; }
        public ICommand FraccionesCommand { get; set; }




        public void Proyecto1Tablero()
        {
            Tablero tablero = new();
            tablero.Show();
            
        }
        public void Proyecto2Contador()
        {
            Contador1 contador = new();
            contador.Show();
        }
        public void Proyecto3Binario()
        {
            Binario1 binario = new();
            binario.Show();
        }
        public void Proyecto4Fracciones()
        {
            Fracciones fracciones = new();
            fracciones.Show();
        }
    }
}
