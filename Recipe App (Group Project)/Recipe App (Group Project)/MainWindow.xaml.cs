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
using System.IO;

namespace Recipe_App__Group_Project_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            using (StreamReader streamReader = new StreamReader(@"Recipes")) {
                
            }

        }





        private void rcpSave_Click(object sender, RoutedEventArgs e) {
            // If the recipe folder doesn't exist, create it
            System.IO.FileInfo file = new System.IO.FileInfo(@"Recipes\");
            file.Directory.Create();

            // Create document with the same name as the recipe
            using (StreamWriter sw = new StreamWriter(@"Recipes\" + rcpName.Text + ".txt")) {



                // Write out the new recipe
                sw.Write(rcpDesc.Text + "~~");
            }


        }
    }
}
