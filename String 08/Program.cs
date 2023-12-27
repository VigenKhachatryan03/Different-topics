using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringCօnversation();
            //StringAdding();
            //SplitTxt();
            //StringCompareWithStringBuilder();
            //CompereToStringBuilder();
            //StringGetArray();
            StringManipulation();
        }

        static void StringCօnversation()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string txt = "Hello how are you FBI!";
            string txt2 = "My lesson !";
            Console.WriteLine($"My txt is - {txt}");
            Console.WriteLine("My 1st txt is {0}, and my 2nd txt is {1}", txt, txt2);

            string newResult = textInfo.ToTitleCase(txt);
            Console.WriteLine(newResult);
        }
        static void StringAdding()
        {
            string x = "Hello" + " " + "how" + "are you";
            string y = $"Hello\thow\tare\tyou";
            string z = $"\\'n' pressed";
            string n = $@"\'n' pressed";
            string m = $"\'n' pressed";
            string path = $" \\{m}";
            Console.WriteLine($"{x}\n{y}\n{z}\n{n}\n{m}");
        }
        static void StringGetArray()
        {
            string newTxt = "1,2,3,4,5,7";
            string[] arr = newTxt.Split(',');

            foreach (string str in arr)
            {
                //Console.WriteLine(str);
            }

            string joinedTxt = string.Join(" ", arr);

            var arrChar = newTxt.ToCharArray();
            foreach (var str in arrChar)
            {
                Console.WriteLine(str);

            }

            foreach (var i in joinedTxt)
            { Console.WriteLine(i); }
        }
        static void StringManipulation() 
        {
            string newTxt = "1Hello 2 World 2";
            
            //remove
            string txt1 = newTxt.Remove(0,7);
            Console.WriteLine(txt1);
            string txt2 = newTxt.Substring(0,7);
            Console.WriteLine(txt2);

            //indexes
            
            Console.WriteLine(newTxt.IndexOf('2'));

            // Trim

            string d = "      vb          3 ssd   a             ";
            

            Console.WriteLine(d.Trim()) ;
            Console.WriteLine(d.TrimStart());
            Console.WriteLine(d.TrimEnd());


        }
        static void StringCompareWithStringBuilder()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string txt = "";

            for (int i = 0; i < 100000; i++)
            {
                txt += i.ToString();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        static void CompereToStringBuilder()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            StringBuilder txt = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                txt.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        
        
    }
}
