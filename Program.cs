using System.Text.RegularExpressions;

namespace RegexExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {    //תרגיל 1
             //Console.WriteLine("enter num of phon");
             //string numPhon = Console.ReadLine();
             //bool result = Phon(numPhon);
             //Console.WriteLine("numPhon is match:" + result);

            //תרגיל 2
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str2(s);
            //Console.WriteLine("str is match:" + result);

            //תרגיל 3
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str3(s);
            //Console.WriteLine("str is match:" + result);

            //תרגיל 4
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str4(s);
            //Console.WriteLine("str is match:" + result);

            //תרגיל 5
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str5(s);
            //Console.WriteLine("str is match:" + result);

            ////תרגיל 6
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str6(s);
            //Console.WriteLine("str is match:" + result);

            ////תרגיל 7
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //bool result = str7(s);
            //Console.WriteLine("str is match:" + result);

            ////תרגיל 8
            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //string str1= str8(s);
            //Console.WriteLine("str :" + str1);

            //תרגיל 9
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            string[] str1 = str9(s);
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine( str1[i]);
            }
        }

        //1 תרגיל
        public static bool Phon(string numPhon)
        {
            return Regex.IsMatch(numPhon, @"^05\d{8}$");
        }
        //2 תרגיל
        public static bool str2(string s)
        {
            return Regex.IsMatch(s, @"^abc.*\d$");
        }

        //3 תרגיל
        public static bool str3(string s)
        {
            return Regex.IsMatch(s, @"^calar$|^color$");
        }

        //תרגיל 4
        public static bool str4(string s)
        {
            return Regex.IsMatch(s, @"^[aeiou]*$");
        }

        //תרגיל 5
        public static bool str5(string s)
        {
            return Regex.IsMatch(s, @"^\w{6,10}$");
        }

        //תרגיל 6 
        public static bool str6(string s)
        {
            return Regex.IsMatch(s, @"^dog|^cat$");
        }

        //תרגיל 7 
        public static bool str7(string s) 
        {
            return Regex.IsMatch(s, @"^\w+@gmail\.(co\.il|com)$");
          
        }

        //תרגיל 8 
        public static string str8(string s)
        { 
            return Regex.Replace(s, @"\s+", " ");
        }

        //תרגיל 9 
        public static string[] str9(string s)
        {
            return Regex.Split(s, @"\d+");
        }
       
    }
}
