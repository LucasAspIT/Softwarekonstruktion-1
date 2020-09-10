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

namespace Opgave_S2_02__Simple_WPF_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        Random diceRandomThrow = new Random();

        private void buttonThrowDice_Click(object sender, RoutedEventArgs e) {

            /*  
            if (inputHowManyDice.SelectedItem != null) {
                // int userHowManyDice = int.Parse(inputHowManyDice.SelectedItem.ToString());

                if (inputHowManyDice1.IsSelected) {
                    MessageBox.Show("You selected 1 die.");
                }
                else {
                    MessageBox.Show("You selected between 2-10 dies.");
                }
            }
            else {
                MessageBox.Show("Please select the amount of dice you wish to throw.");
            }
            */

            for (int i = 0; i < 10; i++) {

            }


        }
    }
}
