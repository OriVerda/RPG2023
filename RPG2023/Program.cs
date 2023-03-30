using System;
using System.IO;
using Newtonsoft.Json;

namespace RPG2023
{
    class Program
    {
        enum Choice
        {
            Option1, Option2, Option3, Option4
        }

        public static string characterName = "Default";
        public static int characterCounter = 3;

        static void Main()
        {
            CharacterName();
            Section00();
        }

        static void CharacterName()
        {
            Console.WriteLine("Please enter a name for your character.");
            characterName = Console.ReadLine() ?? "Default";
            while (string.IsNullOrWhiteSpace(characterName) && characterCounter >= 0)
            {
                if (characterCounter == 0)
                {
                    Console.WriteLine("Character will now be set to default.");
                    characterName = "Arthur";
                    break;
                }
                Console.WriteLine("Character name cannot be null. You have {0} chance(s) left to write an appropriate name.", (characterCounter));
                characterCounter--;
                CharacterName();
            }
        }

        static void Section00() //Test
        {
            Console.WriteLine("Once upon a time, in a far-off kingdom, there was a brave knight named Sir {0}.", characterName);
            Console.WriteLine("One day, the lord of the kingdom called upon Sir {0} for a dangerous mission - to slay a dragon that had been terrorizing nearby villages.", characterName);
            Console.WriteLine("1) Accept mission");
            Console.WriteLine("2) Decline mission");
            Console.WriteLine("3) Lie");
            Console.WriteLine("4) Negotiate with the lord");

            Choice choice = Choice.Option1;
            string input = Console.ReadLine() ?? "Default";
            if (Enum.TryParse(input, out Choice result))
            {
                choice = result;
            }

            switch (choice)
            {
                case Choice.Option1:
                    // Leads to next section
                    break;
                case Choice.Option2:
                    // Leads to next section
                    break;
                case Choice.Option3:
                    // Leads to next section
                    break;
                case Choice.Option4:
                    // Leads to next section
                    break;
                default:
                    // Leads to next section
                    break;
            }
        }
    }
}