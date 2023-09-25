using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Please enter wind speed: ");
    double windSpeed =
    Convert.ToDouble(Console.ReadLine());

    if (windSpeed >= 157){
      Console.WriteLine("category Five hurricane");
      }
    else if (windSpeed >= 130){
        Console.WriteLine("category Four hurricane");
      }
    else if (windSpeed >= 111){
        Console.WriteLine("category Three hurricane");
      }
    else if (windSpeed >= 96){
        Console.WriteLine("category Two hurricane");
      }
    else if (windSpeed >= 74){
      Console.WriteLine("category One hurricane");
    }
    else{
      Console.WriteLine("Not a hurricane");
    }
    }
}