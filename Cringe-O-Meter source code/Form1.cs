Copyright 2017 Thomas Collins

 This file is part of Cringe-O-Meter.

    Cringe-O-Meter is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Cringe-O-Meter is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Cringe-O-Meter.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void Detect()
        {
            
            richTextBox1.ResetText();
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            string output = String.Format("{0} PERCENT\r\n", randomNumber);
            richTextBox1.AppendText("DETECTED:\r\n");
            richTextBox1.AppendText(output);
            richTextBox1.AppendText("CRINGE");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Detect();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/channel/UCJotHpz53sLx3UxdAvO4Ezw");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
