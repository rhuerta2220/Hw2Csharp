/// Hw No. 2		Exercise No. 2
/// File Name: Hw2.cs
/// @author: Ricardo Huerta
/// Date:  September 15, 2020
///
/// Problem Statement: Write a program that converts degrees Fahrenheit to Celsius using the following formula.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user to enter a temperature in degrees Fahrenheit
/// 2) Using the formula given to convert from F to C
/// 3) Use math.round to round to the first decimal
/// 4) Display the results to user
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  class Hw2pt2 {
    public static void Main (string[] args) {
      double degreesC;
      double degreesF;

      Console.WriteLine("Enter a temperature in degrees Fahrenheit:");

      degreesF =  Convert.ToDouble(Console.ReadLine());

      degreesC = 5* (degreesF - 32)/9;
      Console.WriteLine(degreesF + " degrees Fahrenheit = " + degreesC + " degrees Celsius");
    }
  }
}