﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class ttt_bg : Form
    {
        String XandOBox = "X";
        public ttt_bg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transparent_bg.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (top_right.Text == "")
            {
                top_right.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (top_right.Text == top_left.Text)
                {
                    if (top_left.Text == top_middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + top_right.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }
                }
                if (top_right.Text == middle_right.Text)
                {
                    if (middle_right.Text == bottom_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + top_right.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }
                }
                if (top_right.Text == middle.Text)
                {
                    if (middle.Text == bottom_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (top_left.Text == "")
            {
                top_left.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {   
                    XandOBox = "X";
                }
                if (top_left.Text == top_middle.Text)
                {
                    if (top_middle.Text == top_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + top_left.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (top_left.Text == middle_left.Text)
                {
                    if (middle_left.Text == bottom_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + top_left.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (top_left.Text == middle.Text)
                {
                    if (middle.Text == bottom_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (top_middle.Text == "")
            {
                top_middle.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (top_middle.Text == top_right.Text)
                {
                    if (top_right.Text == top_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + top_middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (top_middle.Text == bottom_middle.Text)
                {
                    if (bottom_middle.Text == middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
            }


        }

        private void buttonl_left_Click(object sender, EventArgs e)
        {
            if (bottom_left.Text == "")
            {
                bottom_left.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (bottom_left.Text == middle_left.Text)
                {
                    if (middle_left.Text == top_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + bottom_left.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (bottom_left.Text == bottom_right.Text)
                {
                    if (bottom_right.Text == bottom_middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + bottom_left.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (bottom_left.Text == middle.Text)
                {
                    if (middle.Text == top_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
            }


        }
        private void bottom_right_Click(object sender, EventArgs e)
        {
            if (bottom_right.Text == "")
            {
                bottom_right.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (bottom_right.Text == bottom_left.Text)
                {
                    if (bottom_left.Text == bottom_middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + bottom_right.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (bottom_right.Text == middle_right.Text)
                {
                    if (middle_right.Text == top_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + bottom_right.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (bottom_right.Text == middle.Text)
                {
                    if (middle.Text == top_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }

            }
        }

        private void bottom_middle_Click(object sender, EventArgs e)
        {
            if (bottom_middle.Text == "")
            {
                bottom_middle.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (bottom_middle.Text == bottom_right.Text)
                {
                    if (bottom_right.Text == bottom_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + bottom_middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (bottom_middle.Text == top_middle.Text)
                {
                    if (top_middle.Text == middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
            }
        }

        private void middle_Click(object sender, EventArgs e)
        {
            if (middle.Text == "")
            {
                middle.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {   
                    XandOBox = "X";
                }
                if (middle.Text == top_middle.Text)
                {
                    if (top_middle.Text == bottom_middle.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (middle.Text == middle_right.Text)
                {
                    if (middle_right.Text == middle_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (middle.Text == top_left.Text)
                {
                    if (top_left.Text == bottom_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (middle.Text == top_right.Text)
                {
                    if (top_right.Text == bottom_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }

            }
        }

        private void transparent_bg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void middle_left_Click(object sender, EventArgs e)
        {
            if (middle_left.Text == "")
            {
                middle_left.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (middle_left.Text == bottom_left.Text)
                {
                    if (bottom_left.Text == top_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle_left.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (middle_left.Text == middle.Text)
                {
                    if (middle.Text == middle_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
            }
        }

        private void middle_right_Click(object sender, EventArgs e)
        {
            if (middle_right.Text == "")
            {
                middle_right.Text = XandOBox;
                if (XandOBox == "X")
                {
                    XandOBox = "O";
                }
                else
                {
                    XandOBox = "X";
                }
                if (middle_right.Text == top_right.Text)
                {
                    if (top_right.Text == bottom_right.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle_right.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }
                if (middle_right.Text == middle.Text)
                {
                    if (middle.Text == middle_left.Text)
                    {
                        MessageBox.Show("Wow, amazing " + middle.Text + "! " + "You win!");
                        top_left.Text = "";
                        top_middle.Text = "";
                        top_right.Text = "";
                        middle_left.Text = "";
                        middle.Text = "";
                        middle_right.Text = "";
                        bottom_left.Text = "";
                        bottom_middle.Text = "";
                        bottom_right.Text = "";
                    }

                }

            }
        }
    }
}
