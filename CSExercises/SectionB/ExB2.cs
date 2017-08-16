﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double number = Convert.ToDouble(Console.ReadLine());
            string rootedNumber = SQRT(number);
            Console.WriteLine(rootedNumber);
            Console.ReadLine();
        }

        public static string SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine

            double root = Math.Sqrt(x);
            string returnValue = string.Format("{0:0.000}",root);
            return returnValue;
        }
    }
}
