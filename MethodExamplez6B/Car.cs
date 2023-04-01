using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodExamplez6B
{
    internal class Car
    {

        // constructor of class Car
        public Car(string carname)
        {
            string carName= carname;
            MessageBox.Show("object of this class has been created with " + carName + " Name" );
        }

        // class body

        // code the is inside the class is called class member.
        // the members of class can be varieble or constant and method or function

        // access_specifier datatype variebla_name;

        public string carName;
        public string color;
        public int size;
        public string model;
        public int engin_number;

        // access_specifier return_type method_name(parameter list)

        public void showCarInfo()
        {
            MessageBox.Show("The Car Name is " + carName);
            MessageBox.Show("The Car Color is " + color);
            MessageBox.Show("The Car Size is " + size);
            MessageBox.Show("The Car Model is " + model);
            MessageBox.Show("The Car Engin Number is " + engin_number);

        }

    }
}
