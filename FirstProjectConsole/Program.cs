using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectConsole
{
    class Program
    {
        public static int[] fillarr(int number)
        {
            int[] array;
            array = new int[3];
            array[0] = number / 100;
            array[1] = (number % 100) / 10;
            array[2] = (number % 100) % 10;
            return array;
        }

        public static int random()
        {
            Random random = new Random();
            int targetNumber = random.Next(100, 900);
            return targetNumber;
        }
        static void Main(string[] args)
        {
            int max_guess = 0;
            int score = 0;
            while(max_guess < 7)
            {
                int random_number = random();
                Console.WriteLine("random number: " + random_number);
                Console.WriteLine("Enter your guess: ");
                int input_guess = int.Parse(Console.ReadLine());
                int[] input_split = fillarr(input_guess);
                int[] random_split = fillarr(random_number);
                string result = "";
                for (int i = 0; i < 3; i++)
                {
                    if (input_split[i] == random_split[i])
                    {
                        result += "+";
                    }
                    else
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (input_split[i] == random_split[j])
                            {
                                result += "?";
                            }
                        }
                    }

                }
                Console.WriteLine("result: " + result);
                if (result == "+++")
                {
                    score++;
                }
                max_guess++;

            }
            if(score > 3)
            {
                Console.WriteLine("You Win !!!");
            }
            else
            {
                Console.WriteLine("Try next time ^^ hihihi ");
            }
        }
    }
}
