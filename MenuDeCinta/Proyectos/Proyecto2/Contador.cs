using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S4U1Binario
{
    public class Contador : INotifyPropertyChanged
    {
        public Contador()
        {
            SumarRestarCommand = new RelayCommand<bool>(SumarRestar);
            ResetCommand = new RelayCommand(Reset);
            //SumarRestarCommand = new RelayCommand<bool>(SumarRestar);
            
        }
        public ICommand SumarRestarCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        private int item;

        public int Item
        {
            get { return item; }
            //set { item = value;
            //    //Es un elemento al que automaticamente se suscriben las ventanas "PropertyChanged"
            //    //Siempre que usamos binding se va a suscribir en automático a ese evento
            //    //Después se necesitan dos parametros para el delegado
            //    //El primer paramtreo colocamos el objeto que originó el evento Es una referencia a la clase que originó el evento "this"
            //    //El segundo parametro es que propiedad quiero que se actualice 
            //    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            //}
        }
        public void SumarRestar(bool realiza)
        {
            if (realiza == true)
            {
                item = item + 1;
            }
            else
            {
                if (item == 0)
                {
                    item = 0;
                }
                else
                {
                    item = item - 1;
                }
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
       public void Reset()
        {
            item = 0;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
