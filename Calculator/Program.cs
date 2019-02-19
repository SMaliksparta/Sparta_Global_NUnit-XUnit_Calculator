using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplications
{
    public class Calculator
    {
        public static void Main(string[] a)
        {

        }
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;

        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;

        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;

        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;

        }
        public double Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            return result;

        }
        public double Circle( double num1)
        {
            
            double result = Math.PI * num1;
            return result; 
            

        }
        public double Square(double num1, double num2)
        {
            double result = num1 * num2;
            return result;

        }
        public double Rectangle(double num1, double num2)
        {
            double result = num1 * num2;
            return result;

        }
    }
}


