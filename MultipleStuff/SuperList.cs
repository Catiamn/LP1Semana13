using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace MultipleStuff
{
    public struct MinMaxStruct
        {
            public double Max { get; }
            public double Min { get; }


            public MinMaxStruct(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }
    public class SuperList<T> : List<double>
    {

        public void GetMinMax1(out double min, out double max)  //v1 com uso de out 
        {
            min = this.Min();
            max = this.Max();
        }
        public MinMaxStruct GetMinMax2() //v2 com uso de struct
        {
            return new MinMaxStruct(this.Min(), this.Max());
        }
        public Tuple<double, double> GetMinMax3() //v3 com uso de tuplos de referencia
        {
            return Tuple.Create(this.Min(), this.Max());
        }

        public (double Min, double Max) GetMinMax4()  //v4 com uso de tuplos de valor e nomes definidos por nós
        {
            return (this.Min(), this.Max());
        }
    }


}