using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }
    }
}