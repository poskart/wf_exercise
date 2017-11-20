using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CarsForm
{
    public partial class CarTypeControl : UserControl
    {
        private string carType;

        private Image carImage;
        private Image truckImage;
        private Image twoWheelsImage;

        public CarTypeControl()
        {
            carType = "Car";
            carImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/Car.bmp");
            truckImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/Truck.bmp");
            twoWheelsImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/TwoWheel.bmp");
        }

        [EditorAttribute(typeof(CarTypeEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Car type control")]
        [BrowsableAttribute(true)]
        public string CarType
        {
            get { return carType; }
            set { carType = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (carType == "Car")
                e.Graphics.DrawImage(carImage, 0, 0);
            else if(carType == "Truck")
                e.Graphics.DrawImage(truckImage, 0, 0);
            else if (carType == "Two-wheel vehicle")
                e.Graphics.DrawImage(twoWheelsImage, 0, 0);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (carType == "Car")
                carType = "Truck";
            else if (carType == "Truck")
                carType = "Two-wheel vehicle";
            else if (carType == "Two-wheel vehicle")
                carType = "Car";
            Invalidate();
        }
    }
}
