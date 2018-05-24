using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace DTubeRevenueCalculator.Adapter
{
    public class FileAdapter
    {
        public List<double> Revenues { get; private set; }
        //public List<DateTime> dates { get; private set; }
        public FileAdapter() {
            Revenues = new List<double>();
            using (StreamReader sr = new StreamReader(@"C:\Users\bradib0y\source\repos\DTubeRevenueCalculator\DTubeRevenueCalculator\Data\ASDASD.txt", System.Text.Encoding.UTF8)) {
                System.Text.RegularExpressions.Regex regexPattern = new System.Text.RegularExpressions.Regex("\\$[0-9]([0-9])*\\.[0-9]([0-9])*");
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    if (regexPattern.Match(line).Success)
                        {
                            try
                            {
                            Revenues.Add(Convert.ToDouble(line.Substring(1)));
                            }
                            catch (Exception e)
                            {
                                // TODO logging
                                continue;
                            }
                        }


                }
            }
        }
    }
}