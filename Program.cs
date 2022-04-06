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
        static void Main(string[] args)
        {
            Console.WriteLine("I'm about to go into a method");

            DoSomethingAwesome();

            Console.WriteLine("I'm back from the method");
        }

        static void DoSomethingAwesome()
        {
            Console.WriteLine("I'm iside of a method! Awesome");
        }
    }
}