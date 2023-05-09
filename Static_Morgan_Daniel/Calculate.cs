using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Morgan_Daniel
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate() //Static class named Calculate
        {
            result = 0.0f;
        }

        // INTEGERS

        public static int Add(int x, int y) //Adds two ints together
        {
            return x + y; //Returns the value
        }

        public static int Sub(int x, int y) //Subtracts two ints together
        {
            return x - y; //Returns the value
        }

        public static int Mult(int x, int y) //Multiplies two ints together
        {
            return x * y; //Returns the value
        }

        public static int Div(int x, int y) //Divides two integers together
        {
            return x / y; //Returns value
        }

        // FLOATERS

        public static float Add(float x, float y) //Adds two FLoats together
        {
            return x = y; //Returns Value
        }

        public static float Sub(float x, float y) //Subtracts two floats together
        {
            return x - y; //Returns Value
        }

        public static float Mult(float x, float y) //Multiplies two floats together
        {
            return x * y; //Returns Value
        }

        public static float Div(float x, float y) //Divides two floats together
        {
            return x / y; //Returns the Value
        }

    }
}
