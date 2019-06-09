using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace Terminado
{
     public class Rectangulo: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private string aX1;
        private string bX1;
        private string aX2;
        private string bX2;
        private string aY1;
        private string bY1;
        private string aY2;
        private string bY2;

        //Puntos X1

        public string AX1
        {
            get => aX1;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) aX1 = value;
                OnPropertyChanged("AX1");
            }
        }
        public string BX1
        {
            get => bX1;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) bX1 = value;
                OnPropertyChanged("BX1");
            }
        }

        //Punto XX2
        public string AX2
        {
            get => aX2;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) aX2 = value;
                OnPropertyChanged("AX2");
            }
        }

        public string BX2
        {
            get => bX2;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) bX2 = value;
                OnPropertyChanged("BX2");
            }
        }

        //Punto Y1
        public string AY1
        {
            get => aY1;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) aY1 = value;
                OnPropertyChanged("AY1");
            }
        }

        public string BY1
        {
            get => bY1;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) bY1 = value;
                OnPropertyChanged("BY1");
            }
        }

        //Punto Y2
        public string AY2
        {
            get => aY2;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) aY2 = value;
                OnPropertyChanged("AY2");
            }
        }

        public string BY2
        {
            get => bY2;
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) bY2 = value;
                OnPropertyChanged("BY2");
                OnPropertyChanged("BRectangulo");
                OnPropertyChanged("ARectangulo");
                if (VAlturaR() != 0 || VBaseR() != 0)
                {
                    OnPropertyChanged("Perimetro");
                    OnPropertyChanged("Area");
                }
                else
                {
                    Perimetro = "0";
                    Area = "0";
                    MessageBox.Show("No existe rectangulo");
                }





            }
        }



        //METODOS 
        //Formula de distancia
        public double Distancia(double x1, double x2, double y1, double y2)
        {
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }
        //Verificar Altura
        public Double VAlturaR()
        {
            double AlturaR1, AlturaR2;
            AlturaR1 = Distancia(double.Parse(aX1), double.Parse(bX2), double.Parse(aY1), double.Parse(bY2));
            AlturaR2 = Distancia(double.Parse(bX1), double.Parse(aX2), double.Parse(bY1), double.Parse(aY2));
            if (AlturaR1 != AlturaR2)
            {
                AlturaR1 = 0;

            }
            return AlturaR1;
        }
        //Verificar Base
        public Double VBaseR()
        {
            double BaseR1, BaseR2;
            BaseR1 = Distancia(double.Parse(aX1), double.Parse(bX1), double.Parse(aY1), double.Parse(bY2));
            BaseR2 = Distancia(double.Parse(aX2), double.Parse(bX2), double.Parse(aY2), double.Parse(bY2));
            if (BaseR1 != BaseR2)
                BaseR1 = 0;
            return BaseR1;
        }
        //Obtenet Altura 
        public string ARectangulo
        {
            get
            {
                double AlturaRe = VAlturaR();
                return AlturaRe.ToString();
            }
            set
            {
                double AlturaRe = VAlturaR();
                AlturaRe.ToString();
                OnPropertyChanged("ARectangulo");
            }
        }
        //Obtener Base
        public string BRectangulo
        {
            get
            {
                double BaseRe = VBaseR();
                return BaseRe.ToString();
            }
            set
            {
                double BaseRe = VBaseR();
                BaseRe.ToString();
                OnPropertyChanged("BRectangulo");
            }
        }
        //Obtener Perimetro
        public string Perimetro
        {
            get
            {
                double perimetro;
                perimetro = 2 * double.Parse(BRectangulo) + 2 * double.Parse(ARectangulo);
                return perimetro.ToString();
            }
            set
            {
                double perimetro;
                perimetro = 2 * double.Parse(BRectangulo) + 2 * double.Parse(ARectangulo);
                perimetro.ToString();
                OnPropertyChanged("Perimetro");
            }
        }

        //Obtener Area
        public string Area
        {
            get
            {
                double areaRe;
                areaRe = double.Parse(BRectangulo) * double.Parse(ARectangulo);
                return areaRe.ToString();
            }
            set
            {
                double areaRe;
                areaRe = double.Parse(BRectangulo) * double.Parse(ARectangulo);
                areaRe.ToString();
                OnPropertyChanged("Area");
            }
        }




    }
}
