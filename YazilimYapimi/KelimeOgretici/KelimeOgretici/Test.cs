﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgretici
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Btn_WordTest_Click(object sender, EventArgs e)
        {
            WordTest testForm = new WordTest();
            testForm.Show();
            this.Hide();
        }
    }
}
