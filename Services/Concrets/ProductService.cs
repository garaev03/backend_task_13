using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_13.Models;
using task_13.Services.Abstraction;

namespace task_13.Services.Concrets
{
    internal class ProductService : Product,IProductService
    {
        

        public void Create( string name, double price, double discountedPrice, string resName)
        {
            Product product = new Product();
            foreach (var restaurant in RestoranService.Restorans)
            {
                if (restaurant.Name == resName)
                {
                    product.DiscountPrice = discountedPrice;
                    product.Price = price;
                    product.Name = name;
                    Id++;
                    Array.Resize(ref restaurant.products, restaurant.products.Length + 1);
                    restaurant.products[restaurant.products.Length-1] = product;
                    return;
                }
            }
            throw new Exception("There is no restaurant");
        }

        public void GetAllinRestaurants(string resName)
        {
            foreach (var restaurant in RestoranService.Restorans)
            {
                if(restaurant.Name == resName)
                {
                    for (int i = 0; i < restaurant.products.Length; i++)
                    {
                        Console.WriteLine(restaurant.products[i].Name+" "+ restaurant.products[i].Price+" "+ restaurant.products[i].DiscountPrice);
                    }
                }
            }
        }

        public void GetByIdinRestaurant()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Update(string resName,string prodName, string newProdName)
        {
            foreach (var restaurant in RestoranService.Restorans)
            {
                if (restaurant.Name == resName)
                {
                    for (int i = 0; i < restaurant.products.Length; i++)
                    {
                        if(restaurant.products[i].Name == prodName)
                        {
                            restaurant.products[i].Name = newProdName;
                        } 
                    }
                }
            }
        }
    }
}
