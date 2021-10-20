using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task
{
    public class Game
    {
        private Menu _menu;

        public Game()
        {
            _menu = new Menu(new string[] { "Try to bribe the program", "Find a person", "Extract multiples of integer from array", "Exit" });
            CursorVisible = false;
        }

        public void Run()
        {
            int selectedIndex = _menu.RunMenu();
            switch (selectedIndex)
            {
                case 0:
                    RunBribeProgram();
                    break;
                case 1:
                    FindPerson();
                    break;
                case 2:
                    MultiplesOfThree();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }

        private void Exit()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void RunBribeProgram()
        {
            int amount;
            string input = string.Empty;
            ConsoleKey keyPressed;
            do
            {
                Clear();
                Write("Tap some amount to bribe program: ");
                input = ReadLine();
                if (input != null)
                {
                    try
                    {
                        amount = Convert.ToInt32(input);

                        if (amount > 6)
                        {
                            WriteLine("Hello");
                        }
                    }
                    catch (Exception e)
                    {
                        WriteLine($"{e.Message}");
                    }
                }
                Write("Press Escape button to exit.....");
                WriteLine();
                keyPressed = ReadKey().Key;
            } while (keyPressed != ConsoleKey.Escape);
            Exit();
        }

        private void FindPerson()
        {
            string input = string.Empty;
            ConsoleKey keyPressed;
            do
            {
                Clear();
                Write("Tap name to find a person: ");
                input = ReadLine();
                if (input != null)
                {
                    try
                    {
                        if(string.Compare(input, "Вячеслав") == 0)
                        {
                            WriteLine("Привет, Вячеслав");
                        }
                    }
                    catch (Exception e)
                    {
                        WriteLine($"{e.Message}");
                    }
                }
                Write("Press Escape button to exit.....");
                keyPressed = ReadKey().Key;
                WriteLine();
            } while (keyPressed != ConsoleKey.Escape);
            Exit();
        }

        private void MultiplesOfThree()
        {
            string input = string.Empty;
            string[] stringArray;
            int multiple;
            ConsoleKey keyPressed;

            do
            {
                Clear();
                try
                {
                    Write("Tap multiple number: ");
                    multiple = Convert.ToInt32(ReadLine());                    
                    Write("Tap through space, or comma with space button button come numbers: ");
                    input = ReadLine();

                    stringArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    Write($"Multiples of {multiple}: ");

                    for(int i = 0; i < stringArray.Length; i++)
                    {
                        int currentDigit = Convert.ToInt32(stringArray[i]);
                        if(currentDigit % multiple == 0)
                        {
                            Write($"{currentDigit} ");
                        }
                    }
                }
                catch (Exception e)
                {
                    WriteLine($"{e.Message}");
                }
                Write("Press Escape button to exit.....");
                keyPressed = ReadKey().Key;
                WriteLine();
            } while (keyPressed != ConsoleKey.Escape);
            Exit();
        }
    }
}
