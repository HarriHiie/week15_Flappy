﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_1Tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeTop.Left += pipeSpeed;
            PipeBottom.Left += pipeSpeed;
            if (PipeTop.Left < -60)
            {
                PipeTop.Left = 500;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Bird_Click(object sender, EventArgs e)
        {

        }
    }
}
