namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number control");

            int number = 189;

            if (number > 189)
            {

            }
            else
            {
                Console.WriteLine("Number is bigger");

                //if ja ele neitimine
                if (number > 190 && number < 200)
                {
                    Console.WriteLine("Number is between 190 to 200")
                }
                else
                {
                    Console.WriteLine("Number is bigger than 200");
                }
            }
            else
            {
                Console.WriteLine("Number is smaller");

            }
        }
    }
}

