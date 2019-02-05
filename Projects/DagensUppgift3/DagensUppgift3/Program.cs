using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace DagensUppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            int classic = 0;
            do
            {
                System.Console.WriteLine("Choose assigment from A to F or press Q to quit");
                string assigment = Console.ReadLine();
                string switching = assigment.ToLower();

                switch (switching)
                {
                    case "a":

                        Console.WriteLine("What is your name? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Hey " + name + "!");
                        classic = 1;
                        break;

                    case "b":

                        Console.WriteLine("What is your first name? ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is your last name? ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("YOOOOOOOO " + firstName + " " + lastName + "!");
                        classic = 1;
                        break;

                    case "c":

                        Console.WriteLine("What is your favorite food?");
                        string foodOne = Console.ReadLine();
                        Console.WriteLine("What is your favorite food? (not the same please)");
                        string foodTwo = Console.ReadLine();
                        Console.WriteLine("Brother...Everyone has a third favorite food you feel me? What's yours?");
                        string foodThree = Console.ReadLine();
                        Console.WriteLine("Your favorite foods are " + foodOne + " " + foodTwo + " " + foodThree);
                        int numberOne = foodOne.Length;
                        int numberTwo = foodTwo.Length;
                        int numberThree = foodThree.Length;
                        Console.WriteLine(foodOne + "(" + numberOne + ")" + "\n" + foodTwo + "(" + numberTwo + ")" + "\n" + foodThree + "(" + numberThree + ")");
                        classic = 1;
                        break;
                    case "d":

                        Console.WriteLine("Favorite Quote? ");
                        string quote = Console.ReadLine();
                        string[] words = quote.Split(' ');
                        foreach (string word in words)
                        {
                            Console.WriteLine(word);
                        }
                        classic = 1;
                        break;

                    case "e":
                        Console.WriteLine("Skriv ett palindrom: ");
                        string palindrom = Console.ReadLine();
                        char[] reverse = palindrom.ToCharArray();
                        Array.Reverse(reverse);
                        new string(reverse);
                        Console.WriteLine(reverse);
                        classic = 1;
                        break;

                    case "f":
                        Console.WriteLine("How many numbers do you want (1-10)? ");
                        int ammount = Convert.ToInt32(Console.ReadLine());
                        int i = 0;
                        int[] numbers = new int[ammount];
                        for (i = 0; i < ammount; i++)
                        {
                            int number = i + 1;
                            Console.WriteLine("What's the " + number + "st number?");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int sum = numbers.Sum();
                        int maxValue = numbers.Max();
                        int minValue = numbers.Min();
                        double average = (double)sum / ammount;

                        Console.WriteLine("Your sum is: " + sum + "\n" + "Your maximum and minimum values are: " + maxValue + " and " + minValue + "\n" + "Your average is: " + average);
                        classic = 1;
                        break;

                    case "q":
                        Application.Exit();
                        classic = 0;
                        break;

                    default:
                        Console.WriteLine("All you had to do was follow the damn assigment CJ!");
                        classic = 1;
                        break;


                }
            } while (classic != 0);

        }
    }
}
