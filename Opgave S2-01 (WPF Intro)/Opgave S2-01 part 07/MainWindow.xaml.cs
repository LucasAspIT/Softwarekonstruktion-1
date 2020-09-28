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

namespace Opgave_S2_01_part_07 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // Removes the default text when the textblock is in focus (clicked on) & disables the function so it doesn't delete anything else
        private void FirstNameGotFocus(object sender, RoutedEventArgs e) {

            // Empty the text box
            firstName.Text = string.Empty;
            // Remove the GotFocus handler
            firstName.GotFocus -= FirstNameGotFocus;
        }

        // Removes the default text when the textblock is in focus (clicked on) & disables the function so it doesn't delete anything else
        private void LastNameGotFocus(object sender, RoutedEventArgs e) {
            // Enalbe the submit button
            button.IsEnabled = true;

            // Empty the text box
            lastName.Text = string.Empty;
            // Remove the GotFocus handler
            lastName.GotFocus -= LastNameGotFocus;
        }

        private void button_Click(object sender, RoutedEventArgs e) {

            // Check if the user has written their first and last name
            if (firstName.Text != string.Empty && lastName.Text != string.Empty) {
                output.Text = $"Hello {firstName.Text} {lastName.Text}, and welcome to the program.";
            }
            else {
                output.Text = "Please input your full name.";
            }
        }
    }
}
