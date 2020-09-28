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

namespace Opgave_S2_01_part_11 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        int imgCount = 1;
        private void btnNext_Click(object sender, RoutedEventArgs e) {
            if (imgCount < 3) {
            imgCount++;
            }
            else {
                imgCount = 1;
            }
            test.ImageSource = new BitmapImage(new Uri(@"..\..\images\" + imgCount + ".png", UriKind.Relative));
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e) {
            if (imgCount > 1) {
                imgCount--;
            }
            else {
                imgCount = 3;
            }
            test.ImageSource = new BitmapImage(new Uri(@"..\..\images\" + imgCount + ".png", UriKind.Relative));
        }
    }
}
