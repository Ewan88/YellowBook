using System;

class UsefulMethod {

  static double readValue(double low, double high, string prompt = "Enter a value", string error = "Out of range"){
    double result = 0;
    do {
      Console.WriteLine(prompt + " between " + low + " and " + high + ":");
      string resultString = Console.ReadLine();
      result = double.Parse(resultString);
    } while ((result < low) || (result > high));
    return result;
  }

  const double MAX_WIDTH = 5.0;
  const double MIN_WIDTH = 0.5;

  public static void Main(){
    double windowWidth = readValue(MIN_WIDTH, MAX_WIDTH, "Enter width of window");
    Console.WriteLine("Width: " + windowWidth);
    double age = readValue(0, 70, "Enter your age");
    Console.WriteLine("Age: " + age);

  }


}
