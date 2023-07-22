Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Welcome to number guessing game!" + name);
Random random = new ();

int number = random.Next(1,10);
int guess = 0;
int attemps = 0;

// for, foreach, whiile => break bu döngüyü kırıp çıkmanızı sağlar
while (number != guess)
{
    Console.WriteLine("Please guess a number between 1-10");
    string guessNumber = Console.ReadLine();

    if (int.TryParse(guessNumber, out guess) == false) // if (!int.TryParse(guessNumber, out guess) başına ünlem konulunca aynı anlamı veriyor. ! konulmazsa TRUE sayar ya da ilk yaptığım gibi false olması için belirtilmeli.
    {
        Console.WriteLine("Enter only number!");
        continue;
    }

    if (guess > 10)
    {

        Console.WriteLine(" Try again, you can only write a number between 1-10 ");
        continue;
    }

    Console.WriteLine(" Your Guess:" + guessNumber);

    if (number == guess)
    {
        //Console.WriteLine("Congratulations!You guessed the number in " + attemps +" attempts");
        Console.WriteLine($"Congratulations!You guessed the number in {attemps} attempts");
        continue; // break kullanmak yerine guess=number denebilir
    }
        Console.WriteLine("Sorry!You couldn't guessed the number in attempts.");
    attemps++;


}


       