using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StriceGalo
{
    public partial class Main : Form
    {
        bool turn; // player1 = true, player2 = false
        string ball = "\u25cf";

        public Main()
        {
            InitializeComponent();
            label2.Text = ball;
        }

        void start_game()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Text = "Reiniciar";
            label5.Text = "";
            turn = true;
        }

        void restart_game()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            start_game();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = turn ? "x" : ball;
                turn = !turn;
                verify_win();
            }
        }

        void verify_win()
        {
            if ((button1.Text == "x" && button2.Text == "x" && button3.Text == "x") ||
                (button4.Text == "x" && button5.Text == "x" && button6.Text == "x") ||
                (button7.Text == "x" && button8.Text == "x" && button9.Text == "x") ||
                (button1.Text == "x" && button4.Text == "x" && button7.Text == "x") || 
                (button2.Text == "x" && button5.Text == "x" && button8.Text == "x") ||
                (button3.Text == "x" && button6.Text == "x" && button9.Text == "x") ||
                (button1.Text == "x" && button5.Text == "x" && button9.Text == "x") ||
                (button3.Text == "x" && button5.Text == "x" && button7.Text == "x"))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                label5.Text = "Jogador x ganhou";
                button10.Text = "Reiniciar";
                label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 1);
            }
            
            if ((button1.Text == ball && button2.Text == ball && button3.Text == ball) ||
                (button4.Text == ball && button5.Text == ball && button6.Text == ball) ||
                (button7.Text == ball && button8.Text == ball && button9.Text == ball) ||
                (button1.Text == ball && button4.Text == ball && button7.Text == ball) ||
                (button2.Text == ball && button5.Text == ball && button8.Text == ball) ||
                (button3.Text == ball && button6.Text == ball && button9.Text == ball) ||
                (button1.Text == ball && button5.Text == ball && button9.Text == ball) ||
                (button3.Text == ball && button5.Text == ball && button7.Text == ball))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                label5.Text = "Jogador y ganhou";
                button10.Text = "Reiniciar";
                label4.Text = Convert.ToString(Convert.ToInt32(label4.Text) + 1);
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label5.Text = "Ninguem ganhou";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "Jogar")
                start_game();
            else if (button10.Text == "Reiniciar")
                restart_game();
        }
    }
}
