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
        static void Main(string[] args)
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
        }




    }
}