/*************************************

FootTwo class

**************************************/

using System;

namespace MyProgram {

  class FootTwo : Foot {

    // Overrides abstract method.
    public override double FeetToMeters(double inFeet) {

      return inFeet * 0.3;

    }

    public void OutputResult(double inFeet) {

      // Method call.
      // Takes one parameter.
      double theM = FeetToMeters(inFeet);

      Console.WriteLine(inFeet + " feet to meters is equivalent to " + theM + "  meters");

    }

  }

}
