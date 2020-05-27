using StorageMaster.Models.Products;
using System;

namespace StorageMaster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Gpu myGpu = new Gpu(20);
            Console.WriteLine(myGpu.Weight);
            Console.Read();
        }
    }
}
