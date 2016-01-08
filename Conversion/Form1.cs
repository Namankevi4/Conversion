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
            Formula path = new Formula("m/s", '*', "s", typeof(Metres));
            Formula time = new Formula("m", '/', "m/s", typeof(Time));
            Dictionary.listForm.Add(path);
            Dictionary.listForm.Add(time);
            Time time1 = new Time(20);
            Time time2 = new Time(30);
            Metres metr = new Metres(1000);
            Speed speed = new Speed(40);
            var time3 = metr/speed;
            MessageBox.Show(time3.val + " " + time3.GetType().Name);
            var metr2 = speed * time3;
            MessageBox.Show(metr2.val + " " + metr2.GetType().Name);
        }
    }
}
