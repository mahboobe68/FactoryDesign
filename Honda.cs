using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Honda : ICarSuplier
    {
        public void Start()
        {
            Console.WriteLine("Honda started");
        }
    }
}
