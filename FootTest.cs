/***************************************

FootTest class

***************************************/

using System;

namespace MyProgram {

  class FootTest {

    public static void Main(String[] args) {

      Console.Write("");
      Console.WriteLine("######################## Running Program ####################");
      Console.WriteLine("");

      // Builds object from FootTwo class
      // in order to have access to methods and variables.
      FootTwo fObj = new FootTwo();

      double inFeet;
      int control;

      Console.Write("Enter -1 to quit program: ");
      control = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();

      while(control != -1) {

        Console.Write("Enter distance in feet to convert to meters: ");
        inFeet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        while(inFeet == 0) {

          Console.Write("Please enter an integer greater than 0: ");
          inFeet = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine();

        }

        // Method call
        // using object name.
        // Takes one parameter.
        fObj.OutputResult(inFeet);

        Console.Write("Enter -1 to quit program: ");
        control = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

      }

      Console.Write("");
      Console.WriteLine("######################## Exiting Program ####################");
      Console.Write("");

      Console.ReadKey();

    }

  }

}
