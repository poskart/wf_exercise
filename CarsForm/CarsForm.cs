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
    public enum CarListOperations { CarRemove = 0, CarAdd = 1, CarEdit = 2 };

    public partial class CarsForm : Form
    {
        List<Car> cars = new List<Car>();

        public bool closing = false;

        public CarsForm()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FilteredView filteredView = new FilteredView(this);
            // Set the Parent Form of the Child window.
            filteredView.MdiParent = this;
            // Display the new form.
            filteredView.Show();
        }

        public void addCar(ref Car car)
        {
            cars.Add(car);
            updateChildren(car, 0, CarListOperations.CarAdd);
        }          

        public void editCarParameters(int carHashCode, string newBrand, 
            int newMaxSped, DateTime newProductionDate, string newType )
        {
            Car c = cars.Find(item => item.GetHashCode() == carHashCode);
            if (c != null)
            {
                c.Brand = newBrand;
                c.MaxSpeed = newMaxSped;
                c.ProductionDate = newProductionDate;
                c.Type = newType;
            }
            updateChildren(c, carHashCode, CarListOperations.CarEdit);
        }

        public void removeCar(int carHashCode)
        {
            Car c = cars.Find(item => item.GetHashCode() == carHashCode);
            if (c != null)
            {
                cars.Remove(c);
            }
            updateChildren(c, carHashCode, CarListOperations.CarRemove);
        }

        public void updateChildren(Car car, int oldCarHashCode, CarListOperations operation)
        {
            foreach (UpdateableView f in MdiChildren)
                f.updateView(car, oldCarHashCode, operation);
            statusStripLabel2.Text = cars.Count().ToString();
        }

        private void newCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm carAddForm = new AddCarForm(this);
            carAddForm.MdiParent = this;
            carAddForm.Show();
        }

        private void modifyCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCarForm carEditForm = new EditCarForm(this);
            // Set the Parent Form of the Child window.
            carEditForm.MdiParent = this;
            // Display the new form.
            carEditForm.Show();

            carEditForm.updateView(cars);
        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCarForm carRemoveForm = new RemoveCarForm(this);
            // Set the Parent Form of the Child window.
            carRemoveForm.MdiParent = this;
            // Display the new form.
            carRemoveForm.Show();

            carRemoveForm.updateView(cars);
        }

        private void filteredViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilteredView filteredView = new FilteredView(this);
            // Set the Parent Form of the Child window.
            filteredView.MdiParent = this;
            // Display the new form.
            filteredView.Show();

            filteredView.updateView(cars);
        }

        public void getFilteredResults(UpdateableView view, int value, bool moreThan, bool lessThan)
        {
            List<Car> filteredCars = new List<Car>();
            foreach (Car c in cars)
            {
                if (moreThan || lessThan)
                {
                    if (moreThan && c.MaxSpeed > value)
                    {
                        filteredCars.Add(c);
                    }
                    else if (!moreThan && c.MaxSpeed < value)
                    {
                        filteredCars.Add(c);
                    }
                }
                else
                    filteredCars.Add(c);
            }
            view.updateView(filteredCars);
        }

        private void CarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }
    }
}
