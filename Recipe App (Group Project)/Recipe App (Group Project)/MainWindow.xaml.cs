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
using System.ComponentModel;

namespace Recipe_App__Group_Project_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        // List of all recipe names
        public static List<string> recipeList = new List<string>();

        public MainWindow() {
            InitializeComponent();


            // recipeList.Add("Test123");

            // WriteToText(recipeList);

            ReadFromText();

            //foreach (string s in recipeList) {
                rcpIngr.Text = recipeList.ElementAt(0);
                rcpIngr.Text = recipeList.ElementAt(1);


            //}
        }

        /// <summary>
        /// Accepts a list parameter and prints it to the RecipeList.txt file
        /// </summary>
        // Reads the list in the parameter and adds all the strings to the RecipeList text file
        public static void WriteToText(List<string> recipes) {

            using (StreamWriter sw = new StreamWriter(@"RecipeList.txt")) {

                foreach (string s in recipes) {
                    sw.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// Reads the RecipeList.txt file and adds them to the recipeList list
        /// </summary>
        public static void ReadFromText() {

            using (StreamReader sr = new StreamReader("RecipeList.txt")) {
                    
                while (true) {
                    string line = sr.ReadLine();

                    recipeList.Add(line);

                    if (line == null) {
                        break;
                    }
                }
            }
        }
    
        

            //System.IO.File.WriteAllLines("RecipeList.txt", recipeList);

           // using (StreamReader streamReader = new StreamReader(@"Recipes")) {
            //    
            //}





        private void rcpSave_Click(object sender, RoutedEventArgs e) {
            // If the recipe folder doesn't exist, create it
            System.IO.FileInfo file = new System.IO.FileInfo(@"Recipes\");
            file.Directory.Create();

            // Create document with the same name as the recipe
            using (StreamWriter sw = new StreamWriter(@"Recipes\" + rcpName.Text + ".txt")) {

                // Save the recipe ingredients
                sw.Write(rcpIngr.Text + "$\n");
                // Save the recipe description
                sw.Write(rcpDesc.Text);
                
            }

            

        }

        private void rcpLoad_Click(object sender, RoutedEventArgs e) {

            using (StreamReader sr = new StreamReader(@"Recipes\654.txt")) {

                string i = "";

                while (true) {
                    string line = sr.ReadLine();

                    string[] iArray = line.Split('$');

                    string ingr = iArray[0];
                    //string desc = iArray[1];

                    rcpIngr.Text = ingr;
                    //rcpDesc.Text = desc;

                    // i += line + "\n";

                    // rcpIngr.Text = i;
/*
                    if (line == "$") {
                        rcpDesc.Text = i;
                    }
*/

                    if (line == null) {
                        break;
                    }
                }
            }
        }
    }
}
