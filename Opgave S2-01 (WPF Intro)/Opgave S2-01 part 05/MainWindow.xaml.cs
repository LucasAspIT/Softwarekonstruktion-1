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

namespace Opgave_S2_01_part_05 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        Random random = new Random();
        int score = 0;

        private void btnCatch_Click(object sender, RoutedEventArgs e) {
            int rndLeft = random.Next(0, 801);
            int rndTop = random.Next(0, 451);
            int rndRight = random.Next(0, 801);
            int rndBottom = random.Next(0, 451);

            btnCatch.Margin = new Thickness(rndLeft, rndTop, rndRight, rndBottom);

            score++;
            txtScore.Text = score.ToString();
        }
    }
}
