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

namespace Opgave_S2_03_WPF_Gaming_1__Rock_Paper_Scissors_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // If the player selects rock
        private void playerRock_Click(object sender, RoutedEventArgs e) {
            GameReset();

            // Show and save user choice
            playRock.Visibility = Visibility.Visible;
            playerChoice = 1;

            ArchChoice();

            WinnerLoser();
        }

        // If the player selects paper
        private void playerPaper_Click(object sender, RoutedEventArgs e) {
            GameReset();

            // Show and save user choice
            playPaper.Visibility = Visibility.Visible;
            playerChoice = 2;

            ArchChoice();

            WinnerLoser();
        }

        // If the player selects scissors
        private void playerScissors_Click(object sender, RoutedEventArgs e) {
            GameReset();

            // Show and save user choice
            playScissors.Visibility = Visibility.Visible;
            playerChoice = 3;

            ArchChoice();

            WinnerLoser();
        }


        int archChoice;
        /// <summary>
        /// Has the Archnemesis make a random choice between rock, paper and scissors
        /// </summary>
        private void ArchChoice() {
            Random random = new Random();

            int randomArch = random.Next(1, 4);

            switch (randomArch) {
                // Rock
                case 1:
                    archRock.Visibility = Visibility.Visible;
                    archChoice = 1;
                    break;
                // Paper
                case 2:
                    archPaper.Visibility = Visibility.Visible;
                    archChoice = 2;
                    break;
                // Scissors
                case 3:
                    archScissors.Visibility = Visibility.Visible;
                    archChoice = 3;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// Hides all rock, paper and scissor graphics to get ready for the next round
        /// </summary>
        private void GameReset() {
            // Remove startup label
            startup.Visibility = Visibility.Hidden;

            // Hide all player hand graphics
            playRock.Visibility = Visibility.Hidden;
            playPaper.Visibility = Visibility.Hidden;
            playScissors.Visibility = Visibility.Hidden;
            
            // Hide all archnemesis hands graphics
            archRock.Visibility = Visibility.Hidden;
            archPaper.Visibility = Visibility.Hidden;
            archScissors.Visibility = Visibility.Hidden;
        }


        int playerChoice;
        int playerScore = 0;
        int archScore = 0;
        int tieScore = 0;
        /// <summary>
        /// Calculates who the winner is and updates scores
        /// </summary>
        private void WinnerLoser() {
            int gameResult;

            // Calculates who wins
            // Paper vs rock
            if (playerChoice == 2 && archChoice == 1) {
                gameResult = 1;
            }
            // Scissors vs rock
            else if (playerChoice == 3 && archChoice == 1) {
                gameResult = 2;
            }
            // Rock vs paper
            else if (playerChoice == 1 && archChoice == 2) {
                gameResult = 2;
            }
            // Scissors vs paper
            else if (playerChoice == 3 && archChoice == 2) {
                gameResult = 1;
            }
            // Roc vs scissors
            else if (playerChoice == 1 && archChoice == 3) {
                gameResult = 1;
            }
            // Paper vs scissors
            else if (playerChoice == 2 && archChoice == 3) {
                gameResult = 2;
            }
            // It's a tie
            else {
                gameResult = 3;
            }

            switch (gameResult) {
                // Player win
                case 1:
                    winnerAnnounce.Content = "Player wins!";
                    playerScore++;
                    playerScoreDisplay.Content = playerScore.ToString();
                    break;
                // Archenemesis win
                case 2:
                    winnerAnnounce.Content = "Archnemesis wins!";
                    archScore++;
                    archScoreDisplay.Content = archScore.ToString();
                    break;
                // Tie
                case 3:
                    winnerAnnounce.Content = "It's a tie!";
                    tieScore++;
                    tieScoreDisplay.Content = tieScore.ToString();
                    break;
                // Error
                default:
                    winnerAnnounce.Content = "Something went wrong.";
                    break;
            }
        }
    }
}
