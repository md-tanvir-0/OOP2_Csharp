using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Program
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
                Console.WriteLine("Name: " +Name);
                Console.WriteLine("Id  : " + Id);
                Console.WriteLine("Nationality: " + Nationality);
                Console.WriteLine("Religion: " + Religion);
            }









            static void Main(string[] args)
            {
                Human H1 = new Human("Pial", 238594938, "Bangladeshi", "Islam\n");
                Human H2 = new Human("Mehedi", 355667554, "Bangladeshi", "Islam\n");
                Console.WriteLine("1st person:");
                H1.ShowDetails();
                Console.WriteLine("2nd person:");
                H2.ShowDetails();
                Console.ReadKey();
            }
        }
      }
       
    }

