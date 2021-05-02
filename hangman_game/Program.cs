using System;
using System.Collections.Generic;

namespace hangman_game
{  

    class Program
    {
        static List<string> letters = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        static List<string> word = new List<string>();
        static List<string> unknownWord = new List<string>();

        static int lives = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Hangman Game \n");
            createWord();
            startGame();
        }

        public static void createWord() { 
            var random = new Random();
            var wordLength = random.Next(6, 15);
            for (int i = 0; i < wordLength; i++) { 
                var pickLetter = random.Next(0, letters.Count);
                word.Add(letters[pickLetter]); 
                unknownWord.Add("_");              
            }
        }

        public static void startGame() { 
            Console.WriteLine("\nLifes: " + lives + "\n\n" + String.Join(" ", unknownWord) + "\n\nLetter to guess: ");
            while (lives > 0) {
                string letter = Console.ReadLine();
                letter = letter.ToUpper();
                if (word.Contains(letter)) { 
                    for (int i = 0; i < word.Count; i++) { 
                        if (letter == word[i]) { 
                            unknownWord.RemoveAt(i);
                            unknownWord.Insert(i, letter);
                        }
                    }
                    Console.WriteLine("\nLifes: " + lives + "\n\n" + String.Join(" ", unknownWord) + "\n\nLetter to guess: ");
                }
                lives -= 1;
                Console.WriteLine("Lifes: " + lives + "\n\nLetter to guess: ");
            }
            playAgain();
        }

        public static void restart() { 
            word.Clear();
            unknownWord.Clear();
            lives = 5;
        }

        public static void playAgain() {
            Console.WriteLine("\n\nThe word is: " + String.Join("", word) + "\n\nPlay again? Yes (Y) No (N)");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "Y") {
                restart();
                createWord();
                startGame();
            }
            Environment.Exit(0);
        }
    }
}