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

namespace Opgave_S2_01_part_09_10 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            if (inputUser.Text == "Ole" && inputPass.Password == "Lastbil2006$Rød" ||
                inputUser.Text == "MinHundErSød" && inputPass.Password == "Lastbil2006$Rød" ||
                inputUser.Text == "Brian" && inputPass.Password == "Lastbil2006$Rød" ) {

                inputUser.Text = "Success.";
            }
            else {
                inputUser.Text = "Failure.";
            }
        }
    }
}
