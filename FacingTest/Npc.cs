using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FacingTest
{
    public class Npc
    {
        private Navigation.Location _loc;
        private Navigation.Facing _facing;
        private Button _myButton;

        public Npc(Navigation.Facing facing)
        {
            this._facing = facing;
        }

        public Navigation.Facing Facing
        {
            get { return _facing; }
            set { _facing = value; }
        }

        public Navigation.Location Location
        {
            get { return _loc; }
            set { _loc = value; }
        }

        public void SetLocation(int x, int y, ref Button button, bool attacker)
        {
            _loc = new Navigation.Location { X = x, Y = y };

            if (_myButton != null)
            {
                _myButton.BackColor = SystemColors.Control;
            }
            
            _myButton = button;

            if (attacker)
            {
                _myButton.BackColor = Color.DarkGreen;
            }
            else
            {
                _myButton.BackColor = Color.DarkRed;
            }
        }

        public override string ToString()
        {
            return string.Format("Facing => {0} [{1}:{2}]", _facing, _loc.X, _loc.Y);
        }
    }
}
