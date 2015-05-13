using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleOperationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circle aCircle = new Circle();
        private void resultButton_Click(object sender, EventArgs e)
        {
            if (radiusTextBox.Text !="")
            {
                if (Convert.ToDouble(radiusTextBox.Text)>0)
                {
                    aCircle.radius = Convert.ToDouble(radiusTextBox.Text);
                    MessageBox.Show("Area : " + aCircle.GetArea() + "\nDiameter : " + aCircle.GetDiameter() + "\nPerimeter : " + aCircle.GetPerimeter());
                }
                else
                {
                    MessageBox.Show("Circle does not exist any negetive value...!");
                }
            }
            else
            {
                MessageBox.Show("Enter radius..........!");
            }
            radiusTextBox.Clear();
        }
    }
}
