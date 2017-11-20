using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace CarsForm
{
    class CarTypeEditor : System.Drawing.Design.UITypeEditor
    {
        Image carImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/Car.bmp");
        Image truckImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/Truck.bmp");
        Image twoWheelImage = Image.FromFile("C:/Users/Piotr/Documents/Visual Studio 2017/Projects/WindowsFroms/CarsForm/CarsForm/Images/TwoWheel.bmp");

        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            if ((string)e.Value == "Car")
                e.Graphics.DrawImage(carImage, 0, 0);
            else if ((string)e.Value == "Truck")
                e.Graphics.DrawImage(truckImage, 0, 0);
            else if ((string)e.Value == "Two-wheel vehicle")
                e.Graphics.DrawImage(twoWheelImage, 0, 0);
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return System.Drawing.Design.UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if(edSvc != null)
            {
                CarTypeControl carTypeControl = new CarTypeControl();
                edSvc.DropDownControl(carTypeControl);
                return carTypeControl.CarType;
            }
            return value;
        }
    }
}
