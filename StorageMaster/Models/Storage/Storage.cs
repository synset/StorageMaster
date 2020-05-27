using StorageMaster.Models.Products;
using StorageMaster.Models.Vehicles;
using System.Collections.Generic;

namespace StorageMaster.Models.Storage
{
    public abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private List<Product> products;
        private List<Vehicle> garage;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
        }

        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int GarageSlots { get => garageSlots; set => garageSlots = value; }
        public bool IsFull
        {
            get => isFull;
            set
            {
                double sumWeight = 0;
                foreach (Product product in Products)
                {
                    sumWeight += product.Weight;
                }
                if (sumWeight >= capacity)
                    this.isFull = true;
            }
        }
        public List<Product> Products { get => products; private set => products = value; }
        public List<Vehicle> Garage { get => garage; private set => garage = value; }
    }
}
