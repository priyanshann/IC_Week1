using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;
namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape
    {
        private double radius;

        public void SetRadius(double r)
        {
            radius = r;
        }
        public override int GetArea()
        {
            //throw new NotImplementedException();
            int area;
            double rad = Convert.ToDouble(radius);
            area = Convert.ToInt32(Math.PI * rad * rad);
            return area;
        }

    }

}
