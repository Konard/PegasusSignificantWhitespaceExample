using System;
using Newtonsoft.Json;

namespace PegasusSignificantWhitespaceExample
{
    class Program
    {
        static void Main()
        {
            var source = @"a = b
if a:
    a = b
    if q:
        a = z
        d = f
    b = c
    def q:
        a = c
c = d";

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
