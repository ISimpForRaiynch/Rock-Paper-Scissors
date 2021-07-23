using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rock beats scissors Paper beats rock Scissors beats paper 
            Console.WriteLine("Choose Rock Paper or Scissors (1 for rock 2 for paper or 3 for scissors!");
            int myAns = int.Parse(Console.ReadLine());
            int numbers = 0;
            Random R = new Random();
            numbers = R.Next(1, 3);
            switch (numbers)
            {
                case 1:
                    Console.WriteLine("The Computer says Rock!");
                    if (numbers.Equals(myAns))
                    {
                        Console.WriteLine("Tie!");
                        break;
                    }
                    else if (myAns == 3)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }

                    break;
                
                case 2:
                    Console.WriteLine("The Computer says Paper!");
                    if (numbers.Equals(myAns))
                    {
                        Console.WriteLine("Tie!");
                        break;
                    }
                    else if (myAns == 1)
                    {
                        Console.WriteLine("You Lose!");
                    }
                    else
                    {
                        Console.WriteLine("You Win!");
                    }

                    break;
                case 3:
                    Console.WriteLine("The Computer says Scissors!");
                    if (numbers.Equals(myAns))
                    {
                        Console.WriteLine("Tie!");
                        break;
                    }
                    else if (myAns == 2)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }

                    break;
            }

        }
    }
}