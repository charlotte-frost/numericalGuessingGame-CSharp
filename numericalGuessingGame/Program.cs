using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numericalGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int[] numArray = { 1, 3, 7, 4, 9, 13, 16, 17, 19, 22, 21, 25, 29, 30, 31, 34, 37, 41, 44, 45, 48, 52, 54, 56,60, 66, 67, 68, 70, 72, 74, 77, 79, 84, 86, 88, 89, 90, 93, 95, 100, 211, 983, 237, 434, 659, 913, 516, 117, 219, 322, 421, 525, 629, 630, 731, 834, 937, 141, 244, 345, 448, 552, 654, 756, 760, 866, 967, 168, 270, 372, 474, 477, 579, 684, 686, 788, 889, 990, 193, 295, 1000, 765, 887, 778, 998, 665, 667, 884, 290, 231, 125, 531, 150, 912, 954, 932, 844, 186, 144, 111, 222, 333, 444, 555, 666, 777, 888, 999, 821, 993, 921, 945, 843, 754, 874, 578, 339, 321, 456, 422, 523, 213, 326, 196, 499, 288, 467, 508, 302, 449109, 808, 707, 405 };
            Console.WriteLine("This is a guessing game. You must guess a number between 0 and 1000. If you are correct, you will get a point and a new number will be generted. If you are wrong it will tell you if you need to go higher or lower.");
            Console.ReadLine();
            generateNumber(numArray, score);
        }
        static void generateNumber(int[] numArray, int score)
        {
            Random rand = new Random();
            int generatedPosition = rand.Next(0, numArray.Length);
            int genNumber = numArray[generatedPosition];
            getGuess(numArray, genNumber, score);
        }
        static void getGuess(int[] numArray, int genNumber, int score)
        {
            Console.WriteLine("Enter your guess :");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess>1000||guess<0)
            {
                Console.WriteLine("You have inputted a number out of the range ");
                getGuess(numArray, genNumber, score);
            }
            else
            {
                compareGuess(numArray, genNumber, guess, score);
            }
        }
        static void compareGuess(int[] numArray, int genNumber, int guess, int score)
        {
            if(guess == genNumber)
            {
                Console.WriteLine("Congrats!! You have guessed correctly!!");
                score = score + 1;
                playAgain(numArray, score);
                Console.ReadLine();
            }
            else if(guess>genNumber)
            {
                Console.WriteLine("Your guess is too high...");
                getGuess(numArray, genNumber, score);
            }
            else
            {
                Console.WriteLine("Your guess is too low...");
                getGuess(numArray, genNumber, score);
            }
        }
        static void playAgain(int [] numArray, int score)
        {
            Console.WriteLine("Do you want to end game? (y/n) ");
            string continuePlaying = Console.ReadLine();
            if (continuePlaying=="y"||continuePlaying =="Y")
            {
                Console.WriteLine("You have scored " +score+ ". You want to play again.\nNew game starting...");
                generateNumber(numArray, score);
            }
            else
            {
                Console.WriteLine("You scored " + score + ". You dont want to play again. \nGame ending... ");
                closeApp();
            }
        }
        static void closeApp()
        {

        }

    }
}
