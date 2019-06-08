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
        private string baseR;
        private string altura;
        private string area;
        private string perimetro;
        private string distancia;

        public Rectangulo()
        {
            this.baseR = "4";
            this.altura = "2";
        }



        public string BaseR {
            get { return baseR; }
            set
            {
                OnPropertyChanged("BaseR");
            }
        }
        public string Altura
        {
            get => altura;
            set
            {

                OnPropertyChanged("Altura");
            }
        }

        public string Area
        {
            get
            {
                int area = int.Parse(BaseR) * int.Parse(Altura);
                return area.ToString();
            }
            set
            {
                int area = int.Parse(BaseR) * int.Parse(Altura);
                Console.WriteLine("El area es", area);
            }
        }

        public string Perimetro
        {
            get
            {
                int perimetro = (2 * int.Parse(BaseR)) + (2 * int.Parse(Altura));
                return perimetro.ToString();
            }
            set
            {
                int perimetro = (2*int.Parse(BaseR)) + (2*int.Parse(Altura));
                Console.WriteLine("El perimetro es", perimetro);
            }
        }
        
        //public string Distancia
        //{
        //    get
        //    {
        //        int distancia=Math.Sqrt()
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }


        //public void areaR()
        //{
        //    area = BaseR * Altura;
        //    Console.WriteLine("El area es", area);
        //}
        //public void perimetroR()
        //{
        //    perimetro = ((2 * BaseR) + (2 * Altura));
        //    Console.WriteLine("El perimetro es", perimetro);
        //}


    }
}
