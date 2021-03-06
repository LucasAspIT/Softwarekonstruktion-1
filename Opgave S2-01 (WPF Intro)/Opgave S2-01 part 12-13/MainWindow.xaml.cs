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

namespace Opgave_S2_01_part_12_13 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e) {
            textblockText.Text = "Check!";
        }

        private void checkBox_UnChecked(object sender, RoutedEventArgs e) {
            textblockText.Text = "Uncheck!";
        }

        private void checkBox_Click(object sender, RoutedEventArgs e) {
            if (checkBox.IsChecked == null) {
                textblockText.Text = "Maybe?";
            }
        }
    }
}
