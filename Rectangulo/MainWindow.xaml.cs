﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rectangulo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Rectangulo Rec { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Rec = new Rectangulo { AX1 = "0", AY1 = "0", BX1 = "0", BY1 = "0", AX2 = "0", AY2 = "0", BX2 = "0", BY2 = "0" };
            this.DataContext = Rec;
        }
    }
}
