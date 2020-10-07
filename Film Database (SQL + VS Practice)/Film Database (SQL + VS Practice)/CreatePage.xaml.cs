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
using System.Windows.Shapes;

namespace Film_Database__SQL___VS_Practice_ {
    /// <summary>
    /// Interaction logic for CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Window {

        FilmContext _db = new FilmContext();

        public CreatePage() {
            InitializeComponent();
        }

        private void btnFilmNew_Click(object sender, RoutedEventArgs e) {
            Film newFilm = new Film() {
                FilmName = boxFilmName.Text,
                Year = int.Parse(boxFilmYear.Text),
                Genre = boxFilmGenre.Text,
                Director = boxFilmDirector.Text,
                Actors = boxFilmActor.Text
            };

            _db.Films.Add(newFilm);
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.Films.ToList();
            this.Hide();
        }
    }
}
