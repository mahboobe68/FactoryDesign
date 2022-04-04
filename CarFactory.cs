using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
     sealed class CarFactory
    {
        public static  ICarSuplier GetTypeCar(string type)
        {
            ICarSuplier car =null;

            if (type == "B")
            {
                car = new BWM();

            }
            else if (type == "F")
            {
                car = new Ford();
            }
            else if (type == "H")
            {
                car = new Honda();
            }
            else
            {
                throw new Exception("Not type valid");
            }
            return car; 
        }
    }
}
