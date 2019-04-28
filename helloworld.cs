using System;

public class HelloWorld {

  public static double sayhello(int i){
    i++;
    Console.WriteLine("Hello " + i + "!");
    return i - .50;
  }

  public static void Main(){
    double i;
    i = sayhello(1001);
    i = sayhello(1002);
    Console.WriteLine("i is: {0:#,##0.00}", i);
  }

}
