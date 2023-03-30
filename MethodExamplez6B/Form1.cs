using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodExamplez6B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // access_specifier return_type method_name ( parameter_list)
        //{
        // method body
        //}

        // type1 without parameter without return type
        public void simplemethod()
        {
            MessageBox.Show("You have clicked this button");
        }

        // type2 with parameter no return type

        public void sum(int a , int b)
        {
            MessageBox.Show((a+b).ToString());
        }

        // without parameter with return type
        public int subtract()
        {
            int x = 100;
            int y = 50;
            int z = x - y;
            return z;
        }

        // with parameter with return type
        public double multiply(double x , double y , double z)
        {
            double result = x * y * z;
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //simplemethod();
            //sum(900, 400);
            //int result = subtract();
            //MessageBox.Show(result.ToString());

            //double value = multiply(19.9, 20.10, 30.50);
            String value = Math.Pow(2, 32).ToString();
            MessageBox.Show(String.Format("{0:N}", value));
        }
    }
}
