using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe //only need one file bb~
{
    public partial class Form1 : Form
    {
        string[] states = { " ", "O", "X" }; //States each button can be in
        int button1counter = 0; //this
        int button2counter = 0; //shit
        int button3counter = 0; //sucks
        int button4counter = 0; //what
        int button5counter = 0; //the
        int button6counter = 0; //fuck
        int button7counter = 0; //dude
        int button8counter = 0; //holy
        int button9counter = 0; //shit

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1counter++;
            if (button1counter > 2)
            {
                button1counter = 0;
            }
            button1.Text = states[button1counter];
            if (button1counter == 2)
            {
                button1.ForeColor = Color.Firebrick;
            }
            else
            {
                button1.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2counter++;
            if (button2counter > 2)
            {
                button2counter = 0;
            }
            button2.Text = states[button2counter];
            if (button2counter == 2)
            {
                button2.ForeColor = Color.Firebrick;
            }
            else
            {
                button2.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3counter++;
            if (button3counter > 2)
            {
                button3counter = 0;
            }
            button3.Text = states[button3counter];
            if (button3counter == 2)
            {
                button3.ForeColor = Color.Firebrick;
            }
            else
            {
                button3.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4counter++;
            if (button4counter > 2)
            {
                button4counter = 0;
            }
            button4.Text = states[button4counter];
            if (button4counter == 2)
            {
                button4.ForeColor = Color.Firebrick;
            }
            else
            {
                button4.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5counter++;
            if (button5counter > 2)
            {
                button5counter = 0;
            }
            button5.Text = states[button5counter];
            if (button5counter == 2)
            {
                button5.ForeColor = Color.Firebrick;
            }
            else
            {
                button5.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6counter++;
            if (button6counter > 2)
            {
                button6counter = 0;
            }
            button6.Text = states[button6counter];
            if (button6counter == 2)
            {
                button6.ForeColor = Color.Firebrick;
            }
            else
            {
                button6.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7counter++;
            if (button7counter > 2)
            {
                button7counter = 0;
            }
            button7.Text = states[button7counter];
            if (button7counter == 2)
            {
                button7.ForeColor = Color.Firebrick;
            }
            else
            {
                button7.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8counter++;
            if (button8counter > 2)
            {
                button8counter = 0;
            }
            button8.Text = states[button8counter];
            if (button8counter == 2)
            {
                button8.ForeColor = Color.Firebrick;
            }
            else
            {
                button8.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9counter++;
            if (button9counter > 2)
            {
                button9counter = 0;
            }
            button9.Text = states[button9counter];
            if (button9counter == 2)
            {
                button9.ForeColor = Color.Firebrick;
            }
            else
            {
                button9.ForeColor = Color.CornflowerBlue;
            }
            winner();
        }

        private void button10_Click(object sender, EventArgs e) //Reset button
        {
            button1.Text = states[0];
            button1counter = 0;
            button2.Text = states[0];
            button2counter = 0;
            button3.Text = states[0];
            button3counter = 0;
            button4.Text = states[0];
            button4counter = 0;
            button5.Text = states[0];
            button5counter = 0;
            button6.Text = states[0];
            button6counter = 0;
            button7.Text = states[0];
            button7counter = 0;
            button8.Text = states[0];
            button8counter = 0;
            button9.Text = states[0];
            button9counter = 0;
            label1.Text = " ";
        }
        private void winner() //Checks to see if you won.
        {
            if ((button1counter == 2) && (button2counter == 2) && (button3counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button1counter == 1) && (button2counter == 1) && (button3counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button4counter == 2) && (button5counter == 2) && (button6counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button4counter == 1) && (button5counter == 1) && (button6counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button7counter == 2) && (button8counter == 2) && (button9counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button7counter == 1) && (button8counter == 1) && (button9counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button1counter == 2) && (button4counter == 2) && (button7counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button1counter == 1) && (button4counter == 1) && (button7counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button2counter == 2) && (button5counter == 2) && (button8counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button2counter == 1) && (button5counter == 1) && (button8counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button3counter == 2) && (button6counter == 2) && (button9counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button3counter == 1) && (button6counter == 1) && (button9counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button1counter == 2) && (button5counter == 2) && (button9counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button1counter == 1) && (button5counter == 1) && (button9counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else if ((button7counter == 2) && (button5counter == 2) && (button3counter == 2))
            {
                label1.ForeColor = Color.Firebrick;
                label1.Text = "X Wins!";
            }
            else if ((button7counter == 1) && (button5counter == 1) && (button3counter == 1))
            {
                label1.ForeColor = Color.CornflowerBlue;
                label1.Text = "O Wins!";
            }
            else
            {
                label1.Text = " ";
            }
        }
    }
}
