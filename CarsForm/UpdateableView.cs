using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsForm
{
    public interface UpdateableView
    {
        void updateView(Car updatedCar, int oldCarHashCode, CarListOperations operation);

        void updateView(List<Car> newCarlist);
    }
}
