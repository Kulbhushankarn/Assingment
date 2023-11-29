using System;
using System.Text;

namespace practice
{
    internal class Intern
    {
        public static void Main()
        {
            string s1 = "one";
            string s2 = new StringBuilder().Append("on").Append("e").ToString();
            string s3 = String.Intern(s2);
            Console.WriteLine($"s1 == {s1}");
            Console.WriteLine($"s2 == {s2}");
            Console.WriteLine($"s3 == {s3}");
            Console.WriteLine($"Is s2 the same reference as s1?: {(Object)s2 == (Object)s1}");
            Console.WriteLine($"Is s3 the same reference as s1?: {(Object)s3 == (Object)s1}");

            string s4 = "two";
            string s5 = new StringBuilder().Append("two").ToString();
            string s6 = String.Intern(s5);
            Console.WriteLine($"s4 == {s4}");
            Console.WriteLine($"s5 == {s5}");
            Console.WriteLine($"s6 == {s6}");
            Console.WriteLine($"Is s5 the same reference as s4?: {(Object)s5 == (Object)s4}");
            Console.WriteLine($"Is s6 the same reference as s4?: {(Object)s6 == (Object)s4}");

            string s7 = "three";
            string s8 = new StringBuilder().Append("three").ToString(); // Modified to match s7
            string s9 = String.Intern(s8);
            Console.WriteLine($"s7 == {s7}");
            Console.WriteLine($"s8 == {s8}");
            Console.WriteLine($"s9 == {s9}");
            Console.WriteLine($"Is s8 the same reference as s7?: {(Object)s8 == (Object)s7}"); // Corrected comparison
            Console.WriteLine($"Is s9 the same reference as s7?: {(Object)s9 == (Object)s7}");

            string s10 = "four";
            string s11 = new StringBuilder().Append("four").ToString();
            string s12 = String.Intern(s11);
            Console.WriteLine($"s10 == {s10}");
            Console.WriteLine($"s11 == {s11}");
            Console.WriteLine($"s12 == {s12}");
            Console.WriteLine($"Is s11 the same reference as s10?: {(Object)s11 == (Object)s10}");
            Console.WriteLine($"Is s12 the same reference as s10?: {(Object)s12 == (Object)s10}");
        }
    }
}
