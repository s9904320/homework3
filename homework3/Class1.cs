using System;

namespace homework3
{
    public class Class1
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
                string endLetter = str.Substring(str.Length-1, 1);

                if (firstLetter != endLetter)
                {
                    firstLetter = firstLetter.ToUpper();
                    str = "The " + firstLetter + str.Substring(1);
                }
                else
                {
                    firstLetter = firstLetter.ToUpper();
                    str = firstLetter + str.Substring(1) + str.Substring(1);
                }
            }

            return str;
        }
    }
}
