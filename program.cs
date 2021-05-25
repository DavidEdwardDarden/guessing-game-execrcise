using System;


int secretNum =  new Random().Next(1, 100);
Console.WriteLine("Hint: " + secretNum);



void AskHard()
{
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
      if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (3 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (2 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (1 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

}

void AskMedium()
{
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
      if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (5 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (4 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (3 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (2 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (1 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }
}

void AskEasy()
{
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
      if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (7 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (6 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (5 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (4 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (3 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (2 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }

    if (success == false)
    {
        Console.Write("Your guess > " + "(" + guess + ") " + "Try Again (1 guess left):");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNum)
        {
            Console.WriteLine("SUCCESS!");
            success = true;
        }
        else
        {
            if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }
}

Console.Write("Choose a difficulty level: 1-Easy 2-Medium 3-Hard: ");
int difficulty = int.Parse(Console.ReadLine());

if(difficulty == 1){
  AskEasy();
}

if(difficulty == 2){
  AskMedium();
}

if(difficulty == 3){
  AskHard();
}

if(difficulty == 4){
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
      if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
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
           if(guess > secretNum){
        Console.WriteLine("FAILURE! too high");
      }
      else{
         Console.WriteLine("FAILURE! too low");
      }
        }
    }
}


