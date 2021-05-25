using System;


int secretNum = new Random().Next(1, 100);
Console.WriteLine("Hint: " + secretNum);



void AskEasy()
{
    Console.WriteLine(" ");
    Console.WriteLine("----EASY DIFFICULTY (8 guesses) ----");
    Console.WriteLine(" ");
    bool success = false;

    Console.Write("Guess the secret number: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNum)
    {
        Console.WriteLine("SUCCESS!");
        success = true;
        return;
    }
    else
    {
        if (guess > secretNum)
        {
            Console.WriteLine("FAILURE! too high");
        }
        else
        {
            Console.WriteLine("FAILURE! too low");
        }
    }

    int guessesLeft = 8;

    if (success == false)
    {

        while (guessesLeft > 1)
        {
            if (success == false)
            {

                guessesLeft = guessesLeft - 1;
                Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (" + (guessesLeft) + " guesses left):");
                guess = int.Parse(Console.ReadLine());

                if (guess == secretNum)
                {
                    Console.WriteLine("SUCCESS!");
                    success = true;
                      return;
                }
                else
                {
                    if (guess > secretNum)
                    {
                        Console.WriteLine("FAILURE! too high");
                    }
                    else
                    {
                        Console.WriteLine("FAILURE! too low");
                    }
                }
            }
        }


    }
}

    void AskMedium()
    {
        Console.WriteLine(" ");
        Console.WriteLine("----MEDIUM DIFFICULTY (6 guesses) ----");
        Console.WriteLine(" ");
        bool success = false;

        Console.Write("Guess the secret number: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
              return;
        }
        else
        {
            if (guess > secretNum)
            {
                Console.WriteLine("FAILURE! too high");
            }
            else
            {
                Console.WriteLine("FAILURE! too low");
            }
        }

        int guessesLeft = 6;

        if (success == false)
        {

            while (guessesLeft > 1)
            {
                if (success == false)
                {
                    guessesLeft = guessesLeft - 1;
                    Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (" + (guessesLeft) + " guesses left):");
                    guess = int.Parse(Console.ReadLine());

                    if (guess == secretNum)
                    {
                        Console.WriteLine("SUCCESS!");
                        success = true;
                          return;
                    }
                    else
                    {
                        if (guess > secretNum)
                        {
                            Console.WriteLine("FAILURE! too high");
                        }
                        else
                        {
                            Console.WriteLine("FAILURE! too low");
                        }
                    }
                }
            }
        }


    }

    void AskHard()
    {
        Console.WriteLine(" ");
        Console.WriteLine("----HARD DIFFICULTY (4 guesses) ----");
        Console.WriteLine(" ");
        bool success = false;

        Console.Write("Guess the secret number: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
              return;
        }
        else
        {
            if (guess > secretNum)
            {
                Console.WriteLine("FAILURE! too high");
            }
            else
            {
                Console.WriteLine("FAILURE! too low");
            }
        }

        int guessesLeft = 4;

        if (success == false)
        {

            while (guessesLeft > 1)
            {
                if (success == false)
                {
                    guessesLeft = guessesLeft - 1;
                    Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (" + (guessesLeft) + " guesses left):");
                    guess = int.Parse(Console.ReadLine());

                    if (guess == secretNum)
                    {
                        Console.WriteLine("SUCCESS!");
                        success = true;
                          return;
                    }
                    else
                    {
                        if (guess > secretNum)
                        {
                            Console.WriteLine("FAILURE! too high");
                        }
                        else
                        {
                            Console.WriteLine("FAILURE! too low");
                        }
                    }
                }

            }
        }


    }


    Console.Write("Choose a difficulty level: 1-Easy 2-Medium 3-Hard: ");
    int difficulty = int.Parse(Console.ReadLine());

    if (difficulty == 1)
    {
        AskEasy();
    }

    if (difficulty == 2)
    {
        AskMedium();
    }

    if (difficulty == 3)
    {
        AskHard();
    }

    if (difficulty == 4)
    {
        Console.WriteLine("{CHEATER MODE ACTIVATED}");
        Console.WriteLine(" ");
        bool success = false;
        Console.Write("Guess the secret number: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if (guess > secretNum)
            {
                Console.WriteLine("FAILURE! too high");
            }
            else
            {
                Console.WriteLine("FAILURE! too low");
            }
        }

        while (success == false)
        {
            Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (∞ guesses left):");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNum)
            {
                Console.WriteLine("SUCCESS!");
                success = true;
            }
            else
            {
                if (guess > secretNum)
                {
                    Console.WriteLine("FAILURE! too high");
                }
                else
                {
                    Console.WriteLine("FAILURE! too low");
                }
            }
        }
    }


