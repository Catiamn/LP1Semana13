using System;
using System.Collections.Generic;
using System.Net;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<double> list = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            SuperList<double> sprList = new SuperList<double>();
            sprList.AddRange(list);

            //v1 com uso de out
            double min = default;
            double max = default;

            sprList.GetMinMax1(out min, out max);
            System.Console.WriteLine($"Min: {min}, Max: {max}");

            //v2 com uso de struct
            MinMaxStruct minMax = sprList.GetMinMax2();
            Console.WriteLine($"Versão 2: Min: {minMax.Min} Max: {minMax.Max}");

            //v3 com uso de tuplos de referencia
            Tuple<double, double> tupleMinMax = sprList.GetMinMax3();

            Console.WriteLine($"Versão 3: Min: {tupleMinMax.Item1} Max: {tupleMinMax.Item2}");

            //v4 com uso de tuplos de valor e nomes definidos por nós
            (double Min, double Max) tupleValueMinMax = sprList.GetMinMax4();

            Console.WriteLine($"Versão 4: Min: {tupleValueMinMax.Min} Max: {tupleValueMinMax.Max}");
        }
    }
}
