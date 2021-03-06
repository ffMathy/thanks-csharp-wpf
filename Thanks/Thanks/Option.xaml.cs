﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Thanks
{
    /// <summary>
    /// Interaction logic for Option.xaml
    /// </summary>
    public partial class Option : UserControl
    {
        public Option()
        {
            Icons = new ObservableCollection<Image>();

            InitializeComponent();
        }

        public bool IsSelected { get; set; }

        public ObservableCollection<Image> Icons { get; private set; } 
    }
}
