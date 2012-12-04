using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment1
{
    class Program
    {
        struct Person
        {
            public string FamilyName;
            public string FirstName;
            public DateTime birthDate;
            public string Gender;

        }
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream(@"M:\test.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);
            string s;
            while ((s = sr1.ReadLine()) != null)
            {
                Console.WriteLine("line is : " + s);

            }
            fs1.Close();
        }
    }
}
