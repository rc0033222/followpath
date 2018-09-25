﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace followpath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y +1);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
                await Task.Delay(1);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y + 1);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                await Task.Delay(1);
            }
            for (int i = 0; i < 100; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y - 1);
                await Task.Delay(1);

            }
        }

        
        private async void button3_Click(object sender, EventArgs e)
        {
            int d;

            try
            {
                d = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number");
                d = 10;
            }

            for (int i = 0; i < 10; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(d);
            }
            
        }

        public partial class Form1 : Form
        {
            private Image trump;
            private Image flag;

            public Form1()
            {
                InitializeComponent();
                trump = Properties.Resources.trump;
                flag = Properties.Resources.flag;
            }
            private void pictureBox1_Click(object sender, EventArgs e)
            {
                if (pictureBox1.Image== trump)

            }





        }




    }

}
