using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }

            else
            {
                button7.Text = "O";
                checker = false;
            }
            scores();
            button7.Enabled = true;
        }

        Boolean checker;
        int tex1 = 0;
        int tex2 = 0;
     
        void Enables()
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
            textBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        void scores()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

          //  textBox1.Text = plusone.ToString();
          //  textBox2.Text = plusone.ToString();

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.DarkBlue;
                button2.BackColor = System.Drawing.Color.DarkBlue;
                button3.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              
                Enables();
              
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;

                button4.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button6.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = System.Drawing.Color.DarkBlue;
                button8.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {

                button1.BackColor = System.Drawing.Color.DarkBlue;
                button4.BackColor = System.Drawing.Color.DarkBlue;
                button7.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button8.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
               // plusone = 0;
                Enables();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.DarkBlue;
                button6.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
               // plusone = 0;
                Enables();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button7.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player X is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex1++;
                textBox1.Text = tex1.ToString();
              //  plusone = 0;
                Enables();
            }

            //######################################################################

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.DarkBlue;
                button2.BackColor = System.Drawing.Color.DarkBlue;
                button3.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
             //   plusone = 0;

                Enables();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button6.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = System.Drawing.Color.DarkBlue;
                button8.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
             //   plusone = 0;

                Enables();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.DarkBlue;
                button4.BackColor = System.Drawing.Color.DarkBlue;
                button7.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button8.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.DarkBlue;
                button6.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
             //   plusone = 0;
                Enables();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
              //  plusone = 0;
                Enables();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.DarkBlue;
                button5.BackColor = System.Drawing.Color.DarkBlue;
                button7.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("Player O is the Winner", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tex2++;
                textBox2.Text = tex2.ToString();
             //   plusone = 0;
                Enables();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }

            else
            {
                button1.Text = "O";
                checker = false;
            }
            scores();
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }

            else
            {
                button2.Text = "O";
                checker = false;
            }
            scores();
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }

            else
            {
                button3.Text = "O";
                checker = false;
            }
            scores();
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }

            else
            {
                button4.Text = "O";
                checker = false;
            }
            scores();
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }

            else
            {
                button5.Text = "O";
                checker = false;
            }
            scores();
            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }

            else
            {
                button6.Text = "O";
                checker = false;
            }
            scores();
            button6.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }

            else
            {
                button8.Text = "O";
                checker = false;
            }
            scores();
            button8.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }

            else
            {
                button9.Text = "O";
                checker = false;
            }
            scores();
            button9.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
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


            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button11.Enabled = true;
            button10.Enabled = true;

            button1.BackColor = System.Drawing.Color.Gainsboro;
            button2.BackColor = System.Drawing.Color.Gainsboro;
            button3.BackColor = System.Drawing.Color.Gainsboro;
            button4.BackColor = System.Drawing.Color.Gainsboro;
            button5.BackColor = System.Drawing.Color.Gainsboro;
            button6.BackColor = System.Drawing.Color.Gainsboro;
            button7.BackColor = System.Drawing.Color.Gainsboro;
            button8.BackColor = System.Drawing.Color.Gainsboro;
            button9.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            tex2 = 0;
            tex1 = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button11.Enabled = true;
            button10.Enabled = true;

            button1.BackColor = System.Drawing.Color.Gainsboro;
            button2.BackColor = System.Drawing.Color.Gainsboro;
            button3.BackColor = System.Drawing.Color.Gainsboro;
            button4.BackColor = System.Drawing.Color.Gainsboro;
            button5.BackColor = System.Drawing.Color.Gainsboro;
            button6.BackColor = System.Drawing.Color.Gainsboro;
            button7.BackColor = System.Drawing.Color.Gainsboro;
            button8.BackColor = System.Drawing.Color.Gainsboro;
            button9.BackColor = System.Drawing.Color.Gainsboro;
        }
    }
}


