namespace Methods
{
    public class Methods
    {
        //CALLING A METHOD
        //static void Main(string[] args)
        //{
        //CountToTen();
        //}

        //static void CountToTen()
        //{
        //for (int index = 1; index <= 10; index++)
        //Console.WriteLine(index);
        //}

        //SEQUENCIAL CODE EXECUTION
        /*static void Main(string[] args)
        {
            Console.WriteLine("I'm about to go into a method");

            DoSomethingAwesome();

            Console.WriteLine("I'm back from the method");
        }

        static void DoSomethingAwesome()
        {
            Console.WriteLine("I'm iside of a method! Awesome");
        }*/

        //RETURNING STUFF FROM A METHOD
        /*static void Main(string[] args)
        {
            int usersNumber = GetNumberFromUser();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The number that you typed is " +usersNumber);
            Console.ResetColor();
        }

        static int GetNumberFromUser()
        {
            int usersNumber = 0;

            while(usersNumber < 1 || usersNumber > 10)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                string usersResponse = Console.ReadLine();
                usersNumber = Convert.ToInt32(usersResponse);
            }

            return usersNumber;
        }*/

        //RETURNING 'EARLY' I.E NOT NECESSARILY AT THE END OF THE METHOD
        /* static void Main(string[] args)
         {
             Console.WriteLine(CalculatePlayerScore());
         }

         static int CalculatePlayerScore()
         {
             int livesLeft = 3;
             int underlingDesroyed = 17;
             int minionsDestroyed = 4;
             int bossesDestroyed = 1;

             //If the player is out of lives, they lose all of their points
             if(livesLeft == 0)
                 return 0;

             //Otherwise, the player get 10 points per underling destroyed, 100 points per minion, and 1000 points per boss
             return underlingDesroyed*10 + minionsDestroyed*100 + bossesDestroyed*1000;
         }*/

        //Void with return at the middle
        /*static void Main(string[] args)
        {
            DoSomething();
        }

        static void DoSomething()
        {
            int aNumber = 1;

            if (aNumber == 2)
                return;
                         
            Console.WriteLine("This only gets printed if the 'return' statement wasn't executed.");
        }*/

        //PASSING STAFF TO A METHOD
        /*static void Main(string[] args)
        {
            Count(8);
            Count(10);
        }
        static void Count(int numberToCountTo)
        {
            for (int current = 1; current <= numberToCountTo; current++)
            Console.WriteLine(current);
        }*/

        //PASSING IN MULTIPLE PARAMETERS
        /*static void Main(string[] args)
        {
            int product = Multiply(5, 5);
            Console.WriteLine(product);
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }*/

        //METHOD OVERLOADING
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 5));
            Console.WriteLine(Multiply(5, 5, 2));
            Console.WriteLine(Multiply(2.5, 2.5, 1.5));

        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b;
        }





    }
}