using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using task_13.Models;
using task_13.Services.Abstraction;

namespace task_13.Services.Concrets
{
    internal class RestoranService : IRestoranService
    {
       public static Restoran[] Restorans = { };
        public void Create(string name)
        {
            Restoran restoran = new Restoran();
            restoran.Name = name;
            Array.Resize(ref Restorans, Restorans.Length+1);
            Restorans[Restorans.Length - 1] = restoran;
            Restoran.Id++;
        }

        public void GetAll()
        {
            foreach (var restaurant in Restorans)
            {
                Console.WriteLine(restaurant.Name+" ");
            }
        }

        public void GetById(int id)
        {
            for (int i = 0; i < Restorans.Length; i++)
            {
                if (Restorans[i].ID == id)
                {
                    Console.WriteLine(Restorans[i].Name);
                }
            }

        }

        public void Remove(string resName)
        {
            int index = -1;
            for (int i = 0; i < Restorans.Length; i++)
            {
                if (resName == Restorans[i].Name)
                {
                    index = i;
                    break;
                }
            }
            if(index == -1)
                Console.WriteLine("restoran yoxdur");
            else
            {
                var res=Restorans[Restorans.Length-1];
                Restorans[index] = res;
                Array.Resize(ref Restorans, Restorans.Length - 1);
            }
        }

        public void Update(string Name, string newName)
        {
            foreach (var restaurant in Restorans)
            {
                if (restaurant.Name == Name)
                {
                    restaurant.Name = newName;
                }
            }
        }
    }
}
