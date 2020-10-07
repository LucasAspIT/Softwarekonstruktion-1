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

namespace Film_Database__SQL___VS_Practice_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window {

        FilmContext _db = new FilmContext();
        public static DataGrid dataGrid;

        public MainWindow() {
            InitializeComponent();
            Load();
        }

        private void Load() {
            filmDataGrid.ItemsSource = _db.Films.ToList();
            dataGrid = filmDataGrid;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e) {
            CreatePage cPage = new CreatePage();
            cPage.ShowDialog();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e) {
            int Id = (filmDataGrid.SelectedItem as Film).ID;
            UpdatePage uPage = new UpdatePage(Id);
            uPage.ShowDialog();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) {
            int Id = (filmDataGrid.SelectedItem as Film).ID;
            var deleteFilm = _db.Films.Where(m => m.ID == Id).Single();
            _db.Films.Remove(deleteFilm);
            _db.SaveChanges();
            filmDataGrid.ItemsSource = _db.Films.ToList();
        }
    }
}
