using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsForm
{
    public partial class CarTypeEditorTestControl : UserControl
    {
        private string carType;

        [BrowsableAttribute(true)]
        [EditorAttribute(typeof(CarTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string CarType
        {
            get
            { return carType; }
            set
            { carType = value; }
        }

        public CarTypeEditorTestControl()
        {
            carType = "Car";
            this.Size = new Size(150, 150);
            this.BackColor = Color.Blue;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                e.Graphics.DrawString("Use the Properties Window to access", new Font("Arial", 8), new SolidBrush(Color.Black), 3, 2);
                e.Graphics.DrawString("the AngleEditor UITypeEditor by", new Font("Arial", 8), new SolidBrush(Color.Black), 3, 14);
                e.Graphics.DrawString("configuring the \"Angle\" property.", new Font("Arial", 8), new SolidBrush(Color.Black), 3, 26);
            }
            else
                e.Graphics.DrawString("This example requires design mode.", new Font("Arial", 8), new SolidBrush(Color.Black), 3, 2);
        }
    }
}
