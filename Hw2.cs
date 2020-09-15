/// Lab No. 1		Exercise No. 1
/// File Name: Hw2.cs
/// @author: Ricardo Huerta
/// Date:  September 15, 2020
///
/// Problem Statement: Write a program that takes in a first and last name and outputs the pig latin name to screen.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user to first name and last name
/// 2) Using substring convert the name to pig latin
/// 3) Using ToUpper captialize each of the first letters of the name
/// 4) Display final pig latin name to user
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  class Hw2 {
    public static void Main (string[] args) {
      string first,temp,last;

      Console.WriteLine ("What is the first name?");
      first = Console.ReadLine();

      temp = first.Substring(0,1);
      first = first.Substring(1,1).ToUpper() + first.Substring(2)+temp+ "ay";
      
      Console.WriteLine ("What is the last name?");
      last = Console.ReadLine();

      temp = last.Substring(0,1);
      last = last.Substring(1,1).ToUpper() + last.Substring(2)+temp+ "ay";

      Console.WriteLine("\n" + first + " " +last);
      
    }
  }
}