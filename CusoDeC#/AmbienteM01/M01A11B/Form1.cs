﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_ClickAsync(object sender, EventArgs e)
        {
            lblMsg.Text = "Olá";
            await Task.Delay(1000);
            lblMsg.Text += ", tudo bem?";
        }
    }
}