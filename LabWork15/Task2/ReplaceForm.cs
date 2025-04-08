﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class ReplaceForm : Form
    {
        public delegate void ReplaceTextHandler(string searchText, string replaceText);
        public event ReplaceTextHandler ReplaceText;

        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            string replaceText = replaceTextBox.Text;

            ReplaceText?.Invoke(searchText, replaceText);
            this.Close();
        }
    }
}
