﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module1BaiSo_TrinhHongNgoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntClickMe_Click_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                MessageBox.Show("chào!");
            }
        }

        private void bntClickMe_Click_MouseClick(object sender, MouseEventArgs e)
        {
            {
                MessageBox.Show("nút đã được bấm.");
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("đã bấm vào form.");
            }
        }
    }
}
