﻿using TPTheatre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPTheatre
{
    public partial class Movie : Form
    {
        private object title;
        private object duration;

        public Movie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Movie movie = (Movie)listBox1.SelectedItem;
                this.comboBox1.SelectedIndex = (int)movie.title;
                this.textBox2.Text = movie.duration.ToString();
            }
        }
    }
}
