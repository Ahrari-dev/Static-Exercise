using System;
namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(68);
            var fahrenheit = TempConverter.CelciusToFahrenheit(20);

            Console.WriteLine("After conversion.");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
