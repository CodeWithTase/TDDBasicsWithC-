using System;
using System.Text;

namespace FizzBuzz.Library
{
    public class FizzBuzzy
    {
        public static string GetValue(int input)
        {
            var result = new StringBuilder();

            if (input % 3 == 0)
                result.Append("Fizz");
            if (input % 5 == 0)
                result.Append("Buzz");
            if (result.Length == 0)
                result.Append(Convert.ToString(input));

            return Convert.ToString(result);
        }
    }
}
