using System.Collections.Generic;

namespace leetcode
{
    public class InegerToRoman
    {

        private static List<RomanDigit> RomanMap = new List<RomanDigit>{ 
            new RomanDigit{Roman ="M",  Decimal = 1000},
            new RomanDigit{Roman ="CM", Decimal = 900 },
            new RomanDigit{Roman ="D",  Decimal = 500},
            new RomanDigit{Roman ="CD", Decimal = 400},
            new RomanDigit{Roman ="C",  Decimal = 100},
            new RomanDigit{Roman ="XC", Decimal = 90},
            new RomanDigit{Roman ="L",  Decimal = 50},
            new RomanDigit{Roman ="XL", Decimal = 40},
            new RomanDigit{Roman ="X",  Decimal = 10 },
            new RomanDigit{Roman ="IX", Decimal = 9 },
            new RomanDigit{Roman ="V",  Decimal = 5 },
            new RomanDigit{Roman ="IV", Decimal = 4 },
            new RomanDigit{Roman ="I",  Decimal = 1 }
        };


        public static string IntToRoman(int num)
        {
            string roman = "";
            for (var i = 0; i < 13; i++)
            {
                while (num >= RomanMap[i].Decimal)
                {
                    roman += RomanMap[i].Roman;
                    num -= RomanMap[i].Decimal;
                }
            }

            return roman;
        }
    }

    public class RomanDigit
    {
        public string Roman { get; set; }
        public int Decimal { get; set; }
    }
}

