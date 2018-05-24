using DTubeRevenueCalculator.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTubeRevenueCalculator.Repository
{
    public class DRepo
    {
        public List<double> Revenues { get; private set; }

        public DRepo()
        {
            this.Revenues = new FileAdapter().Revenues;
        }
        // TODO class implementation, now revenues only

        public double Sum()
        {
            double sum = 0.0;
            foreach (double d in Revenues)
            {
                sum += d;
            }
            return sum;
        }

        public double Average() {
            return Sum() / Revenues.Count;
        }

        public double Max() {
            return Revenues.Max();
        }

    }
}