using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkDemo.LogicClass
{
    class Calculator
    {

        public double calculateOversea(double weight)
        {
            double fee1 = 1;
            if (weight >= 3 && weight <= 15)
            {
                fee1 = weight * 75;
            }
            else if (weight >= 16 && weight <= 29)
            {
                fee1 = weight * 70;
            }
            else if (weight >= 30 && weight <= 44)
            {
                fee1 = weight * 65;
            }
            else if (weight >= 45 && weight <= 69)
            {
                fee1 = weight * 62;
            }
            else if (weight >= 70 && weight <= 99)
            {
                fee1 = weight * 61;
            }
            else if (weight >= 100 && weight <= 499)
            {
                fee1 = weight * 58;
            }
            else if (weight >= 500 && weight <= 999)
            {
                fee1 = weight * 58;
            }

            return fee1;
        }
        public double calculateMainland(double weight)
        {
            double fee2 = 0 ;
            if (weight >= 3 && weight <= 15)
            {
                fee2 = weight * 45;
            }
            else if (weight >= 16 && weight <= 29)
            {
                fee2 = weight * 40;
            }
            else if (weight >= 30 && weight <= 44)
            {
                fee2 = weight * 37;
            }
            else if (weight >= 45 && weight <= 69)
            {
                fee2 = weight * 35;
            }
            else if (weight >= 70 && weight <= 99)
            {
                fee2 = weight * 33;
            }
            else if (weight >= 100 && weight <= 499)
            {
                fee2 = weight * 32;
            }
            else if (weight >= 500 && weight <= 999)
            {
                fee2 = weight * 32;
            }
            return fee2;
        }

        public double calDocument(double weight)
        {
            double fee3 = 0;
            if (weight < 3) {
                fee3 = weight / 0.5;
                fee3 = fee3 * 150 - 150 + 158;
            }
            return fee3;
        }
    }
}
