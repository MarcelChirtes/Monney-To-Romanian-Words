using System;

namespace DoubleParse
{
    public static class ToWordsExtension
    {
        public static string NumRomaninanMonneyWords(this double n)
        {
            string words = "";
            double intPart;
            double decPart = 0;
            if (n == 0)
                return "zero lei";
            try
            {
                intPart = Math.Truncate(n);
                decPart = n - intPart;
            }
            catch
            {
                intPart = n;
            }

            words = NumWords(intPart) + " lei";

            if (decPart > 0)
            {
                if (words != "")
                    words += " virgula ";
                int counter = Math.Truncate(decPart * 100).ToString().Length;
                switch (counter)
                {
                    case 0: break;
                    default: words += Math.Truncate(decPart * 100).NumWords() + " bani"; break;
                }
            }
            return words;
        }

        static string NumWords(this double n, bool is19Range = true) //converts double to words
        {
            if (is19Range)
            {
                is19Range = n > 19;
            }
            string[] numbersArrOver19 = { "unu", "doua", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "zece", "unsprezece", "doisprezece", "treisprezece", "paipsrezete", "cinsprezece", "saisprezece", "saptesprezece", "optasprezece", "nouasprezece" }; // over 20 version
            string[] numbersArrUnder20 = { "unu", "doi", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "zece", "unsprezece", "doisprezece", "treisprezece", "paipsrezete", "cinsprezece", "saisprezece", "saptesprezece", "optasprezece", "nouasprezece" };
            string[] tensArr = { "douazeci", "treizeci", "patruzeci", "cinzeci", "saizeci", "saptezeci", "optzeci", "nouazeci" };
            string[] suffixesArr = { "mie", "milion", "bilion", "trilion", "cvadrilion", "quintillion", "sextilion", "septilion", "octilion", "nonillion", "decilion", "undecilion", "duodecilion", "tredecilion", "quatuordecillion", "quindecilion", "Sexdecillion", "septdecillion", "octodecillion", "novemdecillion", "nigintillion" };
            string[] suffixesPluralArr = { "mii", "milioane", "bilioane", "trilioane", "cvadrilioane", "quintillioane", "sextilioane", "septilioane", "octilioane", "nonillioane", "decilioane", "undecilioane", "duodecilion", "tredecilioane", "quatuordecillioane", "quindecilioane", "Sexdecillioane", "septdecillioane", "octodecillioane", "novemdecillioane", "nigintillioane" };
            string words = "";


            bool tens = false;

            if (n < 0)
            {
                words += "minus ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (n >= pow)
                {
                    if (n % pow > 0)
                    {
                        if (Math.Floor(n / pow) == 1)
                        {
                            words += NumWords(Math.Floor(n / pow), false) + " " + suffixesArr[(power / 3) - 1] + ", ";
                        }
                        else
                        {
                            words += NumWords(Math.Floor(n / pow), false) + " " + suffixesPluralArr[(power / 3) - 1] + ", ";
                        }
                    }
                    else if (n % pow == 0)
                    {
                        words += NumWords(Math.Floor(n / pow), false) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }
            if (n >= 1000)
            {
                if (Math.Floor(n / 1000) == 1)
                {
                    words += "o mie ";
                }
                else
                {
                    if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " mii, ";
                    else words += NumWords(Math.Floor(n / 1000)) + " mii";
                }
                n %= 1000;
            }
            if (0 <= n && n <= 999)
            {
                if ((int)n / 100 > 0)
                {
                    if (Math.Floor(n / 100) == 1)
                    {
                        words += "o suta";
                    }
                    else
                    {
                        words += NumWords(Math.Floor(n / 100)) + " sute";
                    }
                    n %= 100;
                }
                if ((int)n / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    if (is19Range)
                    {
                        words += (tens ? " si " + numbersArrUnder20[(int)n - 1] : numbersArrUnder20[(int)n - 1]);
                    }
                    else
                    {
                        words += (tens ? " si " + numbersArrOver19[(int)n - 1] : numbersArrOver19[(int)n - 1]);
                    }
                    n -= Math.Floor(n);
                }
            }
            return words;
        }
    }
}
