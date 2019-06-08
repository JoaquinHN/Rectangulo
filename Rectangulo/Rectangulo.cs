using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Rectangulo
{
    public class Rectangulo: INotifyPropertyChanged
    {
        private double baseR;
        private double altura;
        private double area;
        private double perimetro;

        public Rectangulo()
        {
            this.baseR = 4;
            this.altura = 2;
        }

        public double BaseR {
            get { return baseR; }
            set
            {
                OnPropertyChanged("BaseR");
            }
        }
        public double Altura
        {
            get => altura;
            set
            {

                OnPropertyChanged("Altura");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }


        public void areaR()
        {
            area = BaseR * Altura;
            Console.WriteLine("El area es", area);
        }
        public void perimetroR()
        {
            perimetro = ((2 * BaseR) + (2 * Altura));
        }


    }
}
