﻿using StorageMaster.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;
        private bool isFull;
        private bool isEmpty;
        
        protected Vehicle(int capacity)
        {
            Capacity = capacity;
            Trunk = new List<Product>();
        }

        public int Capacity { get => capacity; set => capacity = value; }
        public List<Product> Trunk { get => trunk; private set => trunk = value; }
        public bool IsFull 
        { 
            get => isFull;
            set
            {
                double sumWeight = 0;
                foreach (Product product in Trunk)
                {
                    sumWeight += product.Weight;
                }
                if (sumWeight >= capacity)
                    this.isFull = true;
            }
        }
        public bool IsEmpty
        {
            get => isEmpty;
            set
            {
                if (Trunk.Count == 0)
                    isEmpty = true;
            }
        }

        /// <summary>
        /// if the vehicle is not full, a product is added
        /// </summary>
        /// <param name="product"></param>
        public void LoadProduct(Product product)
        {
            if (isFull)
                throw new InvalidOperationException("Vehicle is full.");
            else
                Trunk.Add(product);
        }
        /// <summary>
        /// if the vehicle is not empty, the last product in the list Trunk is removed
        /// </summary>
        /// <param name="product"></param>
        public void UpLoad(Product product)
        {
            if (isEmpty)
                throw new InvalidOperationException("No products left in vehicle.");
            else
                trunk.RemoveAt(trunk.Count);//maybe bound error, trunk.Count -1
        }
    }
}
