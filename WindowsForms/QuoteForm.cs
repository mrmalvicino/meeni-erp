﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class QuoteForm : Form
    {
        public QuoteForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}