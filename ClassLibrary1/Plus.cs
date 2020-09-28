using System;

namespace ClassLibrary1
{
    public class Plus
    {
        private string a;
        private string b;

        public Plus(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

       

        public string GetSum(string a, string b)
        {
            return "" + (double.Parse(a) + double.Parse(b));
        }

    }
}