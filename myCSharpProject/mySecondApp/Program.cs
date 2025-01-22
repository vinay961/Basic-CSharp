class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Number Guessing Game!");
        System.Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

        // Generate a random number between 1 to 100
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        int attempt = 7;

        while (attempt > 0)
        {
            System.Console.Write("Guess the number: ");
            int input = Convert.ToInt32(System.Console.ReadLine());

            if(input == targetNumber){
                System.Console.WriteLine($"..You \"Win\" in just {8-attempt} attempts..");
                break;
            }    
            else{
                attempt --;
                if(input > targetNumber){
                    System.Console.WriteLine($"Gussed Number is greater, Only {attempt} attempts left!");
                    continue;
                }
                else{
                    System.Console.WriteLine($"Gussed Number is smaller, Only {attempt} attempts left!");
                    continue;
                }
            }
        }
    }
}