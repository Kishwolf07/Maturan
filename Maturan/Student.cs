﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maturan
{
    public partial class Student : Form
    {
        public Student(string getdata)
        {
            InitializeComponent();
            lbladminuser.Text = getdata;


        }
    }
}
