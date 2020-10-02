using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Opgave_S2_04_WPF_Gaming_2__Catch_falling_stuff_ {
    class Player {

        private void OnButtonKeyDown(object sender, KeyEventArgs e) {
            switch (e.Key) {
                case Key.Right:
                    // if (previousDirection != (int)MovingDirection.Left)
                    direction = (int)MovingDirection.Right;
                    break;
                case Key.Left:
                    // if (previousDirection != (int)MovingDirection.Right)
                    direction = (int)MovingDirection.Left;
                    break;
            }
        }
    }
}
