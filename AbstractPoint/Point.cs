using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    class Point : abstractPoint
    {
        private double R;
        private double A;
        protected override double x { get { return ConvToX(R, A); } }
        protected override double y { get { return ConvToX(R, A); } }
        protected override double r { get { return R; } set { R = value; } }
        protected override double a { get { return A; } set { A = value; } }

        public Point(PointRepresentation rep, double val1, double val2)
        {
            if(rep == PointRepresentation.Rectengular)
            {
                this.R = ConvToR(val1, val2);
                this.A = ConvToA(val1, val2);
            }
            else
            {
                this.R = val1;
                this.A = val2;
            }
        }
    }
}
