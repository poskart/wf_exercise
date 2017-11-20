using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsForm
{
    public partial class AddCarForm : Form, UpdateableView
    {
        private CarsForm mainFormHandle;

        public string CarBrand
        {
            get { return textBoxBrand.Text; }
        }

        public int CarMaxSpeed
        {
            get { return Int32.Parse(textBoxMaxSpeed.Text); }
        }

        public DateTime CarProductionDate
        {
            get { return dateTimePickerCarProduction.Value; }
        }

        public string CarType
        {
            get { return carTypeControl1.CarType; }
        }

        public AddCarForm(CarsForm mainForm)
        {
            mainFormHandle = mainForm;
            InitializeComponent();
        }

        private void carEditFormOKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;

            Car newCar = new Car(CarBrand, CarMaxSpeed,
                CarProductionDate, CarType);
            mainFormHandle.addCar(ref newCar);
        }

        private void carEditFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateView(Car updatedCar, int oldCarHashCode, CarListOperations operation) { }

        public void updateView(List<Car> newCarList) { }

        private void textBoxMaxSpeed_Validating(object sender, CancelEventArgs e)
        {
            int value;
            if (!(int.TryParse(textBoxMaxSpeed.Text, out value) && value >= 0))
            {
                e.Cancel = true;
                MessageBox.Show("You must type valid number greater than 0!");
            }
        }
    }
}

