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

namespace Opgave_S2_01_part_06 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // Removes the default text when the textblock is in focus (clicked on) & disables the function so it doesn't delete anything else
        private void InputGotFocus(object sender, RoutedEventArgs e) {
            button.IsEnabled = true;
            input.Text = string.Empty;
            // Remove the GotFocus handler
            input.GotFocus -= InputGotFocus;
        }

        private void button_Click(object sender, RoutedEventArgs e) {

            if (input.Text != string.Empty) {
            output.Text = $"Hello {input.Text}, and welcome to the program.";
            }
            else {
            output.Text = "Please input your name.";
            }
        }
    }
}
