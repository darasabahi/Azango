using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Azango
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int a = SystemInformation.PrimaryMonitorSize.Height;
            int b = SystemInformation.PrimaryMonitorSize.Width;
            this.Location = (new Point(b - 420, a - 268));
        }

      
    }
}
