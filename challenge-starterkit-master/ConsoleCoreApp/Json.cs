using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleCoreApp
{
    public static class Json
    {
        public static void GetAnswer(string a)
        {
            a = a.Replace(" ", ",");
            a = a.Replace(":{", " ");
            a = a.Replace(":", ",");
            a = a.Replace("{", String.Empty);
            a = a.Replace("}", String.Empty);
            a = a.Replace("  ", " ");
            var current = new StringBuilder();
            var flag = true;
            int answer = 0;
            Console.WriteLine(a);
            foreach (var i in a)
            {
                if (!flag && i != ',')
                {
                    current.Append(i);
                }
                if (i == ',' && !flag)
                {
                    answer += int.Parse(current.ToString());
                    current = new StringBuilder();
                    flag = true;
                }
                else if (i == ',')
                {
                    flag = false;
                }
            }

            if (!flag)
            {
                answer += int.Parse(current.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
