using System;
using System.Globalization;
using System.Xml.Linq;
using static System.Console;

class Program
{
    class Musa
    {

        public class Society
        {
            public string Name { get; set; }
            public string Contact { get; set; }

            Society() 
            {
                Name = "None";
                Contact = "None";
            }
            Society(string name, string contact)
            {
                Name = name;
                Contact = contact;
            }

            public void display()
            {
                Write("Enter your name: ");
                Name = Convert.ToString(ReadLine());
                WriteLine("Enter your contact number: ");
                Contact = Convert.ToString(ReadLine());
                WriteLine("Whose society you want to join :");
                WriteLine("1. Funded Society");
                WriteLine("2. Non-Funded Society");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                }
            }

            public void addActivity()
            {
                WriteLine("Add activity, you want to perform in this society: ");
                ReadLine();
            }

            public void listEvent()
            {
                WriteLine("1. Character Day");
                WriteLine("2. Hallowen");
                WriteLine("3. Happy Independence Day");
                WriteLine("4. Happy New Year");
            }
        }

        public class FundedSociety : Society
        {
            public double Funding { get; set; }


            FundedSociety()
            {
                Funding = 0.0;
            }
            FundedSociety(double funding)
            {
                Funding = funding;
            }

            public void fund()
            {

                WriteLine("1. Techbit Society");
                WriteLine("2. Literary Society");
                WriteLine("3. Sport Society");

                int optiion = Convert.ToInt32(Console.ReadLine());

                switch (optiion)
                {
                    case 1:
                        {
                            WriteLine("$600 is detected from your account.");
                            break;
                        }
                    case 2:
                        {
                            WriteLine("$500 is detected from your account.");
                            break;
                        }
                    case 3:
                        {
                            WriteLine("$500 is detected from your account.");
                            break;
                        }
                }

            }

            public void fundINFO()
            {

            }
        }

            class NonFundedSociety : Society
            {
                public void display()
                {
                    WriteLine("This is non-Funded Society.");
                }
            }

            class ClubRole
            {
                public string Name { get; set; }
                public string Role { get; set; }
                public string Contact { get; set; }

                // Default Constructor
                ClubRole()
                {
                    Name = "None";
                    Role = "None";
                    Contact = "None";
                }

                // Parametrized Constructor
                ClubRole(string name, string role, string contact)
                {
                    Name = name;
                    Role = role;
                    Contact = contact;
                }
            }

        class StudentClub
        {
            public double Budge { get; set; }

        }
        static void Main(string[] args)
            {
                Society s = new Society();
                FundedSociety f = new FundedSociety();


                WriteLine("1. Register a New Society");
                WriteLine("2. Allocate Funding to Societies");
                WriteLine("3. Register an Event for a Society");
                WriteLine("4. Display Society Funding Information");
                WriteLine("5. Display Events for a Society");
                WriteLine("6. Exit");

                int option = Convert.ToInt32(ReadLine());


                switch (option)
                {
                    case 1:
                        {

                        s.display();
                        break;
                        }
                    case 2:
                        {
                        f.display();
                            break;
                        }
                    case 3:
                        {
                        s.addActivity();
                            break;
                        }
                    case 4:
                        {
                        f.fundINFO();
                            break;
                        }
                    case 5:
                        {
                        s.listEvent();
                            break;
                        }
                    case 6:
                        {
                            WriteLine("Program is going to be EXIT.");
                            break;
                        }
                }
            }
        
    }
}
