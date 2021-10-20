using System;

namespace Arv
{
    class Person
    {
        private string namn;
        private string telefon;

        public Person(string namn, string telefon)
        {
            this.namn = namn;
            this.telefon = telefon;
        }

        public string GetNamn()
        {
            return namn;
        }
        public string GetTelefon()
        {
            return telefon;
        }
    }
    class Student : Person
    {
        int inskrivningsår;
        bool betaldKåravgift;

        public Student(string n, string t, int år, bool betalat) : base(n, t)
        {
            inskrivningsår = år;
            betaldKåravgift = betalat;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Namn: " + base.GetNamn());
            Console.WriteLine("TelNr: " + base.GetTelefon());
            if (betaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är betald!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
                Student s = new Student("Lisa", "123454", 2005, true);
                string n = s.GetNamn();
                s.PrintInfo();
            
        }
    }
}
