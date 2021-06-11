using System;

namespace NineStarKi.Models
{
    public class Calculator
    {
        public static char MainPersonality(int year)                 // Returns Nine Star Ki main personality from year
        {
            double sum = 0;

            double Modulus(double a, double n)                      // Mathematical modulus function
            {
                double result = a % n;
                if ((a < 0 && n > 0 || a > 0 && n < 0) & result != 0) {
                    result += n;
                }
                 
                return result;
            }

            int SumOfDigits(double integer)                         // Returns the integeral sum of digits in a two-digit integer
                => (int)(Math.Floor(integer / 10) + Modulus(integer, 10));

            for (int i = 0; i <= 3; i++) {
                sum += Modulus(Math.Floor(Math.Abs(year) / Math.Pow(10, i)), 10);
            }

            int number = SumOfDigits(11 - SumOfDigits(Math.Sign(year) * sum));

            return number.ToString()[0];
        }

        public static string Personality(DateTimeOffset date)             // Returns Nine Star Ki numbers from date
        {
            int year = date.Year,
                month = date.Month,
                day = date.Day;

            if (month == 1 & day >= 1 || month == 2 & day <= 3) {
                year--;
            }

            char key = MainPersonality(year);
            string value = "";

            if (month == 2 & day >= 4 || month == 3 & day <= 5
                || month == 11 & day >= 8 || month == 12 & day <= 7) {
                value = Constants.starMap[key][0];
            }
            else if (month == 3 & day >= 6 || month == 4 & day <= 5
                || month == 12 & day >= 8 || month == 1 & day <= 5) {
                value = Constants.starMap[key][1];
            }
            else if (month == 4 & day >= 6 || month == 5 & day <= 5
                || month == 1 & day >= 6 || month == 2 & day <= 3) {
                value = Constants.starMap[key][2];
            }
            else if (month == 5 & day >= 6 || month == 6 & day <= 5) {
                value = Constants.starMap[key][3];
            }
            else if (month == 6 & day >= 6 || month == 7 & day <= 7) {
                value = Constants.starMap[key][4];
            }
            else if (month == 7 & day >= 8 || month == 8 & day <= 7) {
                value = Constants.starMap[key][5];
            }
            else if (month == 8 & day >= 8 || month == 9 & day <= 7) {
                value = Constants.starMap[key][6];
            }
            else if (month == 9 & day >= 8 || month == 10 & day <= 8) {
                value = Constants.starMap[key][7];
            }
            else if (month == 10 & day >= 9 || month == 11 & day <= 7) {
                value = Constants.starMap[key][8];
            }

            string numbers = value == "" ? $"{key}"
                : $"{key}.{value}";

            return numbers;
        }

        public static char CompareNumbers(char a, char b)
        {
            int q = (int)Constants.starElement[a] - (int)Constants.starElement[b];

            if (a == b)
                return 'I';
            else if (q == 0)
                return 'i';
            else if (q == 1 || q == -4)
                return 's';
            else if (q == -1 || q == 4)
                return 't';
            else if (q == -2 || q == 3)
                return 'd';
            else if (q == 2 || q == -3)
                return 'c';
            else
                return 'n';
        }

        public static int Evaluate(char r1, char r2, char r3)
        {
            int x = 0;

            switch (r1)
            {
                case 's':
                case 't':
                    x += 50;
                    break;
                case 'I':
                case 'i':
                    x += 30;
                    break;
                default:
                    break;
            }

            switch (r2)
            {
                case 's':
                case 't':
                    x += 25;
                    break;
                case 'I':
                case 'i':
                    x += 15;
                    break;
                default:
                    break;
            }

            switch (r3)
            {
                case 's':
                case 't':
                    x += 25;
                    break;
                case 'I':
                case 'i':
                    x += 15;
                    break;
                default:
                    break;
            }

            return x;
        }

        public static int ProcessNumbers(Personality x, Personality y)
        {

            char x1 = x.Key;
            char x2 = x.Value[0];
            char x3 = x.Value[2];

            char y1 = y.Key;
            char y2 = y.Value[0];
            char y3 = y.Value[2];

            char r1 = CompareNumbers(x1, y1);
            char r2 = CompareNumbers(x2, y2);
            char r3 = CompareNumbers(x3, y3);

            return Evaluate(r1, r2, r3);
        }

        public class Relation
        {
            public string number;
            public string percentage;
        };

        public static Relation[,] ProcessNumber(Personality x)
        {

            char x1 = x.Key;
            char x2 = x.Value[0];
            char x3 = x.Value[2];

            var r = new Relation[9, 9];

            for (int i = 0; i < 9; i++)
            {
                char y1 = (i + 1).ToString()[0];
                char r1 = CompareNumbers(x1, y1);

                for (int j = 0; j < 9; j++)
                {
                    string k = Constants.starMap[y1][j];
                    char y2 = k[0];
                    char y3 = k[2];
                    char r2 = CompareNumbers(x2, y2);
                    char r3 = CompareNumbers(x3, y3);

                    r[i, j] = new Relation
                    {
                        number = $"{y1}{y2}{y3}",
                        percentage = $"{ Evaluate(r1, r2, r3)}%"
                    };
                }
            }
            return r;
        }
    }
}
