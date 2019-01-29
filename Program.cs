using System;
using System.Collections.Generic;
namespace Lab_11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocome to the Movie List Application!");
            List<Movie> movies = new List<Movie> ();

            movies.Add(new Movie("Star Wars", "scifi",1));
            movies.Add(new Movie("Bird Box", "scifi",1));

            movies.Add(new Movie("Halloween", "horror",2));
            movies.Add(new Movie("Hereditary", "horror",2));


            movies.Add(new Movie("Christopher Robin", "drama",3));
            movies.Add(new Movie("A Star Is Born", "drama",3));

            movies.Add(new Movie("Incredibles 2", "animated",4));
            movies.Add(new Movie("Ralph Breaks the Internet", "animated",4));


            movies.Sort();//sort the arraylist

            Boolean repeat = true;

            while (repeat)
            {
                Console.WriteLine("There are {0} movies in this list.",movies.Count);
                Console.WriteLine("What category are you interested in? (1.scifi,2.horror,3.drama,4.animated)");
                var input = Console.ReadLine();
                int choice;
                if(int.TryParse(input,out choice))
                { 
                              foreach (Movie m in movies)
                                {
                                    if(choice == m.CategoryNum)
                                        Console.WriteLine(m.Title);
                                }

                }
                else if (input == "scifi" || input == "horror" || input == "drama" || input == "animated")
                { 
                    foreach(Movie m in movies)
                    { 
                        if(input == m.Category)
                        {
                            Console.WriteLine(m.Title);
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("you entered unvalid choice please try again!!");

                }
                repeat = Continue();
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Continue? (y/n) : ");
            var input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else 
            {
                Console.WriteLine("You entered unvalid input!!");
                return true;
            }
        }
    }
}
