﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;   
            squares.Text += "Number    Square  \r\n ";
            for(int i=1;i<=10;i++)
            {
                result=i*i;
                squares.Text += i + "                  " + result.ToString()+"\r\n ";
            }
        }
    }
}
