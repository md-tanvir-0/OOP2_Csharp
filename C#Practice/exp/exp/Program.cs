using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp
{
    public class Human
    {
        string Name;
        int Id;
        string Nationality;
        string Religion;



        public Human()
        {
            Console.WriteLine("");
        }



        public Human(string Name)
        {
            this.Name = Name;
            Console.WriteLine("");
        }
        public Human(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
            Console.WriteLine("");
        }
        public Human(string Name, int Id, string Nationality)
        {
            this.Name = Name;
            this.Id = Id;
            this.Nationality = Nationality;
            Console.WriteLine("");
        }
        public Human(string Name, int Id, string Nationality, String Religion)
        {
            this.Name = Name;
            this.Id = Id;
            this.Nationality = Nationality;
            this.Religion = Religion;

        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id  : " + Id);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Religion: " + Religion);
        }









        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Nationality: ");
            string Nationality = Console.ReadLine();

            Console.Write("Enter Religion: ");
            string Religion = Console.ReadLine();

            Human H1 = new Human(Name, Id, Nationality, Religion);
            Console.WriteLine("\n Your Information Is- \n");
            H1.ShowDetails();
            Console.ReadKey();

        }
    }
}