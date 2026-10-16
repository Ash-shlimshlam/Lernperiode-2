using System.ComponentModel.Design;

Random number = new Random();
int die = number.Next(1, 101);
Console.WriteLine("Guess a number from 1 to 100");
int guess;
do
{
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess == die)
     {Console.WriteLine("You Won!"); }
      else
    {
        if (guess < die)
        { Console.WriteLine("answer is higher"); }
        else
        {
            
             Console.WriteLine("answer is lower"); 
           
        }
    }
} while (guess != die);