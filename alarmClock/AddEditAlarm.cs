﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace alarmClock
{
    public partial class AddEditAlarm : Form
    {
        public AddEditAlarm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {

        }
    }
}
