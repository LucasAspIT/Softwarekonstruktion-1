using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Opgave_S2_04_WPF_Gaming_2__Catch_falling_stuff_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = MODERATE;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e) {

        }

        private TimeSpan FAST = new TimeSpan(500);
        private TimeSpan MODERATE = new TimeSpan(1000);
        private TimeSpan SLOW = new TimeSpan(1500);
    }
}
