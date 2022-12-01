using task_13.Services.Abstraction;
using task_13.Services.Concrets;

namespace task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService products = new ProductService();
            IRestoranService restorans = new RestoranService();


            restorans.Create("KFC");
            restorans.Create("Papa");
            restorans.Remove("KFC");
            //restorans.Create("Moda");
            //restorans.GetById(1);
            //restorans.GetById(3);
            //restorans.Update("KFC","MC");
            //restorans.GetAll();

            //products.Create("buggets", 12, 0, "MC");
            //products.GetAllinRestaurants("MC");

            //products.Update("MC", "buggets", "nuggets");
            //products.GetAllinRestaurants("MC");


        }
    }
}