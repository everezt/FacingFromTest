using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacingTest
{
    public partial class Form1 : Form
    {
        Npc attacker = new Npc(Navigation.Facing.North);
        Npc defender = new Npc(Navigation.Facing.North);
        Npc offSets = new Npc(Navigation.Facing.North);
        Combat combat = new Combat();

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetNames(typeof(Navigation.Facing));
            attacker.SetLocation(3, 4, ref button61, true);
            defender.SetLocation(3, 3, ref button21, false);
            textBox1.Text = string.Format("Attacker is at {0} of Defender({1})", combat.GetDirection(attacker, defender), defender.ToString());
        }

        // 3,3 def, 3,4 att
        
       

        public void SetCoordinates(int x, int y, MouseEventArgs e, ref Button button)
        {
            if(e.Button == MouseButtons.Left)
            {
                // set attacker
                attacker.SetLocation(x, y, ref button, true);
                //textBox2.Text = textBox2.Text + (string.Format("X: {0} Y = {1} |", x - defender.Location.X, y - defender.Location.Y));
            }
            else if (e.Button == MouseButtons.Right)
            {
                // set defender
                //defender.SetLocation(x, y, ref button, false);              
            }




            textBox1.Text = string.Format("Attacker is at {0} of Defender({1})", combat.GetDirection(attacker, defender), defender.ToString());
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // 0,0
            SetCoordinates(0, 0, e, ref button1);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 0, e, ref button2);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 0, e, ref button4);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 0, e, ref button3);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 0, e, ref button8);
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 0, e, ref button7);
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 0, e, ref button6);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 0, e, ref button5);
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 1, e, ref button16);
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 1, e, ref button15);
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 1, e, ref button14);
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 1, e, ref button13);
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 1, e, ref button12);
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 1, e, ref button11);
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 1, e, ref button10);
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 1, e, ref button9);
        }

        private void button32_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 2, e, ref button32);
        }

        private void button31_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 2, e, ref button31);
        }

        private void button30_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 2, e, ref button30);
        }

        private void button29_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 2, e, ref button29);
        }

        private void button28_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 2, e, ref button28);
        }

        private void button27_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 2, e, ref button27);
        }

        private void button26_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 2, e, ref button26);
        }

        private void button25_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 2, e, ref button25);
        }

        private void button24_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 3, e, ref button24);
        }

        private void button23_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 3, e, ref button23);
        }

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 3, e, ref button22);
        }

        private void button21_MouseClick(object sender, MouseEventArgs e)
        {
            //SetCoordinates(3, 3, e, ref button21);
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 3, e, ref button20);
        }

        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 3, e, ref button19);
        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 3, e, ref button18);
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 3, e, ref button17);
        }

        private void button64_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 4, e, ref button64);
        }

        private void button63_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 4, e, ref button63);
        }

        private void button62_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 4, e, ref button62);
        }

        private void button61_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 4, e, ref button61);
        }

        private void button60_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 4, e, ref button60);
        }

        private void button59_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 4, e, ref button59);
        }

        private void button58_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 4, e, ref button58);
        }

        private void button57_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 4, e, ref button57);
        }

        private void button56_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 5, e, ref button56);
        }

        private void button55_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 5, e, ref button55);
        }

        private void button54_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 5, e, ref button54);
        }

        private void button53_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 5, e, ref button53);
        }

        private void button52_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 5, e, ref button52);
        }

        private void button51_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 5, e, ref button51);
        }

        private void button50_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 5, e, ref button50);
        }

        private void button49_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 5, e, ref button49);
        }

        private void button48_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 6, e, ref button48);
        }

        private void button47_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 6, e, ref button47);
        }

        private void button46_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 6, e, ref button46);
        }

        private void button45_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 6, e, ref button45);
        }

        private void button44_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 6, e, ref button44);
        }

        private void button43_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 6, e, ref button43);
        }

        private void button42_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 6, e, ref button42);
        }

        private void button41_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 6, e, ref button41);
        }

        private void button40_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(0, 7, e, ref button40);
        }

        private void button39_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(1, 7, e, ref button39);
        }

        private void button38_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(2, 7, e, ref button38);
        }

        private void button37_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(3, 7, e, ref button37);
        }

        private void button36_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(4, 7, e, ref button36);
        }

        private void button35_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(5, 7, e, ref button35);
        }

        private void button34_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(6, 7, e, ref button34);
        }

        private void button33_MouseClick(object sender, MouseEventArgs e)
        {
            SetCoordinates(7, 7, e, ref button33);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            defender.Facing = (Navigation.Facing)comboBox1.SelectedIndex;
            textBox1.Text = string.Format("Attacker is at {0} of Defender({1})", combat.GetDirection(attacker, defender), defender.ToString());
        }
    }
}
