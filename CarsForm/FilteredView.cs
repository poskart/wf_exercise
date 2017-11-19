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
    public partial class FilteredView : Form, UpdateableView
    {
        CarsForm mainFormHandle;

        public FilteredView(CarsForm mainForm)
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
                filteredCarsListView.Items.Add(item);
            }
            else
            {
                foreach (ListViewItem l in filteredCarsListView.Items)
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
                    filteredCarsListView.Items.Remove(item);
                }
            }
            getFilteredResults();
            toolStripStatusLabel2.Text = filteredCarsListView.Items.Count.ToString();
        }

        public void updateView(List<Car> newCarList)
        {
            filteredCarsListView.Items.Clear();
            foreach (Car car in newCarList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = car.GetHashCode();
                filteredCarsListView.Items.Add(item);

                while (item.SubItems.Count < 4)
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = car.Brand;
                item.SubItems[1].Text = car.MaxSpeed.ToString();
                item.SubItems[2].Text = car.ProductionDate.ToShortDateString();
                item.SubItems[3].Text = car.Type;
            }
            toolStripStatusLabel2.Text = filteredCarsListView.Items.Count.ToString();
        }

        private void lessFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            moreFilterCheckBox.Checked = !lessFilterCheckBox.Checked;
            getFilteredResults();
        }

        private void moreFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lessFilterCheckBox.Checked = !moreFilterCheckBox.Checked;
            getFilteredResults();
        }

        public void getFilteredResults()
        {
            int value;
            if(int.TryParse(speedFilterTextBox.Text, out value))
                mainFormHandle.getFilteredResults(this, value, moreFilterCheckBox.Checked);
        }

        private void speedFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            getFilteredResults();
        }
    }
}