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
    public partial class EditCarForm : Form, UpdateableView
    {
        private CarsForm mainFormHandle;

        public EditCarForm(CarsForm mainForm)
        {
            mainFormHandle = mainForm;
            this.IsMdiContainer = false;
            InitializeComponent();
        }

        public void updateView(Car updatedCar, int oldCarHashCode, CarListOperations op)
        {
            ListViewItem item = null;

            if (op == CarListOperations.CarAdd)
            {
                item = new ListViewItem();
                carsListView.Items.Add(item);
            }
            else
            {
                foreach(ListViewItem l in carsListView.Items)
                {
                    if ((int)(l.Tag) == oldCarHashCode)
                    {
                        item = l;
                        break;
                    }
                }
            }

            if (item != null)
            {
                if (op != CarListOperations.CarRemove)
                {
                    while (item.SubItems.Count < 4)
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    item.SubItems[0].Text = updatedCar.Brand;
                    item.SubItems[1].Text = updatedCar.MaxSpeed.ToString();
                    item.SubItems[2].Text = updatedCar.ProductionDate.ToShortDateString();
                    item.SubItems[3].Text = updatedCar.Type;
                    item.Tag = updatedCar.GetHashCode();
                }
                else
                {
                    carsListView.Items.Remove(item);
                }
            }
        }

        public void updateView(List<Car> newCarList)
        {
            carsListView.Items.Clear();
            foreach (Car car in newCarList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = car.GetHashCode();
                carsListView.Items.Add(item);

                while (item.SubItems.Count < 4)
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = car.Brand;
                item.SubItems[1].Text = car.MaxSpeed.ToString();
                item.SubItems[2].Text = car.ProductionDate.ToShortDateString();
                item.SubItems[3].Text = car.Type;
            }
            carsListView.Invalidate();
        }

        private void carsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item = e.Item;
            string tc = item.Text;
            textBoxBrand.Text = item.SubItems[0].Text;
            textBoxMaxSpeed.Text = item.SubItems[1].Text;
            dateTimePickerCarProduction.Value = Convert.ToDateTime(item.SubItems[2].Text);
            comboBoxCarType.SelectedIndex = comboBoxCarType.FindString(item.SubItems[3].Text);
        }

        private void carEditFormOKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;

            if(carsListView.SelectedItems.Count > 0)
            {
                int ad = (int)(carsListView.SelectedItems[0].Tag);
                mainFormHandle.editCarParameters((int)(carsListView.SelectedItems[0].Tag),
                    textBoxBrand.Text, Int32.Parse(textBoxMaxSpeed.Text),
                    dateTimePickerCarProduction.Value, comboBoxCarType.Text);
            }
        }

        private void carEditFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCarType_Validating(object sender, CancelEventArgs e)
        {
            if (!comboBoxCarType.Items.Contains(comboBoxCarType.Text))
            {
                e.Cancel = true;
                MessageBox.Show("You must choose type from the car type list!");
            }
        }

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
