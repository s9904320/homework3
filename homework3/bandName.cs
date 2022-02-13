using System;

namespace bandnamecreater
{
    public class bandName
    {
        public static string bandNameGenerator(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                str = "is null";
            }
            else
            {
                string firstLetter = str.Substring(0, 1);
                string lastLetter = str.Substring(str.Length-1, 1);

                if (firstLetter != lastLetter)
                {
                    str = GetBankNameWithTHE(str, firstLetter);
                }
                else
                {
                    str = GetBankNameWithRepeat(str,firstLetter);
                }
            }

            return str;
        }

        public static string GetBankNameWithTHE(string str,string firstLetter)
        {
            firstLetter = firstLetter.ToUpper();
            str = "The " + firstLetter + str.Substring(1);
            return str;
        }

        public static string GetBankNameWithRepeat(string str, string firstLetter)
        {
            str += str.Substring(1);
            firstLetter = firstLetter.ToUpper();
            str = firstLetter + str.Substring(1);
            return str;
        }
    }
}
