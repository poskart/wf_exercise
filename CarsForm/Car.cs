using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsForm
{
    public class Car
    {
        public string Brand
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public DateTime ProductionDate
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public Car(string brand, int maxSpeed, DateTime date, string type)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionDate = date;
            Type = type;
        }
    }
}
