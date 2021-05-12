using System;
using System.Collections.Generic;
using System.Linq;

namespace contactmanagement
{
    class Program
    {
        static List<string> FirstName = new List<string>();
        static List<string> EmailAddress = new List<string>();
        static List<int> PhoneNumber = new List<int>();
        

        static void Main(string[] args)
        {
            string contactchooser = string.Empty;
            string answername = string.Empty;
            string answeremail = string.Empty;
            int answernumber = 0;
            bool loopi = true;

            do
            { 
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\n1 - View contact list");
                Console.WriteLine("2 - Create a new contact");
                Console.WriteLine("3 - Delete an existing contact");
                Console.WriteLine("");
                //PhoneNumber.Add(01745812709);

                switch (Console.ReadLine())
                {
                    case "1":
                        loopyyy();
                        Console.WriteLine("\nWhich contact would you like to choose?");
                        contactchooser = Console.ReadLine();

                        if (FirstName.Contains(contactchooser))
                        {
                            Console.WriteLine(PhoneNumber[0]);
                            Console.WriteLine(EmailAddress[0]);
                        }
                        else
                        {
                            Console.WriteLine("\nThe contact isn't in your list!");
                        }
                        break;
                    case "2":

                        Console.WriteLine("\nWhat's the name of your contact?");
                        answername = Console.ReadLine();
                        FirstName.Add(answername);

                        Console.WriteLine("\nWhat's the phone number?");
                        answernumber = Convert.ToInt32(Console.ReadLine());
                        PhoneNumber.Add(answernumber);

                        Console.WriteLine("\nWhat's the E-Mail address?");
                        answeremail = Console.ReadLine();
                        EmailAddress.Add(answeremail);

                        Console.WriteLine("\nContact has been created");
                        break;
                    /*case "3":
                        break;*/
                }
                Console.WriteLine("\nWould you like to go back to the main menu?");
                string askloop = Console.ReadLine();
                if (askloop == "no")
                {
                    loopi = false;
                }

            } while (loopi);
        }

        private static void loopyyy()
        {
            foreach (var name in FirstName)
            {
                Console.WriteLine(name);
            }
        }
    }
}

