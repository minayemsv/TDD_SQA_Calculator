using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SQA
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public int Add_Integer(int integer1, int integer2)
        {
            int sum = integer1 + integer2;
            return sum;
        }
        public float Add_Float(float float1, float float2)
        {
            float sum = float1 + float2;
            return sum;
        }
        public double Add_Double(double double1, double double2)
        {
            double sum = double1 + double2;
            return sum;
        }


        public int Subtract_Integer(int integer1, int integer2)
        {
            int result = integer1 - integer2;
            return result;
        }
        public float Subtract_Float(float float1, float float2)
        {
            float result = float1 - float2;
            return result;
        }
        public double Subtract_Double(double double1, double double2)
        {
            double result = double1 - double2;
            return result;
        }



        public int Multiply_Integer(int integer1, int integer2)
        {
            int result = integer1 * integer2;
            return result;
        }
        public float Multiply_Float(float float1, float float2)
        {
            float result = float1 * float2;
            return result;
        }
        public double Multiply_Double(double double1, double double2)
        {
            double result = double1 * double2;
            return result;
        }



        public int Division_Integer(int integer1, int integer2)
        {
            int result = integer1 / integer2;
            return result;
        }
        public float Division_Float(float float1, float float2)
        {
            float result = float1 / float2;
            return result;
        }
        public double Division_Double(double double1, double double2)
        {
            double result = double1 / double2;
            return result;
        }
    }
}
