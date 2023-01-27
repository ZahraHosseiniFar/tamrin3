using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Circle
    {
        public double  _radius;
       
        public double Masahat()
        {
            return _radius * _radius * 3.14;
        }
        public double Mohit()
        {
            return (2* _radius * 3.14);
        }

    }
}
