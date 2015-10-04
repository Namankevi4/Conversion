using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time t = new Time();
            t.val = 20;
            t.name = "m";

            Speed s = new Speed();
            s.val = 10;
            s.name = "m/s";
            var m = t * t;
            MessageBox.Show(m.GetType().ToString());
        }

       

    }
}
