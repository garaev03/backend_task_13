using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_13.Models;

namespace task_13.Services.Abstraction
{
    internal interface IRestoranService
    {
        public void Create(string name);
        public void Remove(string resName);
        public void Update(string Name, string newName);
        public void GetAll();
        public void GetById(int id);

    }
}
