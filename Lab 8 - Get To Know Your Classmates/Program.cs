using System;
using System.Collections;
using System.Linq;


namespace Lab_8___Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable students = new Hashtable()
            {
                {1, "Ramon Guarnes" },
                {2, "Antonio Manzari" },
                {3, "Joshua Carolin" },
                {4, "Nick D'Oria" },
                {5, "Jeremiah Wyeth" },
                {6, "Wendi Magee" },
                {7, "Juliana" },
                {8, "Nathaniel Davis" },
                {9, "Tommy Waalkes" },
                {10, "Grace Seymore" },
                {11, "Jeffrey Wohlfield" },
                {12, "Josh Gallentine" },
                {13, "Stephen Jedlicki" }
            };
            Hashtable hometowns = new Hashtable()
            {
                {1, "Tigard, OR" },
                {2, "Beverly Hills, MI" },
                {3, "Novi, MI" },
                {4, "Canton, MI" },
                {5, "Crystal, MI" },
                {6, "Detroit, MI" },
                {7, "Denver, CO" },
                {8, "Berkley, MI" },
                {9, "Raleigh, NC" },
                {10, "Mesa, AZ" },
                {11, "Detroit, MI" },
                {12, "Baldwin, MI" },
                {13, "The Moon" }
            };
            Hashtable foods = new Hashtable()
            {
                {1, "Burgers" },
                {2, "Focaccia Barese" },
                {3, "Naleśniki" },
                {4, "Tacos" },
                {5, "Burgers" },
                {6, "Salami" },
                {7, "Tacos" },
                {8, "Steak" },
                {9, "Chicken Curry" },
                {10, "Sweet Potato Fries" },
                {11, "Steak" },
                {12, "Falafel" },
                {13, "Mooncakes" }
            };

            string check = "yes";
            string input = "";
            while (check.Equals("yes"))
            {
                try
                {
                    // Ask user to for student number
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-13):");
                    input = Console.ReadLine();
                    // Throw exception if input is empty
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new FormatException();
                    }
                    // Throw exception if input isn't a digit
                    if (!input.All(char.IsDigit))
                    {
                        throw new FormatException();
                    }

                    int studentPick = int.Parse(input);                                 // Student' Number
                    // Throw exception if index isn't accessible / doesn't exist
                    if (studentPick < 1 || studentPick > 13)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    string theStudent = students[studentPick].ToString();               // Student's Name

                    // Ask user hometown or favorite food
                    Console.WriteLine("Student " + studentPick + " is " + theStudent + ". What would you like to know about "
                        + theStudent + "? (enter \"hometown\" or \"favorite food\"):");
                    input = Console.ReadLine();

                    // Hometown information
                    if (input.Equals("hometown"))
                    {
                        Console.WriteLine(theStudent + " is from " + hometowns[studentPick] + ". Would you like to know more?" +
                            "(enter \"yes\" or \"no\"):");
                        // Throw exception if user doesn't input yes or no
                        check = Console.ReadLine();
                        if (string.IsNullOrEmpty(check) || (!check.Equals("yes") && !check.Equals("no")))
                        {
                            check = "yes";
                            throw new FormatException();
                        }
                    }

                    // Favorite food information
                    else if (input.Equals("favorite food"))
                    {
                        Console.WriteLine(theStudent + "'s favorite food is " + foods[studentPick] + ". Would you like to know more?" +
                            "(enter \"yes\" or \"no\"):");
                        check = Console.ReadLine();
                        // Throw exception if user doesn't input yes or no
                        if (string.IsNullOrEmpty(check) || (!check.Equals("yes") && !check.Equals("no")))
                        {
                            check = "yes";
                            throw new FormatException();
                        }
                    }

                    // Throw exception if invalid selection
                    else if (!input.Equals("hometown") || !input.Equals("favorite food"))
                    {
                        throw new Exception();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: FormatException - Incorrect format Case - \"" + input + "\"");
                    Console.WriteLine("Try again...\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("ERROR: IndexOutOfRangeException - Invalid index access - Case - \"" + input + "\"");
                    Console.WriteLine("Try again...\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: - General Exception - Information not available - Case = \"" + input + "\"");
                    Console.WriteLine("Try again...\n");
                }
            }
            Console.WriteLine("Quitting");
            
        }
    }
}
