using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Opgave_S2_01_part_14_15 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void RadRed_Checked(object sender, RoutedEventArgs e) {
            mainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        }

        private void RedYellow_Checked(object sender, RoutedEventArgs e) {
            mainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
        }

        private void RedGreen_Checked(object sender, RoutedEventArgs e) {
            mainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        }

        private void RadHide_Checked(object sender, RoutedEventArgs e) {
            radRed.Visibility = Visibility.Hidden;
            radYellow.Visibility = Visibility.Hidden;
            radGreen.Visibility = Visibility.Hidden;
        }

        private void RadInactive_Checked(object sender, RoutedEventArgs e) {
            radRed.IsEnabled = false;
            radYellow.IsEnabled = false;
            radGreen.IsEnabled = false;
        }

        private void RadActive_Checked(object sender, RoutedEventArgs e) {
            radRed.IsEnabled = true;
            radYellow.IsEnabled = true;
            radGreen.IsEnabled = true;
        }

        private void RadHide_Unchecked(object sender, RoutedEventArgs e) {
            radRed.Visibility = Visibility.Visible;
            radYellow.Visibility = Visibility.Visible;
            radGreen.Visibility = Visibility.Visible;
        }
    }
}
