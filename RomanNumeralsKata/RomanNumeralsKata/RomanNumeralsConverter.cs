using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class NumeralsConverter
    {

        private List<KeyValuePair<int, string>> romans = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, String>(1, "I"),
            new KeyValuePair<int, String>(4, "IV"),
            new KeyValuePair<int, String>(5, "V"),
            new KeyValuePair<int, String>(9, "IX"),
            new KeyValuePair<int, String>(10, "X"),
            new KeyValuePair<int, String>(50, "L"),
            new KeyValuePair<int, String>(100, "C"),
            new KeyValuePair<int, String>(500, "D"),
            new KeyValuePair<int, String>(1000, "M")
        };

        public string ConvertToRoman(int numeral)
        {
            var romanNumeral = string.Empty;

           

            foreach (var roman in romans.OrderByDescending(r => r.Key))
            {
                while (numeral / roman.Key >= 1)
                {
                    numeral = numeral - roman.Key;
                    romanNumeral += roman.Value;
                }   


            }
          
            return romanNumeral;
        }

    }
}
