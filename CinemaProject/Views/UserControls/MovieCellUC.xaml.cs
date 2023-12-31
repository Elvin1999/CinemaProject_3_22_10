﻿using CinemaProject.ViewModels;
using System;
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

namespace CinemaProject.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MovieCellUC.xaml
    /// </summary>
    public partial class MovieCellUC : UserControl
    {
        public MovieCellUC(MovieCellViewModel vm)
        {
            InitializeComponent();
            vm.StarsPanel = starsPanel;
            this.DataContext = vm;
        }
    }
}
