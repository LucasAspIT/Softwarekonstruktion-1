using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Opgave_S2_01__WPF_Intro_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ClickHere_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("You pushed the button!");
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e) {
            btnGreen.Background = Brushes.Green;
        }

        int counter = 0;
        private void btnCounter_Click(object sender, RoutedEventArgs e) {
            counter++;
            // Converts the int to a string so it can be disaplyed in a text block
            txtCounter.Text = counter.ToString();
        }

        int count1 = 0;
        int count2 = 0;
        private void btnCountUp_Click(object sender, RoutedEventArgs e) {
            count1++;
            count2++;

            txtCount1.Text = count1.ToString();
            txtCount2.Text = count2.ToString();
        }

        private void btnCountDown_Click(object sender, RoutedEventArgs e) {
            count1--;
            count2++;

            txtCount1.Text = count1.ToString();
            txtCount2.Text = count2.ToString();
        }
    }
}
