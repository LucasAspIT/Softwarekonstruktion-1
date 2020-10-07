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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>

    public partial class UpdatePage : Window {

        FilmContext _db = new FilmContext();
        int Id;

        public UpdatePage(int filmID) {
            InitializeComponent();

            Id = filmID;
        }

        private void btnFilmUpdate_Click(object sender, RoutedEventArgs e) {

            Film updateFilm = (from m in _db.Films
                              where m.ID == Id
                              select m).Single();

            updateFilm.FilmName = boxFilmName.Text;
            updateFilm.Year = int.Parse(boxFilmYear.Text);
            updateFilm.Genre = boxFilmGenre.Text;
            updateFilm.Director = boxFilmDirector.Text;
            updateFilm.Actors = boxFilmActor.Text;
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.Films.ToList();
            this.Hide();
        }
    }
}
