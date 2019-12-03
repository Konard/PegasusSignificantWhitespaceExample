using System;
using Newtonsoft.Json;

namespace PegasusSignificantWhitespaceExample
{
    class Program
    {
        static void Main()
        {
            var source = @"a
a
    b
    q
        z
        f
    b
    q
        c
d";

            try
            {
                var result = new SignificantWhitespaceParser().Parse(source);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
